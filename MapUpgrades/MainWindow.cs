/*
Demoders MapUpgrades
Copyright (c) 2010-2012 Demoder <demoder@demoder.me>

This program is free software; you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation; version 2 of the License only.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software
Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307
USA
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Demoder.Common;
using Demoder.Common.Serialization;
using MapUpgrades.Xml;
using System.IO;

namespace MapUpgrades
{
    public partial class MainWindow : Form
    {
        FileSystemWatcher fsWatcher = new FileSystemWatcher();	

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindowLoad(object sender, EventArgs e)
        {
            //Setup sorting.
            //Uploadable maps
            Forms.ListViewSorter lvs = new Forms.ListViewSorter();
            lvs.LastSort = lvs.ByColumn = 0;
            Uploadable.ListViewItemSorter = lvs;
            Uploadable.Sorting = SortOrder.Descending; //Somehow, setting this to ascending makes it sort descending, and vice versa....

            //Available
            Forms.ListViewSorter lvs2 = new Forms.ListViewSorter();
            lvs2.LastSort = lvs2.ByColumn = 1;
            Available.ListViewItemSorter = lvs2;
            Available.Sorting = SortOrder.Descending;

            //Uploaded
            Forms.ListViewSorter lvs3 = new Forms.ListViewSorter();
            lvs3.LastSort = lvs3.ByColumn = 0;
            Uploaded.ListViewItemSorter = lvs3;
            Uploaded.Sorting = SortOrder.Ascending;
        }

        private void ApplyButtonClick(object sender, EventArgs e)
        {
            string[] text = _inputText.Text.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            uint mapnav;
            uint.TryParse(this._mapNav.Text, out mapnav);
            ProcessInput(text, mapnav);

        }

        private void ProcessInputStartUpdate()
        {
            Uploadable.BeginUpdate();
            Uploadable.Items.Clear();
            Uploadable.Groups.Clear();

            Uploaded.BeginUpdate();
            Uploaded.Items.Clear();
            Uploaded.Groups.Clear();

            Available.BeginUpdate();
            Available.Items.Clear();
            Available.Groups.Clear();
        }

        private void ProcessInputDoUpdate(uint mapnav, List<Xml.ItemList.Map> maps, List<Xml.ItemList.MapUpgrade> mapupgrades)
        {
            ProcessInputStartUpdate();

            #region MapReaderUpgrades
            ListViewGroup lvg2 = new ListViewGroup("lvg_mapreaderupgrades", "Map Readers");
            lvg2.HeaderAlignment = HorizontalAlignment.Center;
            Uploaded.Groups.Add(lvg2);
            Uploadable.Groups.Add(lvg2);
            Available.Groups.Add(lvg2);
            foreach (Xml.ItemList.MapUpgrade upgrade in Program.ItemList.MapUpgrades)
            {
                ListViewItem lvi = new ListViewItem(new string[] { upgrade.name, upgrade.mapnav.ToString(), upgrade.listname });

                lvi.Group = lvg2;
                if (mapupgrades.Contains(upgrade))
                {
                    //Have map
                    Uploaded.Items.Add(lvi);
                }
                else
                {
                    //Don't have map
                    if (mapnav >= upgrade.mapnav)
                        Uploadable.Items.Add(lvi);
                    else
                        Available.Items.Add(lvi);
                }
            }
            #endregion
            
            #region Maps
            ListViewGroup lvg = new ListViewGroup("lvg_maps", "Maps");
            lvg.HeaderAlignment = HorizontalAlignment.Center;
            Uploaded.Groups.Add(lvg);
            Uploadable.Groups.Add(lvg);
            Available.Groups.Add(lvg);
            foreach (Xml.ItemList.Map map in Program.ItemList.Maps)
            {
                ListViewItem lvi = new ListViewItem(new string[] { map.name, map.mapnav.ToString(), map.zone });
                lvi.Group = lvg;
                if (maps.Contains(map))
                {
                    //Have map
                    Uploaded.Items.Add(lvi);
                }
                else if (mapnav >= map.mapnav)
                {
                    Uploadable.Items.Add(lvi);
                }
                else
                {
                    Available.Items.Add(lvi);
                }
            }
            
            #endregion
            ProcessInputEndUpdate();
        }

        private void ProcessInputEndUpdate()
        {
            Uploadable.EndUpdate();
            Uploaded.EndUpdate();
            Available.EndUpdate();
        }

        /// <summary>
        /// Method to handle sorting of ListViews based on collumns
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColumnClick(object sender, ColumnClickEventArgs e)
        {
            Forms.ListView_ColumnClick(sender, e);
        }

        private void UploadableItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {
                timer_UpdateUploadable.Stop();
                timer_UpdateUploadable.Start();
            }

        }

        private void RemoveUploadedItems(object o, EventArgs e)
        {
            timer_UpdateUploadable.Stop();
            foreach (ListViewItem lvi in Uploadable.Items)
            {
                if (lvi.Checked)
                {
                    Uploadable.Items.Remove(lvi);
                    Uploaded.Items.Add(lvi);
                }
            }
        }

        #region Menu entry: About
        private void AboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }
        #endregion

        #region Manual Input
        private void ProcessInput(string[] txt, uint mapnav)
        {
            string maps = string.Empty;
            string mapupgrades = string.Empty;

            foreach (string t in txt)
            {
                if (t.StartsWith("Maps: "))
                    maps = t.Substring(6);
                if (t.StartsWith("Map reader upgrades: "))
                    mapupgrades = t.Substring(21);
            }

            List<Xml.ItemList.MapUpgrade> havemapupgrades = ProcessMapUpgrades(mapupgrades, mapnav);
            List<Xml.ItemList.Map> havemaps = ProcessMaps(maps, mapnav);
            ProcessInputDoUpdate(mapnav, havemaps, havemapupgrades);
        }

        private List<Xml.ItemList.Map> ProcessMaps(string text, uint mapnav)
        {
            List<Xml.ItemList.Map> havemaps = new List<Xml.ItemList.Map>();

            string[] t = text.Split(".".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            foreach (string t2 in t)
            {
                string map = t2.Trim();
                if (string.IsNullOrEmpty(map)) { continue; }

                foreach (Xml.ItemList.Map m in Program.ItemList.Maps)
                {
                    if (m.zone == map)
                    {
                        havemaps.Add(m);
                    }
                }
            }
            return havemaps;
        }

        private List<Xml.ItemList.MapUpgrade> ProcessMapUpgrades(string upgrades, uint mapnav)
        {
            List<Xml.ItemList.MapUpgrade> haveupgrades = new List<Xml.ItemList.MapUpgrade>();

            string[] t = upgrades.Split(".".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (string t2 in t)
            {
                string upgrade = t2.Trim();
                if (string.IsNullOrEmpty(upgrade)) { continue; }

                foreach (Xml.ItemList.MapUpgrade m in Program.ItemList.MapUpgrades)
                {
                    if (m.listname == upgrade)
                    {
                        haveupgrades.Add(m);
                    }
                }
            }
            return haveupgrades;
        }
        #endregion

    }
}
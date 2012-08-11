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
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Demoder.Common;
using Demoder.Common.Serialization;
using MapUpgrades.Xml;
using System.Text;

namespace MapUpgrades
{
    static class Program
    {
        internal static Xml.ItemList ItemList;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Setup configs etc
            Program.ItemList = Demoder.Common.Serialization.Xml.Deserialize<ItemList>(Properties.Resources.Items, Encoding.ASCII);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}

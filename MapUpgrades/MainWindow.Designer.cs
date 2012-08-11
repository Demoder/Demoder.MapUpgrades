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
namespace MapUpgrades
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._inputText = new System.Windows.Forms.TextBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._mapNav = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Uploadable = new System.Windows.Forms.ListView();
            this.uploadable_Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uploadable_MapNavReq = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uploadable_Comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Available = new System.Windows.Forms.ListView();
            this.Available_Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Available_MapNavReq = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Available_Comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Uploaded = new System.Windows.Forms.ListView();
            this.Uploaded_Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Uploaded_MapNavReq = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Uploaded_Comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer_UpdateUploadable = new System.Windows.Forms.Timer(this.components);
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._inputText);
            this.splitContainer1.Panel1.Controls.Add(this.applyButton);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this._mapNav);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(481, 353);
            this.splitContainer1.SplitterDistance = 129;
            this.splitContainer1.TabIndex = 0;
            // 
            // _inputText
            // 
            this._inputText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._inputText.Location = new System.Drawing.Point(7, 16);
            this._inputText.Multiline = true;
            this._inputText.Name = "_inputText";
            this._inputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._inputText.Size = new System.Drawing.Size(459, 82);
            this._inputText.TabIndex = 6;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(179, 104);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 9;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.ApplyButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Paste from target-self+t:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "MapNav:";
            // 
            // _mapNav
            // 
            this._mapNav.Location = new System.Drawing.Point(73, 104);
            this._mapNav.Name = "_mapNav";
            this._mapNav.Size = new System.Drawing.Size(100, 20);
            this._mapNav.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(481, 220);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Uploadable);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(473, 194);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Uploadable";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Uploadable
            // 
            this.Uploadable.CheckBoxes = true;
            this.Uploadable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.uploadable_Item,
            this.uploadable_MapNavReq,
            this.uploadable_Comment});
            this.Uploadable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Uploadable.Location = new System.Drawing.Point(3, 3);
            this.Uploadable.Name = "Uploadable";
            this.Uploadable.Size = new System.Drawing.Size(467, 188);
            this.Uploadable.TabIndex = 0;
            this.Uploadable.UseCompatibleStateImageBehavior = false;
            this.Uploadable.View = System.Windows.Forms.View.Details;
            this.Uploadable.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ColumnClick);
            this.Uploadable.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.UploadableItemChecked);
            // 
            // uploadable_Item
            // 
            this.uploadable_Item.Text = "Item";
            this.uploadable_Item.Width = 205;
            // 
            // uploadable_MapNavReq
            // 
            this.uploadable_MapNavReq.Text = "MapNav";
            this.uploadable_MapNavReq.Width = 79;
            // 
            // uploadable_Comment
            // 
            this.uploadable_Comment.Text = "Comment";
            this.uploadable_Comment.Width = 141;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Available);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(473, 194);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Available";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Available
            // 
            this.Available.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Available_Item,
            this.Available_MapNavReq,
            this.Available_Comment});
            this.Available.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Available.Location = new System.Drawing.Point(3, 3);
            this.Available.Name = "Available";
            this.Available.Size = new System.Drawing.Size(467, 188);
            this.Available.TabIndex = 0;
            this.Available.UseCompatibleStateImageBehavior = false;
            this.Available.View = System.Windows.Forms.View.Details;
            this.Available.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ColumnClick);
            // 
            // Available_Item
            // 
            this.Available_Item.Text = "Item";
            this.Available_Item.Width = 231;
            // 
            // Available_MapNavReq
            // 
            this.Available_MapNavReq.Text = "MapNav";
            this.Available_MapNavReq.Width = 56;
            // 
            // Available_Comment
            // 
            this.Available_Comment.Text = "Comment";
            this.Available_Comment.Width = 139;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Uploaded);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(473, 194);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Uploaded";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Uploaded
            // 
            this.Uploaded.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Uploaded_Item,
            this.Uploaded_MapNavReq,
            this.Uploaded_Comment});
            this.Uploaded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Uploaded.Location = new System.Drawing.Point(3, 3);
            this.Uploaded.Name = "Uploaded";
            this.Uploaded.Size = new System.Drawing.Size(467, 188);
            this.Uploaded.TabIndex = 0;
            this.Uploaded.UseCompatibleStateImageBehavior = false;
            this.Uploaded.View = System.Windows.Forms.View.Details;
            this.Uploaded.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ColumnClick);
            // 
            // Uploaded_Item
            // 
            this.Uploaded_Item.Text = "Item";
            this.Uploaded_Item.Width = 204;
            // 
            // Uploaded_MapNavReq
            // 
            this.Uploaded_MapNavReq.Text = "MapNav";
            this.Uploaded_MapNavReq.Width = 82;
            // 
            // Uploaded_Comment
            // 
            this.Uploaded_Comment.Text = "Comment";
            this.Uploaded_Comment.Width = 168;
            // 
            // timer_UpdateUploadable
            // 
            this.timer_UpdateUploadable.Interval = 500;
            this.timer_UpdateUploadable.Tick += new System.EventHandler(this.RemoveUploadedItems);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(481, 353);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(481, 377);
            this.toolStripContainer1.TabIndex = 5;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(481, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.toolStripSeparator1,
            this.howToUseToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(131, 6);
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.howToUseToolStripMenuItem.Text = "How to use";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 377);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "What maps am I missing?";
            this.Load += new System.EventHandler(this.MainWindowLoad);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView Uploadable;
        private System.Windows.Forms.ColumnHeader uploadable_Item;
        private System.Windows.Forms.ColumnHeader uploadable_MapNavReq;
        private System.Windows.Forms.ColumnHeader uploadable_Comment;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView Uploaded;
        private System.Windows.Forms.ColumnHeader Uploaded_Item;
        private System.Windows.Forms.ColumnHeader Uploaded_MapNavReq;
        private System.Windows.Forms.ColumnHeader Uploaded_Comment;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView Available;
        private System.Windows.Forms.ColumnHeader Available_Item;
        private System.Windows.Forms.ColumnHeader Available_MapNavReq;
        private System.Windows.Forms.ColumnHeader Available_Comment;
        private System.Windows.Forms.Timer timer_UpdateUploadable;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.TextBox _inputText;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _mapNav;
    }
}


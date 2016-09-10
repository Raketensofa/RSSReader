namespace RSSReader
{
    partial class Mainpage
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainpage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.rSSFeedsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAddNewData = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFeedOverview = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxChooseCategory = new System.Windows.Forms.ComboBox();
            this.listViewFeeds = new System.Windows.Forms.ListView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listViewFeedItems = new System.Windows.Forms.ListView();
            this.feedArticle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.rSSFeedsToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCategories});
            resources.ApplyResources(this.startToolStripMenuItem, "startToolStripMenuItem");
            this.startToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            // 
            // MenuItemCategories
            // 
            this.MenuItemCategories.Name = "MenuItemCategories";
            resources.ApplyResources(this.MenuItemCategories, "MenuItemCategories");
            this.MenuItemCategories.Click += new System.EventHandler(this.MenuItemCategories_Click);
            // 
            // rSSFeedsToolStripMenuItem
            // 
            this.rSSFeedsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAddNewData,
            this.MenuItemFeedOverview});
            resources.ApplyResources(this.rSSFeedsToolStripMenuItem, "rSSFeedsToolStripMenuItem");
            this.rSSFeedsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.rSSFeedsToolStripMenuItem.Name = "rSSFeedsToolStripMenuItem";
            // 
            // MenuItemAddNewData
            // 
            this.MenuItemAddNewData.Name = "MenuItemAddNewData";
            resources.ApplyResources(this.MenuItemAddNewData, "MenuItemAddNewData");
            this.MenuItemAddNewData.Click += new System.EventHandler(this.MenuItemAddNewData_Click);
            // 
            // MenuItemFeedOverview
            // 
            this.MenuItemFeedOverview.Name = "MenuItemFeedOverview";
            resources.ApplyResources(this.MenuItemFeedOverview, "MenuItemFeedOverview");
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.comboBoxChooseCategory);
            this.panel1.Controls.Add(this.listViewFeeds);
            this.panel1.Name = "panel1";
            // 
            // comboBoxChooseCategory
            // 
            resources.ApplyResources(this.comboBoxChooseCategory, "comboBoxChooseCategory");
            this.comboBoxChooseCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseCategory.FormattingEnabled = true;
            this.comboBoxChooseCategory.Name = "comboBoxChooseCategory";
            this.comboBoxChooseCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseCategory_SelectedIndexChanged);
            // 
            // listViewFeeds
            // 
            resources.ApplyResources(this.listViewFeeds, "listViewFeeds");
            this.listViewFeeds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewFeeds.MultiSelect = false;
            this.listViewFeeds.Name = "listViewFeeds";
            this.listViewFeeds.UseCompatibleStateImageBehavior = false;
            this.listViewFeeds.View = System.Windows.Forms.View.List;
            this.listViewFeeds.SelectedIndexChanged += new System.EventHandler(this.listViewFeeds_SelectedIndexChanged);
            // 
            // buttonRefresh
            // 
            resources.ApplyResources(this.buttonRefresh, "buttonRefresh");
            this.buttonRefresh.BackColor = System.Drawing.SystemColors.Window;
            this.buttonRefresh.BackgroundImage = global::RSSReader.Properties.Resources.pic_refresh;
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.listViewFeedItems);
            this.panel2.Name = "panel2";
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.panel4.Controls.Add(this.buttonRefresh);
            this.panel4.Name = "panel4";
            // 
            // listViewFeedItems
            // 
            resources.ApplyResources(this.listViewFeedItems, "listViewFeedItems");
            this.listViewFeedItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewFeedItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.feedArticle});
            this.listViewFeedItems.FullRowSelect = true;
            this.listViewFeedItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewFeedItems.Name = "listViewFeedItems";
            this.listViewFeedItems.UseCompatibleStateImageBehavior = false;
            this.listViewFeedItems.View = System.Windows.Forms.View.Details;
            this.listViewFeedItems.SelectedIndexChanged += new System.EventHandler(this.listViewFeedItems_SelectedIndexChanged);
            // 
            // feedArticle
            // 
            resources.ApplyResources(this.feedArticle, "feedArticle");
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Controls.Add(this.webBrowser);
            this.panel3.Name = "panel3";
            // 
            // webBrowser
            // 
            resources.ApplyResources(this.webBrowser, "webBrowser");
            this.webBrowser.Name = "webBrowser";
            // 
            // Mainpage
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mainpage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rSSFeedsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAddNewData;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFeedOverview;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCategories;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxChooseCategory;
        private System.Windows.Forms.ListView listViewFeeds;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView listViewFeedItems;
        private System.Windows.Forms.ColumnHeader feedArticle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}


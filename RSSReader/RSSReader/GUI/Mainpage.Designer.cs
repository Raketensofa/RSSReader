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
            this.pannelMenuFeeds = new System.Windows.Forms.Panel();
            this.listBoxFeeds = new System.Windows.Forms.ListBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.panelArticles = new System.Windows.Forms.Panel();
            this.panelArticleDetail = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.pannelMenuFeeds.SuspendLayout();
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
            // pannelMenuFeeds
            // 
            resources.ApplyResources(this.pannelMenuFeeds, "pannelMenuFeeds");
            this.pannelMenuFeeds.BackColor = System.Drawing.Color.White;
            this.pannelMenuFeeds.Controls.Add(this.listBoxFeeds);
            this.pannelMenuFeeds.Controls.Add(this.comboBoxCategory);
            this.pannelMenuFeeds.Name = "pannelMenuFeeds";
            // 
            // listBoxFeeds
            // 
            resources.ApplyResources(this.listBoxFeeds, "listBoxFeeds");
            this.listBoxFeeds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBoxFeeds.FormattingEnabled = true;
            this.listBoxFeeds.Name = "listBoxFeeds";
            this.listBoxFeeds.Sorted = true;
            this.listBoxFeeds.SelectedIndexChanged += new System.EventHandler(this.listBoxFeeds_SelectedIndexChanged);
            // 
            // comboBoxCategory
            // 
            resources.ApplyResources(this.comboBoxCategory, "comboBoxCategory");
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Name = "comboBoxCategory";
            // 
            // panelArticles
            // 
            resources.ApplyResources(this.panelArticles, "panelArticles");
            this.panelArticles.Name = "panelArticles";
            // 
            // panelArticleDetail
            // 
            resources.ApplyResources(this.panelArticleDetail, "panelArticleDetail");
            this.panelArticleDetail.Name = "panelArticleDetail";
            // 
            // Mainpage
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.panelArticleDetail);
            this.Controls.Add(this.panelArticles);
            this.Controls.Add(this.pannelMenuFeeds);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mainpage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pannelMenuFeeds.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rSSFeedsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAddNewData;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFeedOverview;
        private System.Windows.Forms.Panel pannelMenuFeeds;
        private System.Windows.Forms.Panel panelArticles;
        private System.Windows.Forms.Panel panelArticleDetail;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCategories;
        private System.Windows.Forms.ListBox listBoxFeeds;
    }
}


namespace RSSReader.GUI
{
    partial class FormSettings
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAllFeeds = new System.Windows.Forms.Button();
            this.buttonNewFeed = new System.Windows.Forms.Button();
            this.buttonCategories = new System.Windows.Forms.Button();
            this.mainpanelSettings = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.buttonAllFeeds);
            this.flowLayoutPanel1.Controls.Add(this.buttonNewFeed);
            this.flowLayoutPanel1.Controls.Add(this.buttonCategories);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 336);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonAllFeeds
            // 
            this.buttonAllFeeds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAllFeeds.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAllFeeds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.buttonAllFeeds.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAllFeeds.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllFeeds.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonAllFeeds.Location = new System.Drawing.Point(3, 3);
            this.buttonAllFeeds.Name = "buttonAllFeeds";
            this.buttonAllFeeds.Size = new System.Drawing.Size(200, 113);
            this.buttonAllFeeds.TabIndex = 0;
            this.buttonAllFeeds.Text = "Rss-Feeds";
            this.buttonAllFeeds.UseVisualStyleBackColor = false;
            this.buttonAllFeeds.Click += new System.EventHandler(this.buttonAllFeeds_Click);
            // 
            // buttonNewFeed
            // 
            this.buttonNewFeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewFeed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNewFeed.BackColor = System.Drawing.Color.Crimson;
            this.buttonNewFeed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNewFeed.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewFeed.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonNewFeed.Location = new System.Drawing.Point(3, 122);
            this.buttonNewFeed.Name = "buttonNewFeed";
            this.buttonNewFeed.Size = new System.Drawing.Size(200, 100);
            this.buttonNewFeed.TabIndex = 1;
            this.buttonNewFeed.Text = "Neuer Feed";
            this.buttonNewFeed.UseVisualStyleBackColor = false;
            this.buttonNewFeed.Click += new System.EventHandler(this.buttonNewFeed_Click);
            // 
            // buttonCategories
            // 
            this.buttonCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCategories.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.buttonCategories.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCategories.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCategories.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonCategories.Location = new System.Drawing.Point(3, 228);
            this.buttonCategories.Name = "buttonCategories";
            this.buttonCategories.Size = new System.Drawing.Size(200, 100);
            this.buttonCategories.TabIndex = 2;
            this.buttonCategories.Text = "Kategorien";
            this.buttonCategories.UseVisualStyleBackColor = false;
            this.buttonCategories.Click += new System.EventHandler(this.buttonCategories_Click);
            // 
            // mainpanelSettings
            // 
            this.mainpanelSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainpanelSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainpanelSettings.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainpanelSettings.Location = new System.Drawing.Point(315, 72);
            this.mainpanelSettings.Name = "mainpanelSettings";
            this.mainpanelSettings.Size = new System.Drawing.Size(665, 603);
            this.mainpanelSettings.TabIndex = 1;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1010, 728);
            this.Controls.Add(this.mainpanelSettings);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FormSettings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Einstellungen";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonAllFeeds;
        private System.Windows.Forms.Button buttonNewFeed;
        private System.Windows.Forms.Button buttonCategories;
        private System.Windows.Forms.Panel mainpanelSettings;
    }
}
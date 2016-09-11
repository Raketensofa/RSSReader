namespace RSSReader.GUI
{
    partial class PanelNewFeed
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelNewFeed));
            this.buttonSaveFeed = new System.Windows.Forms.Button();
            this.buttonCheckLink = new System.Windows.Forms.Button();
            this.textBoxFeedLink = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFeedName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFeedCategory = new System.Windows.Forms.ComboBox();
            this.labelCheckLinkResult = new System.Windows.Forms.Label();
            this.labelSaveResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSaveFeed
            // 
            this.buttonSaveFeed.BackColor = System.Drawing.Color.Crimson;
            resources.ApplyResources(this.buttonSaveFeed, "buttonSaveFeed");
            this.buttonSaveFeed.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonSaveFeed.Name = "buttonSaveFeed";
            this.buttonSaveFeed.UseVisualStyleBackColor = false;
            this.buttonSaveFeed.Click += new System.EventHandler(this.buttonSaveFeed_Click_1);
            // 
            // buttonCheckLink
            // 
            resources.ApplyResources(this.buttonCheckLink, "buttonCheckLink");
            this.buttonCheckLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.buttonCheckLink.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonCheckLink.Name = "buttonCheckLink";
            this.buttonCheckLink.UseVisualStyleBackColor = false;
            this.buttonCheckLink.Click += new System.EventHandler(this.buttonCheckLink_Click_1);
            // 
            // textBoxFeedLink
            // 
            this.textBoxFeedLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxFeedLink, "textBoxFeedLink");
            this.textBoxFeedLink.Name = "textBoxFeedLink";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Name = "label3";
            // 
            // textBoxFeedName
            // 
            this.textBoxFeedName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxFeedName, "textBoxFeedName");
            this.textBoxFeedName.Name = "textBoxFeedName";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Name = "label1";
            // 
            // comboBoxFeedCategory
            // 
            this.comboBoxFeedCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxFeedCategory, "comboBoxFeedCategory");
            this.comboBoxFeedCategory.FormattingEnabled = true;
            this.comboBoxFeedCategory.Name = "comboBoxFeedCategory";
            this.comboBoxFeedCategory.Sorted = true;
            // 
            // labelCheckLinkResult
            // 
            resources.ApplyResources(this.labelCheckLinkResult, "labelCheckLinkResult");
            this.labelCheckLinkResult.Name = "labelCheckLinkResult";
            // 
            // labelSaveResult
            // 
            resources.ApplyResources(this.labelSaveResult, "labelSaveResult");
            this.labelSaveResult.Name = "labelSaveResult";
            // 
            // PanelNewFeed
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.labelSaveResult);
            this.Controls.Add(this.textBoxFeedLink);
            this.Controls.Add(this.buttonCheckLink);
            this.Controls.Add(this.labelCheckLinkResult);
            this.Controls.Add(this.buttonSaveFeed);
            this.Controls.Add(this.comboBoxFeedCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFeedName);
            this.Controls.Add(this.label2);
            this.Name = "PanelNewFeed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSaveFeed;
        private System.Windows.Forms.Button buttonCheckLink;
        private System.Windows.Forms.TextBox textBoxFeedLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFeedName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFeedCategory;
        private System.Windows.Forms.Label labelCheckLinkResult;
        private System.Windows.Forms.Label labelSaveResult;
    }
}

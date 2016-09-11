namespace RSSReader.GUI
{
    partial class PanelAllFeeds
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
            this.buttonDeleteFeed = new System.Windows.Forms.Button();
            this.buttonEditFeed = new System.Windows.Forms.Button();
            this.listViewFeeds = new System.Windows.Forms.ListView();
            this.columnFeedName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxHeader = new System.Windows.Forms.TextBox();
            this.textBoxUpdateFeedLink = new System.Windows.Forms.TextBox();
            this.panelData = new System.Windows.Forms.Panel();
            this.textBoxUpdateFeedName = new System.Windows.Forms.TextBox();
            this.comboBoxUpdateFeedCategory = new System.Windows.Forms.ComboBox();
            this.labelSaveCategory = new System.Windows.Forms.Label();
            this.buttonSaveUpdateFeed = new System.Windows.Forms.Button();
            this.panelData.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDeleteFeed
            // 
            this.buttonDeleteFeed.BackColor = System.Drawing.Color.Silver;
            this.buttonDeleteFeed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteFeed.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteFeed.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonDeleteFeed.Location = new System.Drawing.Point(127, 177);
            this.buttonDeleteFeed.Name = "buttonDeleteFeed";
            this.buttonDeleteFeed.Size = new System.Drawing.Size(110, 45);
            this.buttonDeleteFeed.TabIndex = 15;
            this.buttonDeleteFeed.Text = "Löschen";
            this.buttonDeleteFeed.UseVisualStyleBackColor = false;
            this.buttonDeleteFeed.Click += new System.EventHandler(this.buttonDeleteFeed_Click);
            // 
            // buttonEditFeed
            // 
            this.buttonEditFeed.BackColor = System.Drawing.Color.Silver;
            this.buttonEditFeed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEditFeed.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditFeed.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonEditFeed.Location = new System.Drawing.Point(2, 177);
            this.buttonEditFeed.Name = "buttonEditFeed";
            this.buttonEditFeed.Size = new System.Drawing.Size(110, 45);
            this.buttonEditFeed.TabIndex = 14;
            this.buttonEditFeed.Text = "Bearbeiten";
            this.buttonEditFeed.UseVisualStyleBackColor = false;
            this.buttonEditFeed.Click += new System.EventHandler(this.buttonEditFeed_Click);
            // 
            // listViewFeeds
            // 
            this.listViewFeeds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewFeeds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFeedName});
            this.listViewFeeds.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewFeeds.FullRowSelect = true;
            this.listViewFeeds.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewFeeds.Location = new System.Drawing.Point(0, 0);
            this.listViewFeeds.MultiSelect = false;
            this.listViewFeeds.Name = "listViewFeeds";
            this.listViewFeeds.Size = new System.Drawing.Size(450, 155);
            this.listViewFeeds.TabIndex = 12;
            this.listViewFeeds.UseCompatibleStateImageBehavior = false;
            this.listViewFeeds.View = System.Windows.Forms.View.Details;
            this.listViewFeeds.SelectedIndexChanged += new System.EventHandler(this.listViewFeeds_SelectedIndexChanged);
            // 
            // columnFeedName
            // 
            this.columnFeedName.Text = "Rss Feed";
            this.columnFeedName.Width = 400;
            // 
            // textBoxHeader
            // 
            this.textBoxHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHeader.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHeader.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxHeader.Location = new System.Drawing.Point(2, 242);
            this.textBoxHeader.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxHeader.Name = "textBoxHeader";
            this.textBoxHeader.ReadOnly = true;
            this.textBoxHeader.Size = new System.Drawing.Size(448, 32);
            this.textBoxHeader.TabIndex = 17;
            this.textBoxHeader.Text = "  Feed bearbeiten";
            // 
            // textBoxUpdateFeedLink
            // 
            this.textBoxUpdateFeedLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUpdateFeedLink.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUpdateFeedLink.Location = new System.Drawing.Point(17, 25);
            this.textBoxUpdateFeedLink.Name = "textBoxUpdateFeedLink";
            this.textBoxUpdateFeedLink.ReadOnly = true;
            this.textBoxUpdateFeedLink.Size = new System.Drawing.Size(408, 32);
            this.textBoxUpdateFeedLink.TabIndex = 3;
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.SystemColors.Window;
            this.panelData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelData.Controls.Add(this.textBoxUpdateFeedName);
            this.panelData.Controls.Add(this.comboBoxUpdateFeedCategory);
            this.panelData.Controls.Add(this.labelSaveCategory);
            this.panelData.Controls.Add(this.textBoxUpdateFeedLink);
            this.panelData.Controls.Add(this.buttonSaveUpdateFeed);
            this.panelData.Location = new System.Drawing.Point(2, 265);
            this.panelData.Margin = new System.Windows.Forms.Padding(0);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(448, 211);
            this.panelData.TabIndex = 16;
            // 
            // textBoxUpdateFeedName
            // 
            this.textBoxUpdateFeedName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUpdateFeedName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUpdateFeedName.Location = new System.Drawing.Point(17, 69);
            this.textBoxUpdateFeedName.Name = "textBoxUpdateFeedName";
            this.textBoxUpdateFeedName.Size = new System.Drawing.Size(408, 32);
            this.textBoxUpdateFeedName.TabIndex = 8;
            // 
            // comboBoxUpdateFeedCategory
            // 
            this.comboBoxUpdateFeedCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUpdateFeedCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUpdateFeedCategory.FormattingEnabled = true;
            this.comboBoxUpdateFeedCategory.Location = new System.Drawing.Point(17, 116);
            this.comboBoxUpdateFeedCategory.Name = "comboBoxUpdateFeedCategory";
            this.comboBoxUpdateFeedCategory.Size = new System.Drawing.Size(408, 32);
            this.comboBoxUpdateFeedCategory.TabIndex = 7;
            // 
            // labelSaveCategory
            // 
            this.labelSaveCategory.AutoSize = true;
            this.labelSaveCategory.Font = new System.Drawing.Font("Calibri", 12F);
            this.labelSaveCategory.Location = new System.Drawing.Point(134, 69);
            this.labelSaveCategory.Name = "labelSaveCategory";
            this.labelSaveCategory.Size = new System.Drawing.Size(0, 24);
            this.labelSaveCategory.TabIndex = 6;
            // 
            // buttonSaveUpdateFeed
            // 
            this.buttonSaveUpdateFeed.BackColor = System.Drawing.Color.Crimson;
            this.buttonSaveUpdateFeed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSaveUpdateFeed.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveUpdateFeed.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonSaveUpdateFeed.Location = new System.Drawing.Point(17, 164);
            this.buttonSaveUpdateFeed.Name = "buttonSaveUpdateFeed";
            this.buttonSaveUpdateFeed.Size = new System.Drawing.Size(100, 32);
            this.buttonSaveUpdateFeed.TabIndex = 5;
            this.buttonSaveUpdateFeed.Text = "Speichern";
            this.buttonSaveUpdateFeed.UseVisualStyleBackColor = false;
            this.buttonSaveUpdateFeed.Click += new System.EventHandler(this.buttonSaveUpdateFeed_Click);
            // 
            // PanelAllFeeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.textBoxHeader);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.buttonDeleteFeed);
            this.Controls.Add(this.buttonEditFeed);
            this.Controls.Add(this.listViewFeeds);
            this.Name = "PanelAllFeeds";
            this.Size = new System.Drawing.Size(454, 478);
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeleteFeed;
        private System.Windows.Forms.Button buttonEditFeed;
        private System.Windows.Forms.ListView listViewFeeds;
        private System.Windows.Forms.ColumnHeader columnFeedName;
        private System.Windows.Forms.TextBox textBoxHeader;
        private System.Windows.Forms.TextBox textBoxUpdateFeedLink;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Label labelSaveCategory;
        private System.Windows.Forms.Button buttonSaveUpdateFeed;
        private System.Windows.Forms.ComboBox comboBoxUpdateFeedCategory;
        private System.Windows.Forms.TextBox textBoxUpdateFeedName;
    }
}

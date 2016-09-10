namespace RSSReader.GUI
{
    partial class FormFeed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFeed));
            this.comboBoxFeedCategory = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxFeedLink = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFeedName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSaveFeed = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxFeedCategory
            // 
            this.comboBoxFeedCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFeedCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFeedCategory.FormattingEnabled = true;
            this.comboBoxFeedCategory.ItemHeight = 25;
            this.comboBoxFeedCategory.Location = new System.Drawing.Point(58, 215);
            this.comboBoxFeedCategory.MaxDropDownItems = 4;
            this.comboBoxFeedCategory.Name = "comboBoxFeedCategory";
            this.comboBoxFeedCategory.Size = new System.Drawing.Size(333, 33);
            this.comboBoxFeedCategory.Sorted = true;
            this.comboBoxFeedCategory.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.textBoxFeedLink);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxFeedName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxFeedCategory);
            this.panel1.Location = new System.Drawing.Point(37, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 274);
            this.panel1.TabIndex = 2;
            // 
            // textBoxFeedLink
            // 
            this.textBoxFeedLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFeedLink.Location = new System.Drawing.Point(58, 131);
            this.textBoxFeedLink.Name = "textBoxFeedLink";
            this.textBoxFeedLink.Size = new System.Drawing.Size(333, 30);
            this.textBoxFeedLink.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Link*";
            // 
            // textBoxFeedName
            // 
            this.textBoxFeedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFeedName.Location = new System.Drawing.Point(58, 49);
            this.textBoxFeedName.Name = "textBoxFeedName";
            this.textBoxFeedName.Size = new System.Drawing.Size(333, 30);
            this.textBoxFeedName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bezeichnung*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategorie";
            // 
            // buttonSaveFeed
            // 
            this.buttonSaveFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveFeed.Location = new System.Drawing.Point(164, 331);
            this.buttonSaveFeed.Name = "buttonSaveFeed";
            this.buttonSaveFeed.Size = new System.Drawing.Size(200, 50);
            this.buttonSaveFeed.TabIndex = 4;
            this.buttonSaveFeed.Text = "Speichern";
            this.buttonSaveFeed.UseVisualStyleBackColor = true;
            this.buttonSaveFeed.Click += new System.EventHandler(this.buttonSaveFeed_Click);
            // 
            // FormFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(532, 403);
            this.Controls.Add(this.buttonSaveFeed);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFeed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neuen Feed erfassen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFeedCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxFeedName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFeedLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSaveFeed;
    }
}
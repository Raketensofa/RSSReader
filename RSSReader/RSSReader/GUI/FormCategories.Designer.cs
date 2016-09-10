namespace RSSReader.GUI
{
    partial class FormCategories
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
            this.textBoxNewCategoryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSaveNewCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNewCategoryName
            // 
            this.textBoxNewCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewCategoryName.Location = new System.Drawing.Point(97, 440);
            this.textBoxNewCategoryName.Name = "textBoxNewCategoryName";
            this.textBoxNewCategoryName.Size = new System.Drawing.Size(253, 30);
            this.textBoxNewCategoryName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Neue Kategorie erfassen";
            // 
            // buttonSaveNewCategory
            // 
            this.buttonSaveNewCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveNewCategory.Location = new System.Drawing.Point(356, 438);
            this.buttonSaveNewCategory.Name = "buttonSaveNewCategory";
            this.buttonSaveNewCategory.Size = new System.Drawing.Size(97, 32);
            this.buttonSaveNewCategory.TabIndex = 2;
            this.buttonSaveNewCategory.Text = "Speichern";
            this.buttonSaveNewCategory.UseVisualStyleBackColor = true;
            this.buttonSaveNewCategory.Click += new System.EventHandler(this.buttonSaveNewCategory_Click);
            // 
            // FormCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 530);
            this.Controls.Add(this.buttonSaveNewCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNewCategoryName);
            this.Name = "FormCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCategories";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNewCategoryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSaveNewCategory;
    }
}
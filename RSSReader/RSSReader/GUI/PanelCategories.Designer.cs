namespace RSSReader.GUI
{
    partial class PanelCategories
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
            this.buttonSaveNewCategory = new System.Windows.Forms.Button();
            this.textBoxNewCategoryName = new System.Windows.Forms.TextBox();
            this.listViewCategories = new System.Windows.Forms.ListView();
            this.columnCategoryName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelData = new System.Windows.Forms.Panel();
            this.labelSaveCategory = new System.Windows.Forms.Label();
            this.textBoxHeader = new System.Windows.Forms.TextBox();
            this.buttonNewCategory = new System.Windows.Forms.Button();
            this.buttonEditCategory = new System.Windows.Forms.Button();
            this.buttonDeleteCategory = new System.Windows.Forms.Button();
            this.panelData.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSaveNewCategory
            // 
            this.buttonSaveNewCategory.BackColor = System.Drawing.Color.Crimson;
            this.buttonSaveNewCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSaveNewCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveNewCategory.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonSaveNewCategory.Location = new System.Drawing.Point(17, 65);
            this.buttonSaveNewCategory.Name = "buttonSaveNewCategory";
            this.buttonSaveNewCategory.Size = new System.Drawing.Size(100, 32);
            this.buttonSaveNewCategory.TabIndex = 5;
            this.buttonSaveNewCategory.Text = "Speichern";
            this.buttonSaveNewCategory.UseVisualStyleBackColor = false;
            this.buttonSaveNewCategory.Click += new System.EventHandler(this.buttonSaveNewCategory_Click);
            // 
            // textBoxNewCategoryName
            // 
            this.textBoxNewCategoryName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewCategoryName.Location = new System.Drawing.Point(17, 25);
            this.textBoxNewCategoryName.Name = "textBoxNewCategoryName";
            this.textBoxNewCategoryName.Size = new System.Drawing.Size(325, 32);
            this.textBoxNewCategoryName.TabIndex = 3;
            // 
            // listViewCategories
            // 
            this.listViewCategories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewCategories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCategoryName});
            this.listViewCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCategories.FullRowSelect = true;
            this.listViewCategories.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewCategories.Location = new System.Drawing.Point(0, 0);
            this.listViewCategories.MultiSelect = false;
            this.listViewCategories.Name = "listViewCategories";
            this.listViewCategories.Size = new System.Drawing.Size(368, 155);
            this.listViewCategories.TabIndex = 6;
            this.listViewCategories.UseCompatibleStateImageBehavior = false;
            this.listViewCategories.View = System.Windows.Forms.View.Details;
            this.listViewCategories.SelectedIndexChanged += new System.EventHandler(this.listViewCategories_SelectedIndexChanged);
            // 
            // columnCategoryName
            // 
            this.columnCategoryName.Width = 300;
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.SystemColors.Window;
            this.panelData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelData.Controls.Add(this.labelSaveCategory);
            this.panelData.Controls.Add(this.textBoxNewCategoryName);
            this.panelData.Controls.Add(this.buttonSaveNewCategory);
            this.panelData.Location = new System.Drawing.Point(0, 279);
            this.panelData.Margin = new System.Windows.Forms.Padding(0);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(368, 118);
            this.panelData.TabIndex = 7;
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
            // textBoxHeader
            // 
            this.textBoxHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHeader.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHeader.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxHeader.Location = new System.Drawing.Point(0, 256);
            this.textBoxHeader.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxHeader.Name = "textBoxHeader";
            this.textBoxHeader.ReadOnly = true;
            this.textBoxHeader.Size = new System.Drawing.Size(368, 32);
            this.textBoxHeader.TabIndex = 8;
            // 
            // buttonNewCategory
            // 
            this.buttonNewCategory.BackColor = System.Drawing.Color.Silver;
            this.buttonNewCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNewCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewCategory.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonNewCategory.Location = new System.Drawing.Point(0, 176);
            this.buttonNewCategory.Name = "buttonNewCategory";
            this.buttonNewCategory.Size = new System.Drawing.Size(110, 45);
            this.buttonNewCategory.TabIndex = 9;
            this.buttonNewCategory.Text = "Neu";
            this.buttonNewCategory.UseVisualStyleBackColor = false;
            this.buttonNewCategory.Click += new System.EventHandler(this.buttonNewCategory_Click);
            // 
            // buttonEditCategory
            // 
            this.buttonEditCategory.BackColor = System.Drawing.Color.Silver;
            this.buttonEditCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEditCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditCategory.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonEditCategory.Location = new System.Drawing.Point(129, 176);
            this.buttonEditCategory.Name = "buttonEditCategory";
            this.buttonEditCategory.Size = new System.Drawing.Size(110, 45);
            this.buttonEditCategory.TabIndex = 10;
            this.buttonEditCategory.Text = "Bearbeiten";
            this.buttonEditCategory.UseVisualStyleBackColor = false;
            this.buttonEditCategory.Click += new System.EventHandler(this.buttonEditCategory_Click);
            // 
            // buttonDeleteCategory
            // 
            this.buttonDeleteCategory.BackColor = System.Drawing.Color.Silver;
            this.buttonDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteCategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteCategory.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonDeleteCategory.Location = new System.Drawing.Point(258, 176);
            this.buttonDeleteCategory.Name = "buttonDeleteCategory";
            this.buttonDeleteCategory.Size = new System.Drawing.Size(110, 45);
            this.buttonDeleteCategory.TabIndex = 11;
            this.buttonDeleteCategory.Text = "Löschen";
            this.buttonDeleteCategory.UseVisualStyleBackColor = false;
            this.buttonDeleteCategory.Click += new System.EventHandler(this.buttonDeleteCategory_Click);
            // 
            // PanelCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.buttonDeleteCategory);
            this.Controls.Add(this.buttonEditCategory);
            this.Controls.Add(this.buttonNewCategory);
            this.Controls.Add(this.textBoxHeader);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.listViewCategories);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PanelCategories";
            this.Size = new System.Drawing.Size(370, 399);
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveNewCategory;
        private System.Windows.Forms.TextBox textBoxNewCategoryName;
        private System.Windows.Forms.ListView listViewCategories;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.TextBox textBoxHeader;
        private System.Windows.Forms.Label labelSaveCategory;
        private System.Windows.Forms.Button buttonNewCategory;
        private System.Windows.Forms.Button buttonEditCategory;
        private System.Windows.Forms.Button buttonDeleteCategory;
        private System.Windows.Forms.ColumnHeader columnCategoryName;
    }
}

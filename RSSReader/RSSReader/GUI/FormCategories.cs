using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 * author: Carolin Gellner
 */
namespace RSSReader.GUI
{
    /// <summary>
    /// Repraesentiert ein Fenster zum Verwalten der Kategorien.
    /// </summary>
    public partial class FormCategories : Form
    {

        #region Fields

        private Database _Database;

        #endregion


        #region Constructor

        /// <summary>
        /// 
        /// </summary>
        /// <param name="database"></param>
        public FormCategories(Database database)
        {
            InitializeComponent();

            _Database = database;
        }

        #endregion


        #region Private Methods Click-Events

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveNewCategory_Click(object sender, EventArgs e)
        {
            saveNewCategory();
        }

        #endregion


        #region Private Methods

        /// <summary>
        /// Speichert eine neue erfasste Kategorie in der Datenbank.
        /// </summary>
        private void saveNewCategory()
        {
            string categoryName = textBoxNewCategoryName.Text;

            if (!string.IsNullOrEmpty(categoryName))
            {
                //Pruefung, ob Kategoriename bereits existiert
                if(_Database.existsCategory(categoryName) == false)
                {
                    //Kategorie in der Datenbank speichern
                    bool saved = _Database.saveNewCategory(categoryName);

                    //Information anzeigen
                    if(saved == true)
                    {
                        showInfo("saved");
                        textBoxNewCategoryName.Text = string.Empty;
                    }
                    else
                    {
                        showInfo("notsaved");
                    }

                }else
                {
                    showInfo("exists");
                }
            }
            else
            {
                showInfo("empty");
            }

        }


        /// <summary>
        /// Zeigt eine MessageBox mit einem  Informationstext entsprechend der uebergebenen Option an.
        /// </summary>
        /// <param name="option"></param>
        private void showInfo(string option)
        {
            switch (option)
            {
                case "saved":
                    MessageBox.Show("Kategorie gespeichert.", "Information", MessageBoxButtons.OK, MessageBoxIcon.None);
                    break;

                case "notsaved":
                    MessageBox.Show("Kategorie wurde nicht gespeichert.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case "empty":
                    MessageBox.Show("Kein Kategorie-Name erfasst. Bitte ergänzen!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "exists":
                    MessageBox.Show("Kategorie existiert bereits!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

            }
        }

        #endregion

    }
}

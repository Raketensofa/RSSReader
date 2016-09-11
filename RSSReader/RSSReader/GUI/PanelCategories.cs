using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using RSSReader.Objects;
using RSSReader.Source;

/*
 * author: Carolin Gellner
 */
namespace RSSReader.GUI
{
    /// <summary>
    /// Repraesentiert ein Benutzersteuerelement welches eine Oberflaeche zum Verwalten der Kategorien beinhaltet.
    /// </summary>
    public partial class PanelCategories : UserControl
    {

        #region Fields

        private Database _Database;
        private List<Category> _CategoryList;
        private string _EditType;
        private int _SelectedCategoryId;

        #endregion


        #region Constructor

        /// <summary>
        /// Erstellt eine neue Instant der Klasse PanelCategories, welche eine Oberflaeche zum Verwalten der Kategorien beinhaltet.
        /// </summary>
        /// <param name="database">SQLite Datenbank</param>
        public PanelCategories(Database database)
        {
            InitializeComponent();

            Cursor.Current = Cursors.WaitCursor;

            _Database = database;

            //Editierbereich ausblenden
            showInputPanel(false);

            //Kategorien auflisten
            fillCategoryListView();


            Cursor.Current = Cursors.Default;
        }

        #endregion


        #region (Private) Methods

        /// <summary>
        /// 
        /// </summary>
        private void fillCategoryListView()
        {
            listViewCategories.Items.Clear();

            _CategoryList = _Database.getAllCategories();

            if (_CategoryList != null)
            {
                foreach (Category category in _CategoryList)
                {
                    listViewCategories.Items.Add(category.Name);
                }
            }      	
        }
     
        /// <summary>
        /// Speichert eine neue erfasste Kategorie in der Datenbank.
        /// </summary>
        private void saveCategory(string editType)
        {
            Cursor.Current = Cursors.WaitCursor;

            bool saved = false;

            if (isInputCorrect() == true)
            {
                switch (editType)
                {
                    case "new":
                        saved = _Database.saveNewCategory(textBoxNewCategoryName.Text);
                        break;

                    case "edit":
                        saved = _Database.updateCategoryName(_SelectedCategoryId, textBoxNewCategoryName.Text);
                        break;
                }

                finishSave(saved);
             
            }

            Cursor.Current = Cursors.Default;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isSaved"></param>
        private void finishSave(bool isSaved)
        {
            if (isSaved == true)
            {
                showInfo("saved");
                textBoxNewCategoryName.Text = string.Empty;
                fillCategoryListView();
            }
            else
            {
                showInfo("notsaved");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool isInputCorrect()
        {
            bool correct = false;

            if (!string.IsNullOrEmpty(textBoxNewCategoryName.Text))
            {
                //Pruefung, ob Kategoriename bereits existiert
                if (_Database.existsCategory(textBoxNewCategoryName.Text) == false)
                {
                    correct = true;

                }else
                {
                    showInfo("exists");
                }

            }else
            {
                showInfo("empty");
            }

            return correct;
        }

        /// <summary>
        /// Zeigt einen  Informationstext entsprechend der uebergebenen Option an.
        /// </summary>
        /// <param name="option"></param>
        private void showInfo(string option)
        {
            switch (option)
            {
                case "saved":
                    labelSaveCategory.Text = "Kategorie gespeichert.";
                    labelSaveCategory.ForeColor = Color.DarkGreen;
                    break;

                case "notsaved":
                    labelSaveCategory.Text = "Kategorie wurde nicht gespeichert.";
                    labelSaveCategory.ForeColor = Color.Red;
                    break;

                case "empty":
                    labelSaveCategory.Text = "Kein Kategorie-Name erfasst.Bitte ergänzen!";
                    labelSaveCategory.ForeColor = Color.Red;
                    break;

                case "exists":
                    labelSaveCategory.Text = "Kategorie existiert bereits!";
                    labelSaveCategory.ForeColor = Color.Red;
                    break;

                case "delete":
                    labelSaveCategory.Text = "Kategorie wurde gelöscht.";
                    labelSaveCategory.ForeColor = Color.DarkGreen;
                    break;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="categoryId"></param>
        private void setDefaultFeedCategoryId()
        {
            List<Feed> alleFeeds = _Database.getAllFeeds(_SelectedCategoryId);

            foreach (Feed feed in alleFeeds)
            {
                _Database.updateFeedCategoryId(feed.Id, 0);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="show"></param>
        /// <param name="headerText"></param>
        private void showInputPanel(bool show)
        {
            panelData.Visible = show;
            textBoxHeader.Visible = show;
            buttonSaveNewCategory.Visible = show;
            textBoxNewCategoryName.Visible = show;
        }

        #endregion


        #region Eventhandler

        /// <summary>
        /// Eventhandler des Buttons 'Speichern'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveNewCategory_Click(object sender, EventArgs e)
        {
            saveCategory(_EditType);
        }

        /// <summary>
        /// Eventhandler der ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCategories.SelectedItems.Count > 0)
            {
                int selectedIndex = listViewCategories.SelectedItems[0].Index;

                _SelectedCategoryId = _CategoryList.ElementAt(selectedIndex).ID;

            }
            else
            {
                _SelectedCategoryId = 0;
            }

        }

        /// <summary>
        /// Eventhandler des Buttons 'Neu'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewCategory_Click(object sender, EventArgs e)
        {
            _SelectedCategoryId = 0;
            if (listViewCategories.SelectedItems.Count > 0)
            {
                listViewCategories.SelectedItems[0].Selected = false;
            }

            textBoxNewCategoryName.Text = string.Empty;
            labelSaveCategory.Text = string.Empty;

            _EditType = "new";

            textBoxHeader.Text = "  Neue Kategorie erfassen";

            showInputPanel(true);

        }

        /// <summary>
        /// Eventhandler des Buttons 'Bearbeiten'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditCategory_Click(object sender, EventArgs e)
        {
            if (listViewCategories.SelectedItems.Count > 0)
            {
                _EditType = "edit";

                textBoxHeader.Text = "  Kategorie umbenennen";

                textBoxNewCategoryName.Text = _CategoryList.Find(category => category.ID == _SelectedCategoryId).Name;

                showInputPanel(true);
            }
            else
            {
                showInputPanel(false);
            }
        }

        /// <summary>
        /// Eventhandler des Buttons 'Loeschen'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteCategory_Click(object sender, EventArgs e)
        {
            showInputPanel(false);

            if (_SelectedCategoryId > 0)
            {
                bool delete =_Database.deleteCategory(_SelectedCategoryId);

                if (delete == true)
                {
                    showInfo("delete");
                    setDefaultFeedCategoryId();
                    fillCategoryListView();
                }
            }
        }

        #endregion

    }
}

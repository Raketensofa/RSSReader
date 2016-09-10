using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RSSReader.Objects;

/*
 * author: Carolin Gellner
 */
namespace RSSReader.GUI
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FormFeed : Form
    {

        #region Fields

        private Database _Database;
        private List<Category> _CategoriesList;

        #endregion


        #region Constructor

        /// <summary>
        /// Erstellt eine neue Instanz der Klasse FormFeed.
        /// </summary>
        /// <param name="database">Datenbank</param>
        public FormFeed(Database database)
        {
            InitializeComponent();
            _Database = database;

            fillCategoryComboBox();
        }

        #endregion


        #region Private Methods

        /// <summary>
        /// 
        /// </summary>
        private void saveFeed()
        {
            Feed feed = readInputData();

            if(isFeedCompletely(feed) == true)
            {
               bool saved = _Database.saveNewFeed(feed);

                if(saved == true)
                {
                    showInfo("saved");
                    this.Close();

                }else
                {
                    showInfo("notsaved");
                }

            }else
            {
                showInfo("empty");
            }
        }

        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Feed readInputData()
        {
            Feed feed = new Feed();

            feed.Name = textBoxFeedName.Text;
            feed.Link = textBoxFeedLink.Text;

            string category = comboBoxFeedCategory.Text;
            feed.UserCategoryId = findCategoryId(category);

            return feed;
        }


        /// <summary>
        /// Fuellt die Combobox mit den Namen aller Kategorien.
        /// </summary>
        private void fillCategoryComboBox()
        {
            _CategoriesList = new List<Category>();
            _CategoriesList = _Database.getAllCategories();

            if (_CategoriesList != null)
            {
                foreach (Category category in _CategoriesList)
                {
                    comboBoxFeedCategory.Items.Add(category.Name);
                }
            }
        }

        #endregion



        private void buttonSaveFeed_Click(object sender, EventArgs e)
        {
            saveFeed();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="categoryName"></param>
        /// <returns></returns>
        private int findCategoryId(string categoryName)
        {
            int id = 0;

            Category result =_CategoriesList.Find(category => category.Name == categoryName);

            if(result != null)
            {
                id = result.ID;
            }

            return id;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="feed"></param>
        /// <returns></returns>
        private bool isFeedCompletely(Feed feed)
        {
            bool completely = false;

            if(!string.IsNullOrEmpty(feed.Name) && !string.IsNullOrEmpty(feed.Link))
            {
                completely = true;
            }

            return completely;
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
                    MessageBox.Show("Feed gespeichert.", "Information", MessageBoxButtons.OK, MessageBoxIcon.None);
                    break;

                case "notsaved":
                    MessageBox.Show("Feed wurde nicht gespeichert.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case "empty":
                    MessageBox.Show("Daten sind unvollständig. Bitte ergänzen!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "exists":
                    MessageBox.Show("Ein Feed mit der Bezeichnung oder dem Link existiert bereits!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

            }
        }
    }
}

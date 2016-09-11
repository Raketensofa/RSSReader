using System.Windows.Forms;
using RSSReader.Source;
using System.Collections.Generic;
using RSSReader.Objects;
using System.Linq;

using System.Drawing;

/*
 * author: Carolin Gellner
 */
namespace RSSReader.GUI
{

    /// <summary>
    /// Repraesentiert ein Benutzersteuerlement zum Verwalten der Feeds.
    /// </summary>
    public partial class PanelAllFeeds : UserControl
    {

        #region Fields

        private Database _Database;
        private List<Feed> _FeedList;
        private int _FeedId;
        private List<Category> _CategoryList;

        #endregion


        #region Constructor

        /// <summary>
        /// Erstellt eine neue Instanz der Klasse PanelAllFeed, welche ein Benutzersteuerlement zum Verwalten der Feeds darstellt.
        /// </summary>
        /// <param name="database">SQLite Datenbank</param>
        public PanelAllFeeds(Database database)
        {
            InitializeComponent();

            Cursor.Current = Cursors.WaitCursor;

            _Database = database;

            _CategoryList = _Database.getAllCategories();

            fillCategoryComboBox();

            //Editierbereich ausblenden
            showInputPanel(false);

            //Feeds auflisten
            fillFeedListView();

            Cursor.Current = Cursors.Default;
        }

        #endregion


        #region (Private) Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="show"></param>
        private void showInputPanel(bool show)
        {
            panelData.Visible = show;
            textBoxHeader.Visible = show;
            buttonSaveUpdateFeed.Visible = show;
            textBoxUpdateFeedLink.Visible = show;
            comboBoxUpdateFeedCategory.Visible = show;
        }

        /// <summary>
        /// 
        /// </summary>
        private void fillFeedListView()
        {
            listViewFeeds.Items.Clear();

            _FeedList = _Database.getAllFeeds(-1);

            if (_FeedList != null)
            {
                foreach (Feed feed in _FeedList)
                {
                    listViewFeeds.Items.Add(feed.Name);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void updateFeed()
        {
            Cursor.Current = Cursors.WaitCursor;

            bool saved = false;

            if (isInputEmpty() == true)
            {
                int categoryId = findCategoryId();

                saved = _Database.updateFeed(_FeedId, textBoxUpdateFeedName.Text, categoryId);

                finishSave(saved);
            }

            Cursor.Current = Cursors.Default;

        }

        /// <summary>
        /// 
        /// </summary>
        private void fillCategoryComboBox()
        {
            comboBoxUpdateFeedCategory.Items.Clear();

            if (_CategoryList != null)
            {
                foreach(Category category in _CategoryList)
                {
                    comboBoxUpdateFeedCategory.Items.Add(category.Name);
                }
            }
        }

        /// <summary>
        /// Ermittelt die ID der ausgewaehlten Kategorie.
        /// </summary>
        /// <returns></returns>
        private int findCategoryId()
        {
            //Default - 'keine Kategorie'
            int id = 0;

            int selectedIndex = comboBoxUpdateFeedCategory.SelectedIndex;

            if(selectedIndex == 0)
            {
                id = 0;

            }else
            {
                id = _CategoryList.ElementAt(selectedIndex - 1).ID;
            }


            return id;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool isInputEmpty()
        {
            bool empty = false;

            if (string.IsNullOrEmpty(textBoxUpdateFeedName.Text))
            {
                empty = true;
            }

            return empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isSaved"></param>
        private void finishSave(bool isSaved)
        {
            if (isSaved == true)
            {
                textBoxUpdateFeedLink.Text = string.Empty;
                textBoxUpdateFeedLink.Text = string.Empty;
                comboBoxUpdateFeedCategory.Items.Clear();

                fillFeedListView();
            }
        }

        #endregion


        #region Eventhandler

        /// <summary>
        /// Eventhandler der ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewFeeds_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (listViewFeeds.SelectedItems.Count > 0)
            {
                int selectedIndex = listViewFeeds.SelectedItems[0].Index;

                _FeedId = _FeedList[selectedIndex].Id;
            }
            else
            {
                _FeedId = 0;
            }
        }

        /// <summary>
        /// Eventhandler des des Buttons 'Bearbeiten'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditFeed_Click(object sender, System.EventArgs e)
        {
            if (listViewFeeds.SelectedItems.Count > 0)
            {
                fillCategoryComboBox();

                textBoxUpdateFeedLink.Text = _FeedList.Find(feed => feed.Id == _FeedId).Link;
                textBoxUpdateFeedName.Text = _FeedList.Find(feed => feed.Id == _FeedId).Name;

                int categoryId = _FeedList.Find(feed => feed.Id == _FeedId).UserCategoryId;
                int index = _CategoryList.IndexOf(_CategoryList.Find(category => category.ID == categoryId));

                comboBoxUpdateFeedCategory.SelectedIndex = index;

                showInputPanel(true);
            }
            else
            {
                showInputPanel(false);
            }
        }

        /// <summary>
        ///  Eventhandler des des Buttons 'Loeschen'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteFeed_Click(object sender, System.EventArgs e)
        {
            showInputPanel(false);

           bool delete = _Database.deleteFeed(_FeedId);

            if(delete == true)
            {
                fillFeedListView();
            }

        }

        /// <summary>
        /// Eventhandler des des Buttons 'Speichern'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveUpdateFeed_Click(object sender, System.EventArgs e)
        {
            updateFeed();
        }

        #endregion
    }
}

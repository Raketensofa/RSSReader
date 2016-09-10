using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RSSReader.GUI;
using RSSReader.Objects;

/*
 * author: Carolin Gellner
 */
namespace RSSReader
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Mainpage : Form 
    {

        #region Fields

        private Database _Database;
        private List<Feed> _FeedList;
        private List<FeedItem> _FeedItems;
        private List<Category> _CategoryList;

        #endregion


        #region Constructor

        public Mainpage() 
        {
            InitializeComponent();

            init();
        }

        #endregion


        #region Private Methods Click-Events

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemAddNewData_Click(object sender, EventArgs e)
        {
            FormFeed newFeed = new FormFeed(_Database);
            newFeed.ShowDialog();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemCategories_Click(object sender, EventArgs e)
        {
            FormCategories formCategories = new FormCategories(_Database);
            formCategories.ShowDialog();
        }


        #endregion


        #region Private Methods

        /// <summary>
        /// 
        /// </summary>
        private void init()
        {
            _Database = new Database();

            createFeedList();

            fillComboBoxWithCategories();

            fillFeedListBox();
        }


        /// <summary>
        /// 
        /// </summary>
        private void createFeedList()
        {
            _FeedList = _Database.getAllFeeds();

            List<Feed> sortedList = _FeedList.OrderBy(feed => feed.Name).ToList();
            _FeedList = sortedList;

            setAllBasicFeedInfos();
        }


        /// <summary>
        /// 
        /// </summary>
        private void fillFeedListBox()
        {          
            if (_FeedList != null)
            {
                listViewFeeds.Clear();

                foreach (Feed feed in _FeedList)
                { 
                    listViewFeeds.Items.Add(feed.Name);
                }
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private void fillFeedItemsListView()
        {
            if (_FeedItems != null)
            {
                listViewFeedItems.Items.Clear() ;

                foreach (FeedItem feedItem in _FeedItems)
                {
                    listViewFeedItems.Items.Add(feedItem.Title);     
                }

                listViewFeedItems.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            }
        }

        #endregion


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxFeedItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            createFeedItemDetailView();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewFeeds_SelectedIndexChanged(object sender, EventArgs e)
        {
            createFeedItemView();
        }


        /// <summary>
        /// 
        /// </summary>
        private void createFeedItemDetailView()
        {

        }


        /// <summary>
        /// 
        /// </summary>
        private void createFeedItemView()
        {
            //DB-Id des gewaehlten Items ermitteln
            if (listViewFeeds.SelectedItems.Count > 0)
            {
                //Feed-Objekt aus der Feedliste holen und url ermitteln
                int index = listViewFeeds.SelectedItems[0].Index;
                Feed selectedFeed = _FeedList.ElementAt(index);

                //Alle FeedItem von der Feed-Url abfragen
               _FeedItems = selectedFeed.getFeedItems();
       
                fillFeedItemsListView();

            }

        }


        /// <summary>
        /// 
        /// </summary>
        private void setAllBasicFeedInfos()
        {
            if(_FeedList != null)
            {
                foreach(Feed feed in _FeedList)
                {
                    feed.setFeedInfosFromUrl();
                }
            }

        }


        /// <summary>
        /// 
        /// </summary>
        private void fillComboBoxWithCategories()
        {
            _CategoryList = _Database.getAllCategories();

            comboBoxChooseCategory.Items.Clear();

            comboBoxChooseCategory.Items.Add("Alle Kategorien");

            if (_CategoryList != null)
            {
                foreach (Category category in _CategoryList)
                {
                    comboBoxChooseCategory.Items.Add(category.Name);
                }
            }

            comboBoxChooseCategory.SelectedIndex = 0;
        }


        /// <summary>
        /// 
        /// </summary>
        private void updateFeedListView()
        {
            int selectedIndex = comboBoxChooseCategory.SelectedIndex;
            int categoryId = 0;

            if (selectedIndex > 0)
            {
                categoryId = _CategoryList.ElementAt(selectedIndex - 1).ID;
            }

            listViewFeeds.Clear();

            foreach (Feed feed in _FeedList)
            {
                if(selectedIndex == 0 || feed.UserCategoryId == categoryId)
                {
                    listViewFeeds.Items.Add(feed.Name);
                }
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            createFeedItemView();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxChooseCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateFeedListView();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewFeedItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFeedItems.SelectedItems.Count > 0)
            {
                int index = listViewFeedItems.SelectedItems[0].Index;

                FeedItem item = _FeedItems.ElementAt(index);

                try
                {
                    webBrowser.ScriptErrorsSuppressed = true;
                    webBrowser.Navigate(item.ArticleUrl);

                }catch(Exception)
                {
                    webBrowser.Stop();
                }
            }
          
        }
    }
}

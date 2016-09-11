using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using RSSReader.GUI;
using RSSReader.Objects;
using RSSReader.Source;

/*
 * author: Carolin Gellner
 */
namespace RSSReader
{
    /// <summary>
    /// Repraesentiert das GUI-Hauptfenster der Anwendung.
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

        /// <summary>
        /// Erstellt eine neue Instanz der Klasse Mainpage, welche das Hauptfenster der Anwendung darstellt.
        /// </summary>
        public Mainpage() 
        {
            InitializeComponent();

            init();
        }

        #endregion


        #region (Private) Methods

        /// <summary>
        /// Initialisierungsmethode
        /// </summary>
        private void init()
        {
            _Database = new Database();

            createFeedList();

            fillComboBoxWithCategories();

            fillFeedListView();
        }

        /// <summary>
        /// Erstellt eine Liste mit allen Feeds und deren Basis-Informationen aus der Datenbank und dem Internet.
        /// </summary>
        private void createFeedList()
        {
            _FeedList = _Database.getAllFeeds(-1);

            List<Feed> sortedList = _FeedList.OrderBy(feed => feed.Name).ToList();
            _FeedList = sortedList;

            setAllBasicFeedInfos();
        }

        /// <summary>
        /// Ermittelt die Daten zum Feed entspreched des angegebenem Links.
        /// </summary>
        private void setAllBasicFeedInfos()
        {
            if (_FeedList != null)
            {
                foreach (Feed feed in _FeedList)
                {
                    feed.setFeedInfosFromUrl();
                }
            }

        }

        /// <summary>
        /// Fuellt die ListView mit allen Feed-Titeln
        /// </summary>
        private void fillFeedListView()
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
        /// Fuellt die ComboBox mit allen Kategorie-Namen aus der Datenbank, welche zum Filter der Feeds nach Kategorien genutzt wird.
        /// </summary>
        private void fillComboBoxWithCategories()
        {
            _CategoryList = _Database.getAllCategories();

            comboBoxChooseCategory.Items.Clear();

            comboBoxChooseCategory.Items.Add("Alle Kategorien");
            comboBoxChooseCategory.Items.Add("Feeds ohne Kategorie");

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
        /// Erstellt eine ListView, welche alle Artikel eines Feeds beinhaltet.
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
        /// Fuellt die ListView mit allen Artikel-Titeln eines Feeds.
        /// </summary>
        private void fillFeedItemsListView()
        {
            if (_FeedItems != null)
            {
                listViewFeedItems.Items.Clear();

                foreach (FeedItem feedItem in _FeedItems)
                {
                    listViewFeedItems.Items.Add(feedItem.Title);
                }

                listViewFeedItems.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            }
        }

        /// <summary>
        /// Aktualisiert die Liste mit den Feeds z.B. nach dem Filtern nach einer Kategorie.
        /// </summary>
        private void updateFeedListView()
        {
            //Id ermitteln
            int categoryId = getElectedCategoryId(); 

            listViewFeeds.Items.Clear();

            //Feedliste aktualisieren und nur mit den Feeds mit der Category-Id fuellen
            _FeedList = _Database.getAllFeeds(categoryId);

            if (_FeedList != null)
            {
                //Feed-Titlen der ListView hinzufuegen
                foreach (Feed feed in _FeedList)
                {
                    listViewFeeds.Items.Add(feed.Name);
                }
            }
        }

        /// <summary>
        /// Ermittelt die Id der Kategorie welche vom Benutzer in der ComboxBox gewaehlt wurde.
        /// </summary>
        /// <returns>Kategorie-Id</returns>
        private int getElectedCategoryId()
        {
            int categoryId = -2; //Default

            int selectedIndex = comboBoxChooseCategory.SelectedIndex;

            //Categorie-Id ermitteln
            if (selectedIndex > 1)
            {
                //Kategorie ausgewaehlt
                categoryId = _CategoryList.ElementAt(selectedIndex - 2).ID;

            }
            else if (selectedIndex == 0)
            {
                //Alle Kategorien gewaehlt
                categoryId = -1;
            }
            else if (selectedIndex == 1)
            {
                //Feeds ohne Kategorien gewaehlt
                categoryId = 0;
            }

            return categoryId;
        }

        /// <summary>
        /// Zeigt einen geaehlten Artikel als Webseite im Webbrowser-Panel an.
        /// </summary>
        private void showArticleInWebbrowser()
        {
            if (listViewFeedItems.SelectedItems.Count > 0)
            {
                int index = listViewFeedItems.SelectedItems[0].Index;

                FeedItem item = _FeedItems.ElementAt(index);

                try
                {
                    webBrowser.ScriptErrorsSuppressed = true;
                    webBrowser.Navigate(item.ArticleUrl);
                }
                catch (Exception)
                {
                    webBrowser.Stop();
                }
            }
        }

        #endregion


        #region Eventhandler

        /// <summary>
        /// Eventhandler fuer einen Klick auf den Button "Feeds und Kategorien verwalten".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonManage_Click(object sender, EventArgs e)
        {
            FormSettings form = new FormSettings(_Database);
            form.ShowDialog();
        }

        /// <summary>
        /// Eventhandler fuer das Auswaehlen eines Feed-Titels in der entsprechenden ListView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewFeeds_SelectedIndexChanged(object sender, EventArgs e)
        {
            createFeedItemView();
        }

        /// <summary>
        /// Eventhandler fuer das Auswaehlen/Filtern einer Kategorie in der ComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxChooseCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateFeedListView();
        }

        /// <summary>
        /// Eventhandler fuer das Auswaehlen eines Feed-Artikel-Titels in der entsprechenden ListView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewFeedItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            showArticleInWebbrowser();
        }

        #endregion

    }
}

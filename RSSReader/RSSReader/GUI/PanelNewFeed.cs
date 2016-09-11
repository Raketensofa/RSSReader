using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using RSSReader.Objects;
using RSSReader.Source;


/*
 * author: Carolin Gellner
 */
namespace RSSReader.GUI
{
    /// <summary>
    /// Repraesentiert ein Benutersteuerlement welches zum Erfassen eines neuen Feeds dient.
    /// </summary>
    public partial class PanelNewFeed : UserControl
    {

        #region Fields

        private Database _Database;
        private List<Category> _CategoriesList;

        #endregion


        #region Constructor

        /// <summary>
        /// Erstellt eine neue Instant der Klasse PanelNewFeed, welches ein Benutzersteuerlement zum Erfassen eines neuen Feeds darstellt.
        /// </summary>
        /// <param name="database"></param>
        public PanelNewFeed(Database database)
        {
            InitializeComponent();

            _Database = database;

            fillCategoryComboBox();

            textBoxFeedName.Enabled = false;
            comboBoxFeedCategory.Enabled = false;
        }

        #endregion


        #region Private Methods

        /// <summary>
        /// Ueberprueft den eingegebenen Link des Feeds.
        /// </summary>
        private void checkInputFeedLink()
        {
            Cursor.Current = Cursors.WaitCursor;

            //alle Felder leeren
            textBoxFeedName.Text = string.Empty;
            textBoxFeedName.Enabled = false;
            comboBoxFeedCategory.Enabled = false;
            labelCheckLinkResult.Text = string.Empty;

            //eingetragenen Link auslesen
            string inputLink = textBoxFeedLink.Text;

            if (inputLink.Length > 0)
            {
                Feed feed = new Feed();
                feed.Link = inputLink;

                //Informationen zum RSS-Feed-Link ermitteln
                feed.setFeedInfosFromUrl();

                //wenn Informationen korrekt ermittelt werden konnten insbesondere ein Titel,
                //dann gilt die Pruefung als bestanden und der Titel kann verwendet werden
                if (feed.Title != null && feed.Title.Length > 0)
                {
                    //Ueberpruefen ob der Link bereits in der Datenbank existiert
                    bool exists = _Database.existsFeedLink(feed.Link);

                    if (exists == false)
                    {
                        //positive Information zum Ergebnis ausgeben
                        labelCheckLinkResult.Text = "Der Link kann verwendet werden.";
                        labelCheckLinkResult.ForeColor = Color.DarkGreen;


                        //ermittelten Feed-Titel in die Textbox eintragen und die Felder freigeben
                        textBoxFeedName.Text = feed.Title;
                        textBoxFeedName.Enabled = true;
                        comboBoxFeedCategory.Enabled = true;

                    }
                    else
                    {
                        // Information ausgeben, dass er Link bereits erfasst wurde
                        labelCheckLinkResult.Text = "Der Link wurde bereits von Ihnen erfasst.";
                        labelCheckLinkResult.ForeColor = Color.Red;
                    }

                }
                else
                {
                    //negative Information zum Ergebnis ausgeben
                    labelCheckLinkResult.Text = "Der Link kann nicht verwendet werden.";
                    labelCheckLinkResult.ForeColor = Color.Red;
                }
            }

            Cursor.Current = Cursors.Default;
        }

        /// <summary>
        /// Speichert den eingetragenen Feed in der Datenbank.
        /// </summary>
        private void saveFeed()
        {
            Feed feed = readInputData();

            if (isFeedCompletely(feed) == true)
            {
                bool saved = _Database.saveNewFeed(feed);

                if (saved == true)
                {
                    showInfo("saved");
                }
                else
                {
                    showInfo("notsaved");
                }

            }
            else
            {
                showInfo("empty");
            }
        }

        /// <summary>
        /// Liesst die eingetragenene Feed-Daten aus.
        /// </summary>
        /// <returns>Feed</returns>
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

        /// <summary>
        /// Ermittelt die ID der ausgewaehlten Kategorie.
        /// </summary>
        /// <param name="categoryName"></param>
        /// <returns></returns>
        private int findCategoryId(string categoryName)
        {
            //Default - 'keine Kategorie'
            int id = 0;
  
            Category result = _CategoriesList.Find(category => category.Name == categoryName);

            if (result != null)
            {
                id = result.ID;
            }

            return id;
        }

        /// <summary>
        /// Ueberprueft ob die Daten vollstaendig sind d.h. ob ein Link und eine Bezeichnung erfasst wurden
        /// </summary>
        /// <param name="feed">Feed</param>
        /// <returns>true: vollstaendig - false: unvollstaendig</returns>
        private bool isFeedCompletely(Feed feed)
        {
            bool completely = false;

            if (!string.IsNullOrEmpty(feed.Name) && !string.IsNullOrEmpty(feed.Link))
            {
                completely = true;
            }

            return completely;
        }

        /// <summary>
        /// Zeigt einen Informationstext entsprechend der uebergebenen Option an.
        /// </summary>
        /// <param name="option"></param>
        private void showInfo(string option)
        {
            switch (option)
            {
                case "saved":
                    labelSaveResult.Text = "Feed gespeichert.";
                    labelSaveResult.ForeColor = Color.DarkGreen;
                    break;

                case "notsaved":
                    labelSaveResult.Text = "Feed wurde nicht gespeichert.";
                    labelSaveResult.ForeColor = Color.Red;
                    break;

                case "empty":
                    labelSaveResult.Text = "Daten sind unvollständig. Bitte ergänzen!";
                    labelSaveResult.ForeColor = Color.Red;
                    break;

                case "exists":
                    labelSaveResult.Text = "Ein Feed mit der Bezeichnung oder dem Link existiert bereits!";
                    labelSaveResult.ForeColor = Color.Red;
                    break;
            }
        }

   
        #endregion


        #region Eventhandler

        /// <summary>
        /// Eventhandler des Buttons 'pruefen'.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCheckLink_Click_1(object sender, EventArgs e)
        {
            checkInputFeedLink();
        }

        /// <summary>
        /// Eventhandler des Buttons 'speichern'.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveFeed_Click_1(object sender, EventArgs e)
        {
            saveFeed();
        }

        #endregion
    }
}


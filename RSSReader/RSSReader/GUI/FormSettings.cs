using System;
using System.Windows.Forms;
using RSSReader.Source;

/*
 * author: Carolin Gellner
 */
namespace RSSReader.GUI
{
    /// <summary>
    /// Repraesentiert eine Oberflaeche zum Verwalten der Feeds und Kategorien.
    /// </summary>
    public partial class FormSettings : Form
    {

        #region Fields

        private Database _Database;

        #endregion


        #region Constructor

        /// <summary>
        /// 
        /// </summary>
        /// <param name="database"></param>
        public FormSettings(Database database)
        {
            InitializeComponent();

            _Database = database;
        }

        #endregion


        #region (Private) Methods

        /// <summary>
        /// Uebergibt dem Hautpanel das Element welches angezeigt werden soll.
        /// </summary>
        /// <param name="userControl"></param>
        private void addNewUserControl(Control userControl)
        {
            mainpanelSettings.Controls.Clear();
            mainpanelSettings.Controls.Add(userControl);
        }

        #endregion


        #region Eventhandler

        /// <summary>
        /// v des Buttons 'Neuer Feed'.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewFeed_Click(object sender, EventArgs e)
        {
            addNewUserControl(new PanelNewFeed(_Database));
        }

        /// <summary>
        /// Click-Event des Buttons 'Kategorien'.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCategories_Click(object sender, EventArgs e)
        {
            addNewUserControl(new PanelCategories(_Database));
        }

        /// <summary>
        /// Click-Event des Buttons 'Rss Feeds'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAllFeeds_Click(object sender, EventArgs e)
        {
            addNewUserControl(new PanelAllFeeds(_Database));
        }

        #endregion



    }
}

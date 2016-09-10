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

            fillFeedListBox();
        }

        /// <summary>
        /// 
        /// </summary>
        private void fillFeedListBox()
        {
            _FeedList = _Database.getAllFeeds();

            if (_FeedList != null)
            {
                foreach (Feed feed in _FeedList)
                {
                    listBoxFeeds.Items.Add(feed.Name);
                }
            }
        }



        #endregion

        private void listBoxFeeds_SelectedIndexChanged(object sender, EventArgs e)
        {



        }
    }
}

using System;
using System.Collections.Generic;
using System.Xml;
using System.ServiceModel.Syndication;

/*
 * author: Carolin Gellner
 */
namespace RSSReader.Objects
{

    /// <summary>
    /// Repraesentiert einen Feed.
    /// </summary>
    public class Feed
    {

        #region Fields

        private int _Id;
        private string _Name;
        private string _Link;
        private int _CategoryId;
        private string _ImageUrl;
        private string _LastUpdated;
        private string _Description;
        private string _Title;

        #endregion


        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public int Id
        {
            set { _Id = value; }
            get { return _Id; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            set { _Name = value; }
            get { return _Name; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Link
        {
            set { _Link = value; }
            get { return _Link; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int UserCategoryId
        {
            set { _CategoryId = value; }
            get { return _CategoryId; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string ImageUrl
        {
            set { _ImageUrl = value; }
            get { return _ImageUrl; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string LastUpdated
        {
            set { _LastUpdated = value; }
            get { return _LastUpdated; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Description
        {
            set { _Description = value; }
            get { return _Description; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Title
        {
            set { _Title = value; }
            get { return _Title; }
        }

        #endregion


        #region (Public) Methods

        /// <summary>
        /// Ermittelt die FeedItems / Artikel fuer den Feed und speichert diese in einer Liste.
        /// </summary>
        /// <returns>Liste mit FeedItems (Artikeln)</returns>
        public List<FeedItem> getFeedItems()
        {
            List<FeedItem> feedItemsList = null;

            XmlReader reader = null;
            SyndicationFeed feed = null;

            try
            {
                if (_Link != null)
                {
                    reader = XmlReader.Create(_Link);
                    feed = SyndicationFeed.Load(reader);
                    reader.Close();

                    feedItemsList = new List<FeedItem>();

                    foreach (SyndicationItem item in feed.Items)
                    {
                        FeedItem feedItem = new FeedItem();
                        feedItem.ArticleUrl = item.Id;
                        feedItem.Title = item.Title.Text;
                        feedItem.Summary = item.Summary.Text;
                        feedItem.PublishDate = item.PublishDate.ToString("dd.MM.yyyy HH:mm");

                        feedItemsList.Add(feedItem);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("getFeedItems(): " + ex.Message);
                return null;
            }

            return feedItemsList;
        }

        /// <summary>
        /// Ermittelt die Basisinformationen des Feeds und legt diese fest.
        /// </summary>
        public void setFeedInfosFromUrl()
        {
            XmlReader reader = null;
            SyndicationFeed synFeed = null;

            try
            {
                if (_Link != null)
                {
                    reader = XmlReader.Create(_Link);
                    synFeed = SyndicationFeed.Load(reader);
                    reader.Close();

                    //_ImageUrl = synFeed.ImageUrl.AbsoluteUri
                    //_LastUpdated = synFeed.LastUpdatedTime.
                    _Description = synFeed.Description.Text;
                    _Title = synFeed.Title.Text;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("setFeedInfosFromUrl(): " + ex.Message + " " + ex.StackTrace);
            }
        }

        #endregion

    }
}

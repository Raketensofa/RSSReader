using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.ServiceModel.Syndication;

namespace RSSReader.Objects
{
    public class Feed
    {

        private int _Id;
        private string _Name;
        private string _Link;
        private int _CategoryId;
        private string _ImageUrl;
        private string _LastUpdated;
        private string _Description;
        private string _Title;



        #region Properties

        public int Id
        {
            set { _Id = value; }
            get { return _Id; }
        }

        public string Name
        {
            set { _Name = value; }
            get { return _Name; }
        }

        public string Link
        {
            set { _Link = value; }
            get { return _Link; }
        }

        public int UserCategoryId
        {
            set { _CategoryId = value; }
            get { return _CategoryId; }
        }

        public string ImageUrl
        {
            set { _ImageUrl = value; }
            get { return _ImageUrl; }
        }

        public string LastUpdated
        {
            set { _LastUpdated = value; }
            get { return _LastUpdated; }
        }

        public string Description
        {
            set { _Description = value; }
            get { return _Description; }
        }

        public string Title
        {
            set { _Title = value; }
            get { return _Title; }
        }

        #endregion


        /// <summary>
        /// 
        /// </summary>
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
        /// 
        /// </summary>
        /// <param name="feed"></param>
        /// <returns></returns>
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

                   // _ImageUrl = synFeed.ImageUrl.AbsoluteUri;
                   // _LastUpdated = synFeed.LastUpdatedTime.ToString();
                    _Description = synFeed.Description.ToString();
                    _Title = synFeed.Title.ToString();

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("setFeedInfosFromUrl(): " + ex.Message + " " + ex.StackTrace);
            }
        }


    }
}

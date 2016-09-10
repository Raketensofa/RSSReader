using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RSSReader.Objects
{
    /// <summary>
    /// 
    /// </summary>
    public class FeedItem
    {

        private int _FeedDbId;
        private string _ArticleUrl;
        private string _Title;
        private string _Summary;
        private string _PublishDate;


        public int FeedDbId
        {
            set { _FeedDbId = value; }
            get { return _FeedDbId; }
        }

        public string ArticleUrl
        {
            set { _ArticleUrl = value; }
            get { return _ArticleUrl; }
        }

        public string Title
        {
            set { _Title = value; }
            get { return _Title; }
        }

        public string Summary
        {
            set { _Summary = value; }
            get { return _Summary; }
        }

        public string PublishDate
        {
            set { _PublishDate = value; }
            get { return _PublishDate; }
        }

 

    }
}

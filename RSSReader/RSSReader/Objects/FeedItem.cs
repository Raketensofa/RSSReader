
/*
 * author: Carolin Gellner
 */
namespace RSSReader.Objects
{
    /// <summary>
    /// Repraesentiert eine FeedItem / Artikel.
    /// </summary>
    public class FeedItem
    {

        #region Fields

        private int _FeedDbId;
        private string _ArticleUrl;
        private string _Title;
        private string _Summary;
        private string _PublishDate;

        #endregion


        #region properties

        /// <summary>
        /// 
        /// </summary>
        public int FeedDbId
        {
            set { _FeedDbId = value; }
            get { return _FeedDbId; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string ArticleUrl
        {
            set { _ArticleUrl = value; }
            get { return _ArticleUrl; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Title
        {
            set { _Title = value; }
            get { return _Title; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Summary
        {
            set { _Summary = value; }
            get { return _Summary; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string PublishDate
        {
            set { _PublishDate = value; }
            get { return _PublishDate; }
        }

        #endregion

    }
}

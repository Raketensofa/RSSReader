using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.ServiceModel.Syndication;



namespace RSSReader
{
    public class Parser
    {






        public void parseFeed(string feedUrl)
        {

            XmlReader reader = XmlReader.Create(feedUrl);
            SyndicationFeed feed = SyndicationFeed.Load(reader);

            reader.Close();

            foreach (SyndicationItem item in feed.Items)
            {
               
                string subject = item.Title.Text;
                string summary = item.Summary.Text;
                string id = item.Id;
            

            }

        }




}
}

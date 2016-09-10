using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RSSReader.Objects
{
    public class Feed
    {
        private int _Id;
        private string _Name;
        private string _Link;
        private int _CategoryId;

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

        public int CategoryId
        {
            set { _CategoryId = value; }
            get { return _CategoryId; }
        }

    }
}

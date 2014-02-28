using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Divan
{
    public class AssetChangeRecord
    {
        private DateTime date;
        private string lastValue;
        private string type;
        private Asset asset;
        private Changable changedItem;

        public Changable ChangedItem
        {
            get { return changedItem; }
            set { changedItem = value; }
        }

        public Asset Asset
        {
            get { return asset; }
            set { asset = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string LastValue
        {
            get { return lastValue; }
            set { lastValue = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public void restore()
        {
            //TODO
        }

    }
}

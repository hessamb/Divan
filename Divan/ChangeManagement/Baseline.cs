using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Divan
{
    public class Baseline
    {
        private DateTime date;
        private List<Asset> assets;
        private List<Label> labels;
        private List<Action> actions;

        public List<Action> Actions
        {
            get { return actions; }
            set { actions = value; }
        }

        public List<Label> Labels
        {
            get { return labels; }
            set { labels = value; }
        }
        
        public List<Asset> Assets
        {
            get { return assets; }
            set { assets = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public void Restore()
        {
            //TODO
        }

        public void Create()
        {
            //TODO
        }

    }
}

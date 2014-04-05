using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Divan
{
    public class CompositeLabel:Label
    {
        private List<Label> subLabels;

        public List<Label> SubLabels
        {
            get { return subLabels; }
            set { subLabels = value; }
        }

        public void AddSubLabel(Label label)
        {
            //TODO
        }

        public void RemoveSubLabel(Label label)
        {
            //TODO
        }

    }
}

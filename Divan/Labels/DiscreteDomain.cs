using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divan
{
    public partial class DiscreteDomain:LabelDomain
    {

        public DiscreteDomain(bool isOrdered)
        {
            this.isOrdered = isOrdered;
        }

        public override int compare(string value1, string value2)
        {
            //TODO
            return base.compare(value1, value2);
        }

        public override bool isDiscrete()
        {
            return true;
        }

        public override bool IsValidValue(string value)
        {
            //TODO
            return base.IsValidValue(value);
        }

    }
}

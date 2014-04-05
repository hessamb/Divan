using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Divan
{
    public partial class ContinuousDomain:LabelDomain
    {

        public ContinuousDomain(float minValue, float maxValue): base()
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
        }

        public override int compare(string value1, string value2)
        {
            //TODO
            return base.compare(value1, value2);
        }

        public override bool isDiscrete()
        {
            return false;
        }

        public override bool IsValidValue(string value)
        {
            //TODO
            return base.IsValidValue(value);
        }
    }
}

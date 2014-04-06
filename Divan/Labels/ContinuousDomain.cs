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
            try
            {
                double val1 = Convert.ToDouble(value1);
                double val2 = Convert.ToDouble(value2);
                return Math.Sign(val1 - val2);
            }
            catch
            {
                return 0;
            }
        }

        public override bool isDiscrete()
        {
            return false;
        }

        public override bool IsValidValue(string value)
        {
            try
            {
                double val = Convert.ToDouble(value);
                return (val >= minValue && val <= maxValue);
            }
            catch
            {
                return false;
            }
        }
    }
}

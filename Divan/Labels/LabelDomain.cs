using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Divan
{
    public partial class LabelDomain
    {
        public LabelDomain(float? minValue, float? maxValue, bool? isOrdered)
            : this()
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
            this.isOrdered = isOrdered;
        }
        public virtual bool IsValidValue(string value)
        {
            //TODO
            return false;
        }

        public virtual bool isDiscrete(){
            return this.isOrdered!=null;
        }

        public virtual int compare(string value1, string value2)
        {
            //TODO
            return 0;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Divan
{
    public partial class LabelDomain
    {
        public static bool isCompatible(string type, string value)
        {
            if (type == "رشته")
                return true;
            else if (type == "عدد")
                return UIHelper.Validation.isInteger(value);
            else if (type == "بلی/خیر")
                return value == "بلی" || value == "خیر";
            else
                return value == type;
        }

        public LabelDomain(float? minValue, float? maxValue, bool? isOrdered)
            : this()
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
            this.isOrdered = isOrdered;
        }
        public virtual bool IsValidValue(string value)
        {
            if (value == null)
                return false;
            if (this.isDiscrete())
            {
                foreach (DiscreteDomainValue val in this.DiscreteDomainValues)
                    if (value == val.value)
                        return true;
            }
            else
            {
                try
                {
                    const double EPSILON = 1e-8;
                    double r = Convert.ToDouble(value);
                    if (r >= this.minValue-EPSILON && r <= this.maxValue+EPSILON)
                        return true;
                }
                catch
                {
                    return false;
                }
            }
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

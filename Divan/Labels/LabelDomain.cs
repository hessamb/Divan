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
            if (type == Property.STRING_FORMAT_TYPE)
                return true;
            else if (type == Property.DOUBLE_FORMAT_TYPE)
                return UIHelper.Validation.isDouble(value);
            else if (type == Property.BOOLEAN_FORMAT_TYPE)
                return value == "بلی" || value == "خیر";
            else
                return value == type;
        }

        public LabelDomain(float? minValue, float? maxValue,int? distinctMin, int? distinctMax, bool? isOrdered)
            : this()
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
            this.descriteMin = distinctMin;
            this.descriteMax = distinctMax;
            this.isOrdered = isOrdered;
        }
        public virtual bool IsValidValue(string value)
        {
            if (value == null)
                return false;
            else if (this.isDiscrete())
            {
                if (this.isNumeric())
                {
                    try
                    {
                        int val = int.Parse(value);
                        return this.descriteMin <= val && this.descriteMax >= val;
                    }
                    catch
                    {
                        return false;
                    }
                }
                else
                {
                    string[] vals = value.Split(new string[] { " - " }, StringSplitOptions.None);
                    foreach (string word in vals)
                    {
                        bool valid = false;
                        foreach (DiscreteDomainValue val in this.DiscreteDomainValues)
                            if (word == val.value)
                            {
                                valid = true;
                                break;
                            }
                        if (!valid)
                            return false;
                    }
                    return true;
                }
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
                }
                return false;
            }
        }

        public virtual bool isDiscrete(){
            return this.minValue==null;
        }

        public virtual bool isNumeric()
        {
            return this.minValue != null || this.descriteMin != null;
        }

        public virtual int compare(string value1, string value2)
        {
            //TODO
            return 0;
        }
    }
}

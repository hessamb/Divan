using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Divan
{
    public class PropertyConsistencyExpression: ConsistencyExpression
    {
        private Property property;

        public PropertyConsistencyExpression(Property property)
        {
            this.property = property;
        }

        public override bool equals(ConsistencyExpression ce)
        {
            if (ce is PropertyConsistencyExpression)
            {
                PropertyConsistencyExpression pce = (ce as PropertyConsistencyExpression);
                return pce.property.Value == this.property.Value
                    && pce.property.Type == this.property.Type;
            }
            else
                return ce.equals(this);
        }

        public override bool greaterThan(ConsistencyExpression ce)
        {
            if (!(this.getValue() is double))
                return false;
            double val = ((double)this.getValue());
            if (ce is DoubleConsistencyExpression)
            {
                return val > (ce as DoubleConsistencyExpression).getValue();
            }
            else if (ce is PropertyConsistencyExpression)
            {
                PropertyConsistencyExpression pce = (ce as PropertyConsistencyExpression);
                if (pce.getValue() is double)
                    return val > (pce.getValue() as double?);
                else
                    return false;
            }
            else
            {
                return base.greaterThan(ce);
            }
        }

        public object getValue()
        {
            if (property.type == Property.DOUBLE_FORMAT_TYPE)
                return Convert.ToDouble(property.Value);
            else if (property.type == Property.BOOLEAN_FORMAT_TYPE)
                return property.Value == "بلی";
            else
                return property.Value;
        }

        public new static ConsistencyExpression parseTokens(string[] tokens, ref int k)
        {
            if (tokens[k] != "$")
                return null;
            int f = k;
            k++;
            string uid = getUntil(tokens, ref k, "$");
            if (uid == null)
            {
                k = f;
                return null;
            }
            string propertyName = getUntil(tokens, ref k, "$");
            if (propertyName == null)
            {
                k = f;
                return null;
            }

            Asset asset = AssetList.Instance.GetByUid(uid);
            if (asset == null)
            {
                k = f;
                return null;
            }
            Property property = asset.getProperty(propertyName);
            if (property == null)
            {
                k = f;
                return null;
            }
            return new PropertyConsistencyExpression(property);
        }

        private static string getUntil(string[] tokens, ref int k, string str)
        {
            string res = "";
            for (; k < tokens.Length; k++)
            {
                if (tokens[k] == str)
                    break;
                res += " ";
                res += Regex.Unescape(tokens[k]);
            }
            if (k == tokens.Length || res == "")
            {
                return null;
            }
            res = res.Substring(1);
            k++;
            return res;
        }
    }
}

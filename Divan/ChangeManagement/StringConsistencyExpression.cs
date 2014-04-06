using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Divan
{
    public class StringConsistencyExpression: ConsistencyExpression
    {
        private String value;

        public StringConsistencyExpression(string value)
        {
            this.value = value;
        }

        public override bool equals(ConsistencyExpression ce)
        {
            if (ce is StringConsistencyExpression)
            {
                StringConsistencyExpression sce = (ce as StringConsistencyExpression);
                return sce.getValue() == this.getValue();
            }
            else if (ce is LabelInstanceConsistencyExpression)
            {
                LabelInstanceConsistencyExpression lice = (ce as LabelInstanceConsistencyExpression);
                return lice.getValue() == this.getValue();
            }
            else if (ce is PropertyConsistencyExpression)
            {
                PropertyConsistencyExpression pce = (ce as PropertyConsistencyExpression);
                if (pce.getValue() is String)
                    return (pce.getValue() as String) == this.getValue();
                else
                    return false;
            }
            else
            {
                return base.equals(ce);
            }
        }
        public String getValue()
        {
            return value;
        }

        public new static ConsistencyExpression parseTokens(string[] tokens, ref int k)
        {
            if (!tokens[k].StartsWith("\""))
                return null;
            int f = k;
            for (; k < tokens.Length; k++)
                if (tokens[k].EndsWith("\""))
                    break;
            if (k == tokens.Length)
            {
                k = f;
                return null;
            }

            
            String value = "";
            for (int i = f; i <= k; i++)
            {
                value += Regex.Unescape(tokens[i]);
                if (i!=k)
                    value += " ";
            }
            k++;
            return new StringConsistencyExpression(value);
        }
    }
}

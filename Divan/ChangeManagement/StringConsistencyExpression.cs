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
                return sce.getValue().Equals(this.getValue());
            }
            else if (ce is LabelInstanceConsistencyExpression)
            {
                LabelInstanceConsistencyExpression lice = (ce as LabelInstanceConsistencyExpression);
                return lice.getValue().Equals(this.getValue());
            }
            else if (ce is PropertyConsistencyExpression)
            {
                PropertyConsistencyExpression pce = (ce as PropertyConsistencyExpression);
                return this.getValue().Equals(pce.getValue());
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
                String now = Regex.Unescape(tokens[i]);
                if (i == f)
                    now = now.Substring(1);
                if (i == k)
                    now = now.Substring(0, now.Length - 1);
                value += now;
                if (i!=k)
                    value += " ";
            }
            k++;
            return new StringConsistencyExpression(value);
        }
    }
}

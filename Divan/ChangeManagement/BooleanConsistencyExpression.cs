using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divan
{
    public class BooleanConsistencyExpression: ConsistencyExpression
    {
        private bool value;

        public BooleanConsistencyExpression(bool value)
        {
            this.value = value;
        }

        public bool getValue()
        {
            return value;
        }

        public override bool equals(ConsistencyExpression ce)
        {
            if (ce is BooleanConsistencyExpression)
            {
                return value == (ce as BooleanConsistencyExpression).value;
            }
            else if (ce is PropertyConsistencyExpression)
            {
                PropertyConsistencyExpression pce = (ce as PropertyConsistencyExpression);
                return pce.getValue().Equals(value);
            }
            else
            {
                return base.equals(ce);
            }
        }

        public new static ConsistencyExpression parseTokens(string[] tokens, ref int k)
        {
            try
            {
                ConsistencyExpression result = new BooleanConsistencyExpression(Convert.ToBoolean(tokens[k]));
                k++;
                return result;
            }
            catch
            {
                return null;
            }
        }
    }
}

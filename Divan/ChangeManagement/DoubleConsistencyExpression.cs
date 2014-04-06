using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divan
{
    class DoubleConsistencyExpression: ConsistencyExpression
    {
        private double value;

        public override bool equals(ConsistencyExpression ce)
        {
            if (ce is DoubleConsistencyExpression)
            {
                return (ce as DoubleConsistencyExpression).value == this.value;
            }
            else if (ce is PropertyConsistencyExpression)
            {
                PropertyConsistencyExpression pce = (ce as PropertyConsistencyExpression);
                if (pce.getValue() is double)
                {
                    return (pce.getValue() as double?) == this.value;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return base.equals(ce);
            }
        }
        public DoubleConsistencyExpression(double value)
        {
            this.value = value;
        }

        public new static ConsistencyExpression parseTokens(string[] tokens, ref int k)
        {
            try
            {
                ConsistencyExpression result = new DoubleConsistencyExpression(Convert.ToDouble(tokens[k]));
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

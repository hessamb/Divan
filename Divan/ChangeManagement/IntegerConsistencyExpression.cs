using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divan
{
    public class IntegerConsistencyExpression: ConsistencyExpression
    {
        private int value;

        public IntegerConsistencyExpression(int value)
        {
            this.value = value;
        }

        public new static ConsistencyExpression parseTokens(string[] tokens, ref int k)
        {
            try
            {
                ConsistencyExpression result = new IntegerConsistencyExpression(Convert.ToInt32(tokens[k]));
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

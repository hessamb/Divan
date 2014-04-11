using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divan
{
    public abstract class ConsistencyExpression
    {
        public virtual bool equals(ConsistencyExpression ce){
            throw new Exception("Operand makes no scence.");
        }

        public virtual bool greaterThan(ConsistencyExpression ce)
        {
            throw new Exception("Operand makes no scence.");
        }

        public bool greaterEqual(ConsistencyExpression ce)
        {
            return greaterThan(ce) || equals(ce);
        }

        public virtual bool hasIN(ConsistencyExpression ce)
        {
            throw new Exception("Operand makes no scence.");
        }

        public static ConsistencyExpression parse(String expr)
        {
            string[] tokens = expr.Split(' ');
            int start = 0;
            return parseTokens(tokens, ref start);
        }

        public static ConsistencyExpression parseTokens(string[] tokens, ref int k)
        {
            ConsistencyExpression result;
            result = DoubleConsistencyExpression.parseTokens(tokens, ref k);
            if (result != null)
                return result;
            result = BooleanConsistencyExpression.parseTokens(tokens, ref k);
            if (result != null)
                return result;
            result = StringConsistencyExpression.parseTokens(tokens, ref k);
            if (result != null)
                return result;
            result = SetConsistencyExpression.parseTokens(tokens, ref k);
            if (result != null)
                return result;

            result = PropertyConsistencyExpression.parseTokens(tokens, ref k);
            if (result != null)
                return result;
            result = LabelInstanceConsistencyExpression.parseTokens(tokens, ref k);
            if (result != null)
                return result;
            return null;
        }

    }
}

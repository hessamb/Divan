using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divan
{
    public class SetConsistencyExpression: ConsistencyExpression
    {
        private List<ConsistencyExpression> members;

        public SetConsistencyExpression(List<ConsistencyExpression> members)
        {
            this.members = members;
        }

        public override bool equals(ConsistencyExpression ce)
        {
            if (ce is SetConsistencyExpression)
            {
                SetConsistencyExpression sce = (ce as SetConsistencyExpression);
                if (members.Count != sce.members.Count)
                    return false;
                for (int i=0 ; i<members.Count ; i++){
                    bool found = false;
                    for (int j = i; j < sce.members.Count; j++)
                    {
                        if (members[i].equals(sce.members[j]))
                        {
                            ConsistencyExpression tmp = sce.members[i];
                            sce.members[i] = sce.members[j];
                            sce.members[j] = tmp;
                            found = true;
                            break;
                        }

                    }
                    if (!found)
                        return false;
                }
                return true;
            }
            else
            {
                return base.equals(ce);
            }
        }

        public new static ConsistencyExpression parseTokens(string[] tokens, ref int k)
        {
            if (tokens[k] != "{")
                return null;
            int f = k;

            List<ConsistencyExpression> members = new List<ConsistencyExpression>();
            k++;
            while (k < tokens.Length)
            {
                if (tokens[k] == "}")
                {
                    k++;
                    return new SetConsistencyExpression(members);
                }
                ConsistencyExpression now = ConsistencyExpression.parseTokens(tokens, ref k);
                if (now == null)
                {
                    k = f;
                    return null;
                }
                members.Add(now);
            }
            k = f;
            return null; 
        }
    }
}

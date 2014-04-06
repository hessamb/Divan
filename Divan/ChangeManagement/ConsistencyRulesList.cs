using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divan
{
    public class ConsistencyRulesList
    {
        private static ConsistencyRulesList instance;

        public static ConsistencyRulesList Instance
        {
            get
            {
                if (instance == null)
                    instance = new ConsistencyRulesList();
                return instance;
            }
        }

        public IEnumerable<ConsistencyRule> GetAll()
        {
            var rules = from r in DivanDataContext.Instance.ConsistencyRules
                        select r;
            return rules.AsEnumerable();
        }
    }
}

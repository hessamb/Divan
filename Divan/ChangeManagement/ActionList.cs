using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Divan
{
    public class ActionList
    {
        private static ActionList instance;

        public static ActionList Instance
        {
            get
            {
                if (instance == null)
                    instance = new ActionList();
                return instance;
            }
        }

        public IEnumerable<Action> GetAll()
        {
            var actions = from a in DivanDataContext.Instance.Actions
                          select a;
            return actions.AsEnumerable();
        }

        public IEnumerable<Action> GetAutoRunables()
        {
            var actions = from a in DivanDataContext.Instance.Actions
                          where a.needsAutoRun==true
                          select a;
            return actions.AsEnumerable();
        }

        public IEnumerable<Action> GetResult(string query)
        {
            var actions = from a in DivanDataContext.Instance.Actions
                          where a.name.Contains(query)
                          select a;
            return actions.AsEnumerable();
        }
    }
}

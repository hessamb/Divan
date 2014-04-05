using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divan
{
    public class ActionList
    {
        private static AssetList instance;

        public static AssetList Instance
        {
            get
            {
                if (instance == null)
                    instance = new AssetList();
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

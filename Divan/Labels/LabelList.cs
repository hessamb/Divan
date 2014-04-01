using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divan
{
    public partial class LabelList
    {
        private static LabelList instance;

        public static LabelList Instance
        {
            get
            {
                if (instance == null)
                    instance = new LabelList();
                return instance;
            }
        }

        public IEnumerable<Label> GetAll()
        {
            var labels = from l in DivanDataContext.Instance.Labels
                         select l;
            return labels.AsEnumerable();
        }

        public List<Label> GetResult(string query)
        {
            //TODO
            return null;
        }
    }
}

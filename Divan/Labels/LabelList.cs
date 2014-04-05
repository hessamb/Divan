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

        public Label labelByName(string name)
        {
            var labels = from l in DivanDataContext.Instance.Labels
                         where l.name == name
                         select l;
            try
            {
                return labels.First();
            }
            catch
            {
                return null;
            }
        }

        public IEnumerable<Label> GetAll()
        {
            var labels = from l in DivanDataContext.Instance.Labels
                         select l;
            return labels.AsEnumerable();
        }
        public IEnumerable<Label> GetAllVisibles()
        {
            var labels = from l in DivanDataContext.Instance.Labels
                         where l.visible==true
                         select l;
            return labels.AsEnumerable();
        }

        public Label getLabelById(int id)
        {
            var labels = from l in DivanDataContext.Instance.Labels
                         where l.Id == id
                         select l;
            try
            {
                return labels.First();
            }
            catch
            {
                throw new Exception("Label Not Found!");
            }
        }

        public List<Label> GetResult(string query)
        {
            //TODO
            return null;
        }
    }
}

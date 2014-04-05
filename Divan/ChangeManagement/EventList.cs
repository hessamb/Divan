using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divan
{
    public class EventList
    {
        private static EventList instance;

        public static EventList Instance
        {
            get
            {
                if (instance == null)
                    instance = new EventList();
                return instance;
            }
        }

        public IEnumerable<Event> GetAll()
        {
            var res = from a in DivanDataContext.Instance.Events
                          select a;
            return res.AsEnumerable();
        }

        public IEnumerable<Event> GetResult(string query)
        {
            var res = from a in DivanDataContext.Instance.Events
                          where a.Name.Contains(query)
                          select a;
            return res.AsEnumerable();
        }
    }
}

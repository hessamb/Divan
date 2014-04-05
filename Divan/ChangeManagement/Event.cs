using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Divan
{
    public partial class Event
    {
        public string ActionName
        {
            get
            {
                return Action.name;
            }
        }

        public void Create()
        {
            //TODO
        }

        public void RunAction()
        {
            this.Action.Run();
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}

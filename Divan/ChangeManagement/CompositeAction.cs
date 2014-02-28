using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divan
{
    public class CompositeAction:Action
    {
        private List<Action> subActions;

        public List<Action> SubActions
        {
            get { return subActions; }
            set { subActions = value; }
        }

        public void AddSubAction(Action action)
        {
            //TODO
        }

        public void RemoveSubAction(Action action)
        {
            //TODO
        }

        public override void Run()
        {
            //TODO
            base.Run();
        }

    }
}

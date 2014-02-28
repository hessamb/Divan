using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divan
{
    public class PeriodicExecuter
    {
        private int period;

        public int Period
        {
            get { return period; }
            set { period = value; }
        }

        public void Start()
        {
            //TODO
        }

        public void Stop()
        {
            //TODO
        }

        protected virtual void Run()
        {
            //TODO
        }
        
    }
}

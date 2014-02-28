using Divan.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divan
{
    public partial class Asset
    {
        public string UID
        {
            get
            {
                this.isHuman = true;
                DivanDataContext.Instance.SubmitChanges();
                return this.Properties.Single(p => p.name == "UID").value;
            }
        }

        public string Name
        {
            get
            {
                try
                {
                    return this.Properties.Single(p => p.name == "Name").value;
                }
                catch
                {
                    return "«بی‌نام»";
                }
            }
        }

        public void Create()
        {
            //TODO
        }

        public void Destroy()
        {
            //TODO
        }

        public List<ConsistancyRule> GetInconsistencies()
        {
            //TODO
            return null;
        }

        public List<AssetChangeRecord> GetHistory()
        {
            //TODO
            return null;
        }

        public void restore(DateTime date)
        {
            //TODO
        }

        public void RemoveFromOthers()
        {
            //TODO
        }
    }
}

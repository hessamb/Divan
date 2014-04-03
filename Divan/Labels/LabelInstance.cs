using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Divan
{
    public partial class LabelInstance:Changable
    {

        public LabelInstance(int assetId, int labelId, string value)
        {
            this.assetID = assetId;
            this.labelID = labelId;
            this.value = value;
        }

        public List<ConsistancyRule> GetInconsistencies()
        {
            //TODO
            return null;
        }

        public void RemoveFromOthers()
        {
            //TODO
        }

        public void ChangeValue()
        {
            //TODO
        }

        protected virtual void PropagateChange()
        {
            //TODO
        }

        public void Create()
        {
            //TODO
        }

        public void Destroy()
        {
            //TODO
        }

    }
}

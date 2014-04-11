using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Divan
{
    public partial class LabelInstance:Changable
    {

        public const string VALUE_SPLITTER = " - ";

        public LabelInstance(int assetId, int labelId, string value)
        {
            this.assetID = assetId;
            this.labelID = labelId;
            this.value = value;
        }

        public List<ConsistencyRule> GetInconsistencies()
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


        public object getValue()
        {
            LabelDomain domain = this.Label.LabelDomain;
            if (domain.isDiscrete() && !domain.isNumeric())
            {
                if (this.value.Contains(VALUE_SPLITTER))
                    return this.value.Split(new string[] { VALUE_SPLITTER }, StringSplitOptions.None).Cast<object>().ToArray();
                else
                    return this.value;
            }
            else
            {
                if (this.value.Contains(VALUE_SPLITTER))
                {
                    string[] vals = this.value.Split(new string[] { VALUE_SPLITTER }, StringSplitOptions.None);
                    object[] dvals = new object[vals.Length];
                    for (int i = 0; i < vals.Length; i++)
                    {
                        dvals[i] = Convert.ToDouble(vals[i]);
                    }
                    return dvals;
                }
                else
                {
                    return Convert.ToDouble(this.value);
                }
            }
        }
    }
}

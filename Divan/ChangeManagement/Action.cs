using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divan
{
    public partial class Action
    {
        public string AssetName
        {
            get
            {
                if (this.Asset == null)
                    return "";
                return this.Asset.Name;
            }
        }
        public string LabelName
        {
            get
            {
                if (this.Label == null)
                    return "";
                return this.Label.name;
            }
        }
        public bool Composite
        {
            get
            {
                var subActions = from sa in DivanDataContext.Instance.SubActions
                                 where sa.parentId == this.Id
                                 select sa;
                return subActions.Any();
            }
        }

        public IEnumerable<Action> SubActions
        {
            get
            {
                var subActions = from sa in DivanDataContext.Instance.SubActions
                                 where sa.parentId == this.Id
                                 select sa.Child;
                return subActions.AsEnumerable();
            }
        }

        public virtual void Run()
        {
            LabelInstance labelInstance = Asset.getLabelInstance(Label);
            labelInstance.value = value;
            if (Composite)
            {
                foreach (Action action in SubActions)
                {
                    action.Run();
                }
            }
        }

        public void Destroy()
        {
            //TODO
        }

        public override String ToString()
        {
            return this.name;
        }
    }
}

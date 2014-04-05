using Divan.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
using System.Windows.Forms;

namespace Divan
{
    public partial class Asset
    {
        public const String UID_STRING = "UID";
        public const String NAME_STRING = "Name";
        public const String FIRST_NAME_STRING = "FirstName",
            LAST_NAME_STRING = "LastName", NATIONAL_ID_STRING = "NationalId",
            PERSONNEL_CODE_STRING = "PersonnelCode", HUMAN_DESCRIPTION_STRING = "HumanDescription";
        public const String PHYSICAL_DESCRIPTION_STRING = "PhysicalDescription";

        public readonly static String[] SPECIAL_NAMES = new String[]{UID_STRING, NAME_STRING,
            FIRST_NAME_STRING, LAST_NAME_STRING, NATIONAL_ID_STRING,
            PERSONNEL_CODE_STRING, HUMAN_DESCRIPTION_STRING,
            PHYSICAL_DESCRIPTION_STRING};

        public const String UNNAMED_ASSET = "بی‌نام";

        private AssetState state;

        partial void OnLoaded()
        {
            this.IsComposite = this.SubAssets.Count > 0;
        }

        //public Asset(bool composite)
        //{
        //    if (composite)
        //        this.state = new CompositeAssetState(this);
        //    else
        //        this.state = new BaseAssetState(this);
        //}

        public string UID
        {
            get
            {
                return this.Properties.Single(p => p.Name == UID_STRING).Value;
            }
        }

        public string Name
        {
            get
            {
                try
                {
                    return this.Properties.Single(p => p.Name == NAME_STRING).Value;
                }
                catch
                {
                    return UNNAMED_ASSET;
                }
            }
        }

        public string FirstName
        {
            get
            {
                try
                {
                    return this.Properties.Single(p => p.Name == FIRST_NAME_STRING).Value;
                }
                catch
                {
                    return "";
                }
            }
        }

        public string LastName
        {
            get
            {
                try
                {
                    return this.Properties.Single(p => p.Name == LAST_NAME_STRING).Value;
                }
                catch
                {
                    return "";
                }
            }
        }

        public string NationalID
        {
            get
            {
                try
                {
                    return this.Properties.Single(p => p.Name == NATIONAL_ID_STRING).Value;
                }
                catch
                {
                    return "";
                }
            }
        }

        public string PersonnelCode
        {
            get
            {
                try
                {
                    return this.Properties.Single(p => p.Name == PERSONNEL_CODE_STRING).Value;
                }
                catch
                {
                    return "";
                }
            }
        }

        public string HumanDescription
        {
            get
            {
                try
                {
                    return this.Properties.Single(p => p.Name == HUMAN_DESCRIPTION_STRING).Value;
                }
                catch
                {
                    return "";
                }
            }
        }

        public string PhysicalDescription
        {
            get
            {
                try
                {
                    return this.Properties.Single(p => p.Name == PHYSICAL_DESCRIPTION_STRING).Value;
                }
                catch
                {
                    return "";
                }
            }
        }

        public Boolean IsComposite{
            get{
                return this.state.IsComposite();
            }
            set{
                if (this.state!=null && value == this.state.IsComposite())
                    return;
                if(value)
                    this.state=new CompositeAssetState(this);
                else
                    this.state = new BaseAssetState(this);
            }
        }

        public IEnumerable<Asset> GetSubAssets()
        {
            return state.GetSubAssets();
        }

        partial void OnCreated()
        {
            this.visible = true;
        }

        public void Destroy()
        {
            this.RemoveFromOthers();
            DivanDataContext.Instance.Assets.DeleteOnSubmit(this);
            DivanDataContext.Instance.SubmitChanges();
        }

        public List<ConsistancyRule> GetInconsistencies()
        {
            //TODO
            return null;
        }

        public void RemoveFromOthers()
        {
            this.Parent.RemoveSubAsset(this);
            foreach (Asset subAsset in this.GetSubAssets())
                subAsset.Parent = null;
            DivanDataContext.Instance.SubmitChanges();
        }

        public TreeNode getTreeNode()
        {
            TreeNode result = new TreeNode(Name + " (" + UID + ")");
            result.Tag = this;
            foreach(Asset asset in GetSubAssets())
            {
                result.Nodes.Add(asset.getTreeNode());
            }
            return result;
        }

        public void AddSubAsset(Asset asset)
        {
            this.state.AddSubAsset(asset);
        }

        public void RemoveSubAsset(Asset asset)
        {
            this.state.RemoveSubAsset(asset);
        }

        public IEnumerable<Property> OtherProperties
        {
            get
            {
                return this.Properties.Where(property => !SPECIAL_NAMES.Contains(property.Name));
            }
        }

        public IEnumerable<Label> getLabels()
        {
            var labels = from l in this.LabelInstances
                         select l.Label;
            return labels;
        }

        public IEnumerable<Label> getValuableLabels()
        {
            var labels = from l in this.LabelInstances
                         where l.Label.setValue==true
                         select l.Label;
            if(labels.Count()>0)
                return labels;
            return new Label[0];
        }

        public LabelInstance getLabelInstance(Label label)
        {
            var labelInstances = from l in DivanDataContext.Instance.LabelInstances
                                 where l.Label == label && l.Asset == this
                                 select l;
            try
            {
                return labelInstances.First();
            }
            catch
            {
                throw new Exception("LabelInstance Not Found!");
            }
        }

        public bool pathExists(Asset asset)
        {
            if (this.Id == asset.Id)
                return true;
            foreach(Asset subAsset in GetSubAssets())
                if (subAsset.pathExists(asset))
                    return true;
            return false;
        }
        
    }
}
using Divan.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public string UID
        {
            get
            {
                return this.Properties.Single(p => p.name == UID_STRING).value;
            }
        }

        public string Name
        {
            get
            {
                try
                {
                    return this.Properties.Single(p => p.name == NAME_STRING).value;
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
                    return this.Properties.Single(p => p.name == FIRST_NAME_STRING).value;
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
                    return this.Properties.Single(p => p.name == LAST_NAME_STRING).value;
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
                    return this.Properties.Single(p => p.name == NATIONAL_ID_STRING).value;
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
                    return this.Properties.Single(p => p.name == PERSONNEL_CODE_STRING).value;
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
                    return this.Properties.Single(p => p.name == HUMAN_DESCRIPTION_STRING).value;
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
                    return this.Properties.Single(p => p.name == PHYSICAL_DESCRIPTION_STRING).value;
                }
                catch
                {
                    return "";
                }
            }
        }

        public Boolean isComposite()
        {
            return true;
        }

        public Asset[] getSubAssets()
        {
            //TODO
            return new Asset[0];
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
        public TreeNode getTreeNode()
        {
            TreeNode result = new TreeNode(Name + " (" + UID + ")");
            Asset[] subAssets = getSubAssets();
            foreach(Asset asset in subAssets)
            {
                result.Nodes.Add(asset.getTreeNode());
            }
            return result;
        }
    }
}
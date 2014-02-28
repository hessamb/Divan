using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divan.Users
{
    class AssetSupporter:User
    {
        private List<Asset> assets;

        public List<Asset> Assets
        {
            get { return assets; }
            set { assets = value; }
        }
        

        public override string[] GetPermissions()
        {
            return new string[]{
                "seeAssets",
                "seeLabels",
            };
        }
    }
}

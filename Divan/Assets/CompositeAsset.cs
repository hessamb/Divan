using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divan
{
    public class CompositeAsset
    {
        private List<Asset> subAssets;

        public List<Asset> SubAssets
        {
            get { return subAssets; }
            set { subAssets = value; }
        }

        public void AddSubAsset(Asset asset)
        {
            //TODO
        }

        public void RemoveSubAsset(Asset asset)
        {
            //TODO
        }
        
    }
}

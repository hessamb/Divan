using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divan
{
    public class AssetList
    {
        private static AssetList instance;

        public static AssetList Instance
        {
            get
            {
                if (instance == null)
                    instance = new AssetList();
                return instance;
            }
        }

        public IEnumerable<Asset> GetAll(){
            var assets = from a in DivanDataContext.Instance.Assets
                         select a;
            
            return assets.AsEnumerable();
        }

        public List<Asset> GetPortables()
        {
            //TODO
            return null;
        }

        public List<Asset> GetResult(AssetQuery qury)
        {
            //TODO
            return null;
        }
    }
}

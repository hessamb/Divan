using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divan
{
    public class BaseAssetState: AssetState
    {
        public BaseAssetState(Asset asset): base(asset){}

        public override bool IsComposite()
        {
            return false;
        }

        public override IEnumerable<Asset> GetSubAssets()
        {
            return new Asset[0];
        }

        public override void AddSubAsset(Asset subAsset)
        {
            throw new NotImplementedException();
        }

        public override void RemoveSubAsset(Asset subAsset)
        {
            throw new NotImplementedException();
        }
    }
}

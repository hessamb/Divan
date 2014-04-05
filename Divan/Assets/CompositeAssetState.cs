using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Divan
{
    public class CompositeAssetState: AssetState
    {
        public CompositeAssetState(Asset asset): base(asset){}

        public override bool IsComposite()
        {
            return true;
        }

        public override IEnumerable<Asset> GetSubAssets()
        {
            //var assets = from a in DivanDataContext.Instance.Assets
            //             where a.Parent==this.asset
            //             select a;
            //return assets.AsEnumerable();
            return asset.SubAssets;
        }

        public override void AddSubAsset(Asset subAsset)
        {
            subAsset.Parent = this.asset;
            DivanDataContext.Instance.SubmitChanges();
        }

        public override void RemoveSubAsset(Asset subAsset)
        {
            if (subAsset.Parent != asset)
                return;
            subAsset.Parent = null;
            DivanDataContext.Instance.SubmitChanges();
        }
    }
}

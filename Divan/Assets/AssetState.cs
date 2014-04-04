using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divan
{
    public abstract class AssetState
    {
        protected Asset asset;

        public AssetState(Asset asset)
        {
            this.asset = asset;
        }

        public abstract bool IsComposite();

        public abstract IEnumerable<Asset> GetSubAssets();

        public abstract void AddSubAsset(Asset subAsset);

        public abstract void RemoveSubAsset(Asset subAsset);

    }
}

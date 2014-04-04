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

        public IEnumerable<Asset> GetAll()
        {
            var assets = from a in DivanDataContext.Instance.Assets
                         select a;

            return assets.AsEnumerable();
        }

        public IEnumerable<Asset> GetAllVisibles()
        {
            var assets = from a in DivanDataContext.Instance.Assets
                         where a.visible==true
                         select a;

            return assets.AsEnumerable();
        }

        public Asset GetById(int id)
        {
            var assets = from a in DivanDataContext.Instance.Assets
                         where a.Id == id
                         select a;

            return getFirst(assets);
        }

        public Asset GetByUid(String uid)
        {
            var assets = from a in DivanDataContext.Instance.Assets
                         join
                             p in DivanDataContext.Instance.Properties
                             on a.Id equals p.assetID
                         where p.name == Asset.UID_STRING && p.value == uid
                         select a;
            int k = assets.Count();
            return getFirst(assets);
        }

        private Asset getFirst(IQueryable<Asset> assets)
        {
            try
            {
                return assets.First();
            }
            catch
            {
                throw new Exception("Asset Not Found!");
            }
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

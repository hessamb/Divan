using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divan
{
    public class AssetList: IEnumerable
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
            try
            {
                return getFirst(assets);
            }
            catch
            {
                return null;
            }
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

        public IEnumerator GetEnumerator()
        {
            return this.GetAllVisibles().GetEnumerator();
        }

        public IEnumerable<Asset> GetPortables()
        {
            var assets = from a in DivanDataContext.Instance.Assets
                         where a.isPortable == true
                         select a;
            return assets.AsEnumerable();
        }

        public IEnumerable<Asset> GetResult(AssetQuery query)
        {
            var assets = from a in DivanDataContext.Instance.Assets
                         where (a.Name.Contains(query.Expression)
                         || a.UID.Contains(query.Expression))
                         && a.Name.Contains(query.NameConstraint)
                         && a.UID.Contains(query.UidConstraint)
                         select a;
            return assets.AsEnumerable();
        }
    }
}
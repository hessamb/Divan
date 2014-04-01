using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Divan
{
    public partial class Property:Changable
    {
        public Property(string name, string value, Asset asset, string type = "رشته")
        {
            this.name = name;
            this.value = value;
            this.Asset = asset;
            this.type = type;
        }
    }
}

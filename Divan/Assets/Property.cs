using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Divan
{
    public partial class Property:Changable
    {
        public string Value
        {
            get
            {
                return this.value.TrimEnd();
            }
            set
            {
                this.value = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name.TrimEnd();
            }
            set
            {
                this.name = value;
            }
        }

        public string Type
        {
            get
            {
                return this.type.TrimEnd();
            }
            set
            {
                this.type = value;
            }
        }

        public Property(string name, string value, Asset asset, string type = "رشته")
        {
            this.name = name;
            this.value = value;
            this.Asset = asset;
            this.type = type;
        }
    }
}

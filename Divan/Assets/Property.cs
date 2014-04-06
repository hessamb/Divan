using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Divan
{
    public partial class Property:Changable
    {
        public const string DOUBLE_FORMAT_TYPE = "عدد";
        public const string STRING_FORMAT_TYPE = "رشته";
        public const string BOOLEAN_FORMAT_TYPE = "بلی/خیر";
        public string Value
        {
            get
            {
                return this.value;
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
                return this.name;
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
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        public Property(string name, string value, Asset asset, string type = STRING_FORMAT_TYPE)
        {
            this.name = name;
            this.value = value;
            this.Asset = asset;
            this.type = type;
        }
    }
}

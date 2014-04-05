using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Divan
{
    public partial class Label:Changable
    {
        public const string UNASSANABLE_VALUE = "مقدارناپذیر";

        public string domainModel
        {
            get
            {
                if (this.LabelDomain == null)
                    return "ندارد";
                else if (this.LabelDomain.isDiscrete())
                    return "گسسته";
                else
                    return "پیوسته";
            }
        }
        public Label(string name, bool setValue, bool isSplitter, LabelDomain domain): this()
        {
            this.name = name;
            this.setValue = setValue;
            this.isSplitter = isSplitter;
            this.LabelDomain = domain;
        }
        public void Create()
        {
            //TODO
        }

        public void Destroy()
        {
            //TODO
        }

    }
}

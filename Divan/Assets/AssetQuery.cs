﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Divan
{
    public class AssetQuery
    {
        private string expression;
        private string domain;

        public string Domain
        {
            get { return domain; }
            set { domain = value; }
        }

        public string Expression
        {
            get { return expression; }
            set { expression = value; }
        }

        public string NameConstraint
        {
            get
            {
                return (Domain == "name") ? Expression : "";
            }
        }

        public string UidConstraint
        {
            get
            {
                return (Domain == "uid") ? Expression : "";
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

namespace Divan.Users
{
    class Employee:User
    {
        public override string[] GetPermissions()
        {
            return new string[]{
                "seeAssets",
                "modifyAssets",
                "seeLabels",
                "modifyLabels",
            };
        }
    }
}

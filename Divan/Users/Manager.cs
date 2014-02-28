﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divan.Users
{
    class Manager : User
    {
        public override string[] GetPermissions()
        {
            return new string[]{
                "seeAssets",
                "modifyAssets",
                "seeLabels",
                "modifyLabels",
                "getReport",
                "returnToBaseline",
                "settings",
            };
        }
    }
}

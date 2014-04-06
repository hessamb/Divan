using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divan
{
    public partial class ConsistencyRule
    {
        public const int IMPORTANCE_SAFE = 0;
        public const int IMPORTANCE_CRITICAL = 1;
        public const int IMPORTANCE_SAFE_CRITICAL = 2;
        public const int IMPORTANCE_CARE = 3;
        public const int IMPORTANCE_REGULAR = 4;

        public bool Inconsistent
        {
            get
            {
                ConsistencyExpression mExp = ConsistencyExpression.parse(this.mValue);
                ConsistencyExpression sExp = ConsistencyExpression.parse(this.sValue);
                return !mExp.equals(sExp);
            }
        }

        public string AssetName
        {
            get
            {
                return this.Asset.Name;
            }
        }

        public string Importance
        {
            get
            {
                switch (importance)
                {
                    case IMPORTANCE_SAFE: return "ایمن";
                    case IMPORTANCE_CRITICAL: return "بحرانی";
                    case IMPORTANCE_SAFE_CRITICAL: return "بحرانی-ایمن";
                    case IMPORTANCE_CARE: return "مهم";
                    case IMPORTANCE_REGULAR: return "عادی";
                    default: return "";
                }
            }
        }
        public static int getImportance(string importanceText)
        {
            if (importanceText == "امن")
                return IMPORTANCE_SAFE;
            else if (importanceText == "بحرانی-امن")
                return IMPORTANCE_SAFE_CRITICAL;
            else if (importanceText == "بحرانی")
                return IMPORTANCE_CRITICAL;
            else if (importanceText == "مهم")
                return IMPORTANCE_CARE;
            else if (importanceText == "عادی")
                return IMPORTANCE_REGULAR;
            else
                return -1;
        }

        public bool Satisfied
        {
            get
            {

                return true;
            }
        }
    }
}

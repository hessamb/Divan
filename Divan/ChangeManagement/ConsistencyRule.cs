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
                if (condition == "==")
                    return !mExp.equals(sExp);
                if (condition == "!=")
                    return mExp.equals(sExp);
                if (condition == "<")
                    return !sExp.greaterThan(mExp);
                if (condition == ">")
                    return !mExp.greaterThan(sExp);
                if (condition == "<=")
                    return !sExp.greaterEqual(mExp);
                if (condition == ">=")
                    return !mExp.greaterEqual(sExp);
                if (condition == "IN")
                    return !sExp.hasIN(mExp);
                if (condition == "!IN")
                    return sExp.hasIN(mExp);
                if (condition == "NI")
                    return !mExp.hasIN(sExp);
                if (condition == "!NI")
                    return mExp.hasIN(sExp);
                return true;
            }
        }

        public string AssetName
        {
            get
            {
                return this.Asset.Name;
            }
        }

        public string ImportanceString
        {
            get
            {
                switch (importance)
                {
                    case IMPORTANCE_SAFE: return "امن";
                    case IMPORTANCE_CRITICAL: return "بحرانی";
                    case IMPORTANCE_SAFE_CRITICAL: return "بحرانی-امن";
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

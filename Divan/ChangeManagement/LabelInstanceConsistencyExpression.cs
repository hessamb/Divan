using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Divan
{
    public class LabelInstanceConsistencyExpression: ConsistencyExpression
    {
        private LabelInstance labelInstance;

        public LabelInstanceConsistencyExpression(LabelInstance labelInstance)
        {
            this.labelInstance = labelInstance;
        }

        public object getValue()
        {
            if (labelInstance.Label.LabelDomain.isDiscrete())
                return labelInstance.value;
            else
                return Convert.ToDouble(labelInstance.value);
        }

        public override bool equals(ConsistencyExpression ce)
        {
            if (ce is LabelInstanceConsistencyExpression)
            {
                LabelInstanceConsistencyExpression lice = (ce as LabelInstanceConsistencyExpression);
                return lice.getValue() == this.getValue();
            }
            else if (ce is StringConsistencyExpression)
            {
                StringConsistencyExpression sce = (ce as StringConsistencyExpression);
                return sce.getValue() == this.getValue();
            }
            else if (ce is PropertyConsistencyExpression)
            {
                PropertyConsistencyExpression pce = (ce as PropertyConsistencyExpression);
                if (pce.getValue() is String)
                    return this.getValue() == (String)pce.getValue();
                else
                    return false;
            }
            else
            {
                return base.equals(ce);
            }
        }

        public override bool hasIN(ConsistencyExpression ce)
        {
            if (!(ce is StringConsistencyExpression))
                return base.hasIN(ce);
            StringConsistencyExpression sce = (ce as StringConsistencyExpression);
            string[] vals = this.labelInstance.value.Split(new string[] { LabelInstance.VALUE_SPLITTER }, StringSplitOptions.None);
            foreach (string val in vals)
            {
                if (val == sce.getValue())
                    return true;
            }
            return false;
        }
        public new static ConsistencyExpression parseTokens(string[] tokens, ref int k)
        {
            if (tokens[k] != "#")
                return null;
            int f = k;
            k++;
            string uid = getUntil(tokens, ref k, "#");
            if (uid == null)
            {
                k = f;
                return null;
            }
            string labelName = getUntil(tokens, ref k, "#");
            if (labelName == null)
            {
                k = f;
                return null;
            }

            Asset asset = AssetList.Instance.GetByUid(uid);
            if (asset == null)
            {
                k = f;
                return null;
            }
            LabelInstance labelInstance = asset.getLabelInstance(labelName);
            if (labelInstance == null)
            {
                k = f;
                return null;
            }
            return new LabelInstanceConsistencyExpression(labelInstance);
        }

        private static string getUntil(string[] tokens, ref int k, string str)
        {
            string res = "";
            for (; k < tokens.Length; k++)
            {
                if (tokens[k] == str)
                    break;
                res += " ";
                res += Regex.Unescape(tokens[k]);
            }
            if (k == tokens.Length || res == "")
            {
                return null;
            }
            res = res.Substring(1);
            k++;
            return res;
        }
    }
}

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
            return labelInstance.getValue();
        }

        private bool arrayEquals(LabelInstanceConsistencyExpression lice)
        {
            if (!this.isMultipleValue() || !lice.isMultipleValue())
                return false;
            object[] arr1 = (object[])this.getValue();
            object[] arr2 = (object[])lice.getValue();
            if (arr1.Length != arr2.Length)
                return false;
            for (int i=0 ; i<arr1.Length ; i++){
                bool found = false;
                for (int j = i; j < arr2.Length; j++)
                {
                    if (arr1[i].Equals(arr2[j]))
                    {
                        object tmp = arr2[i];
                        arr2[i] = arr2[j];
                        arr2[j] = tmp;
                        found = true;
                        break;
                    }
                }
                if (!found)
                    return false;
            }
            return true;
        }

        public SetConsistencyExpression getSetExpression()
        {
            if (!this.isMultipleValue())
                return null;
            object[] arr = (object[]) this.getValue();
            List<ConsistencyExpression> list = new List<ConsistencyExpression>();
            foreach (object o in arr)
            {
                if (o is String)
                    list.Add(new StringConsistencyExpression(o as String));
                else
                    list.Add(new DoubleConsistencyExpression((double)o));
            }
            return new SetConsistencyExpression(list);
        }

        public bool  isMultipleValue()
        {
            object value = this.getValue();
            return (value is object[]) || (value is String[]) || (value is double[]);
        }

        public override bool equals(ConsistencyExpression ce)
        {
            if (ce is LabelInstanceConsistencyExpression)
            {
                LabelInstanceConsistencyExpression lice = (ce as LabelInstanceConsistencyExpression);
                if (this.isMultipleValue())
                    return this.arrayEquals(lice); // Might use getSetExpression, but this one is more efficient.
                else
                    return lice.getValue().Equals(this.getValue());
            }
            else if (ce is StringConsistencyExpression)
            {
                StringConsistencyExpression sce = (ce as StringConsistencyExpression);
                return sce.getValue().Equals(this.getValue());
            }
            else if (ce is PropertyConsistencyExpression)
            {
                PropertyConsistencyExpression pce = (ce as PropertyConsistencyExpression);
                return pce.getValue().Equals(this.getValue());
            }
            else if (ce is SetConsistencyExpression)
            {
                return this.getSetExpression().equals(ce);
            }
            else
            {
                return base.equals(ce);
            }
        }

        public override bool hasIN(ConsistencyExpression ce)
        {
            if (!isMultipleValue())
            {
                return base.hasIN(ce);
            }
            object[] arr = (object[])this.getValue();
            foreach (object o in arr)
            {
                if (ce is StringConsistencyExpression)
                {
                    if (o.Equals((ce as StringConsistencyExpression).getValue()))
                    {
                        return true;
                    }
                }
                else if (ce is DoubleConsistencyExpression)
                {
                    if (o.Equals((ce as DoubleConsistencyExpression).getValue()))
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
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

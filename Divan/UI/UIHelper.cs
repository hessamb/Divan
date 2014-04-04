using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Divan
{
    class UIHelper
    {
        private static Dictionary<TextBox, String> placeHolders = new Dictionary<TextBox, string>();
        public static void disableCell(DataGridViewCell cell)
        {
            cell.ReadOnly = true;
            cell.Style.ForeColor = Color.DarkGray;
            cell.Style.BackColor = Color.LightGray;
        }

        public static void searchGrid(DataGridView grid, string pattern)
        {
            foreach (DataGridViewRow row in grid.Rows)
            {
                CurrencyManager cm = (CurrencyManager)grid.BindingContext[grid.DataSource];
                cm.SuspendBinding();
                row.Visible = doesMatch(row, pattern);
                cm.ResumeBinding();
            }
        }


        private static bool doesMatch(DataGridViewRow row, string pattern)
        {
            foreach (string word in pattern.Split(" ".ToCharArray()))
            {
                bool matched = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value is string && ((string)cell.Value).IndexOf(word) != -1)
                    {
                        matched = true;
                        break;
                    }
                }
                if (!matched)
                    return false;
            }
            return true;
        }

        public static void SetPlaceHolder(TextBox textbox, String text)
        {
            placeHolders.Add(textbox, text);
            textbox.Enter += textbox_Enter;
            textbox.Leave += textbox_Leave;
            textbox_Leave(textbox,null);
        }

        static void textbox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = ((TextBox)sender);
            if (textBox.Text == "")
            {
                textBox.ForeColor = Color.Gray;
                textBox.Text = placeHolders[textBox];
            }
            else
            {
                textBox.ForeColor = Color.Black;
            }
        }

        static void textbox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = ((TextBox)sender);
            if (textBox.Text == placeHolders[textBox])
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        public static void errorBox(IWin32Window parent, string message)
        {
            const string TITLE = "خطا";
            MessageBox.Show(parent, message, TITLE, new MessageBoxButtons(), MessageBoxIcon.Error);
        }

        public static class Validation
        {
            public static bool isNonEmpty(String text)
            {
                return text != null && text.Trim().Count() > 0;
            }

            public static bool isDouble(String text)
            {
                try
                {
                    Convert.ToDouble(text);
                    return true;
                }
                catch
                {
                    return false;
                }
            }

            public static bool isDisntinct(List<String> list)
            {
                return list.Distinct().AsEnumerable().Count() == list.Count;
            }
        }
    }
}

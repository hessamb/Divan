using System;
using System.Collections.Generic;
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
    }
}

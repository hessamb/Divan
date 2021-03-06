﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            cell.Style.SelectionBackColor = Color.LightBlue;
        }

        public static void searchGrid(DataGridView grid, string pattern, string columnName = "")
        { // Passing null as columnName results in all columns search.
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (grid.DataSource != null)
                {
                    CurrencyManager cm = (CurrencyManager)grid.BindingContext[grid.DataSource];
                    cm.SuspendBinding();
                    row.Visible = doesMatch(row, pattern, columnName);
                    cm.ResumeBinding();
                }
                else
                {
                    row.Visible = doesMatch(row, pattern, columnName);
                }
            }
        }


        private static bool doesMatch(DataGridViewRow row, string pattern, string columnName)
        {
            foreach (string word in pattern.Split(" ".ToCharArray()))
            {
                bool matched = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (columnName != "" && cell.OwningColumn.Name != columnName)
                        continue;
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
                textBox.WordWrap = true;
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
                textBox.WordWrap = false;
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        public static void errorBox(IWin32Window parent, string message)
        {
            const string TITLE = "خطا";
            MessageBox.Show(parent, message, TITLE, new MessageBoxButtons(), MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
        }

        public static void warningBox(IWin32Window parent, string message)
        {
            const string TITLE = "اخطار";
            MessageBox.Show(parent, message, TITLE, new MessageBoxButtons(), MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1 ,MessageBoxOptions.RtlReading);
        }

        
        public static class Validation
        {
            private static Dictionary<Control, ErrorProvider> controlsErrorProviders = new Dictionary<Control, ErrorProvider>();

            private static event System.ComponentModel.CancelEventHandler myevent;

            public static bool DoNotEmptyValidation(TextBox textBox)
            {
                textBox_Validating(textBox, null);
                return controlsErrorProviders[textBox].GetError(textBox) == "";
            }

            public static void ValidateNotEmpty(TextBox textBox, ErrorProvider errorProvider)
            {
                textBox.Validating += textBox_Validating;
                try
                {
                    controlsErrorProviders.Add(textBox, errorProvider);
                }
                catch
                {
                    // textBox exists in dictionary
                }
            }

            public static void CancelValidateNotEmpty(TextBox textBox)
            {
                try
                {
                    textBox.Validating -= textBox_Validating;
                    controlsErrorProviders[textBox].SetError(textBox, "");
                    controlsErrorProviders.Remove(textBox);
                }
                catch { }
            }

            static void textBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
            {
                var textBox = sender as TextBox;
                var errorProvider=controlsErrorProviders[textBox];
                if (Validation.isNonEmpty(textBox.Text))
                    errorProvider.SetError(textBox, "");
                else
                    errorProvider.SetError(textBox, "این مورد الزامی است.");
            }

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

            public static bool isInteger(string value)
            {
                try
                {
                    Convert.ToInt32(value);
                    return true;
                }
                catch
                {
                    return false;
                }
            }

            public static bool isValidNationalID(string text)
            {
                return Regex.Match(text, @"^\d{10}$").Success;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Divan.UI
{
    public partial class ReportInconsistencies : Form
    {
        public ReportInconsistencies()
        {
            InitializeComponent();
        }

        private void ReportInconsistencies_Load(object sender, EventArgs e)
        {
            
            dataGrid_consistencies.AutoGenerateColumns = false;
            dataGrid_consistencies.DataSource = ConsistencyRulesList.Instance.GetAll();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            DataGridView grid = (DataGridView)dataGrid_consistencies;
            foreach (DataGridViewRow row in dataGrid_consistencies.Rows)
            {
                if (!(Boolean)row.Cells[5].Value)
                {
                    CurrencyManager cm = (CurrencyManager)grid.BindingContext[grid.DataSource];
                    cm.SuspendBinding();
                    row.Visible = !checkBox1.Checked;
                    cm.ResumeBinding();
                }
            }
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (!searchTxt.WordWrap)
                return;
            RadioButton[] buttons = new RadioButton[]{radioButton_allProperties,
                radioButton_name, radioButton_uid};
            foreach (RadioButton b in buttons)
            {
                if (b.Checked)
                {
                    UIHelper.searchGrid(dataGrid_consistencies, searchTxt.Text, (string)b.Tag);
                    break;
                }
            }
        }
    }
}

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
    }
}

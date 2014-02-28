using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Divan
{
    public partial class LabelDetailsWindow : Form
    {
        public LabelDetailsWindow()
        {
            InitializeComponent();
        }

        private void NewAsset_Load(object sender, EventArgs e)
        {
            domainGrid.Rows.Add(new object[] { "۱", "بد" });
            domainGrid.Rows.Add(new object[] { "۲", "متوسط" });
            domainGrid.Rows.Add(new object[] { "۳", "خوب" });

            labelsTree.ExpandAll();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            (new EditLabelWindow()).ShowDialog();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            contextMenuStrip2.Show(delete,0,0);
        }

        private void subAssetsTree_DoubleClick(object sender, EventArgs e)
        {
            (new LabelDetailsWindow()).ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void مشاهدهمشخصاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            subAssetsTree_DoubleClick(null, null);
        }

        private void فقطازلیستپاککنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RemoveConfirmationBox.ShowConfirmation() == System.Windows.Forms.DialogResult.Yes)
                DialogResult = System.Windows.Forms.DialogResult.Yes;
        }
    }
}

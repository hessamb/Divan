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

        private Label label;

        public LabelDetailsWindow()
        {
            InitializeComponent();
        }

        public LabelDetailsWindow(Label label)
            : this()
        {
            this.label = label;
        }

        private void NewAsset_Load(object sender, EventArgs e)
        {
            label_name.Text = "نام برچسب: " + label.name;
            label_type.Text = "نوع برچسب: " + (label.setValue ? "مقدارپذیر" : "مقدارناپذیر");
            label_domainModel.Text = "دامنه حالت: " + label.domainModel;
            if (!label.setValue)
            {
                domainGroup.Visible = false;
            }
            else if (label.LabelDomain.isDiscrete())
            {
                label_continuousDomain.Visible = false;
                domainGrid.Visible = true;
                IEnumerable<DiscreteDomainValue> values = label.LabelDomain.DiscreteDomainValues.OrderBy((DiscreteDomainValue value) => value.rank).AsEnumerable();

                domainGrid.AutoGenerateColumns = false;
                domainGrid.DataSource = values;

                domainGrid.Columns["rank"].Visible = (label.LabelDomain.isOrdered ?? false);
            }
            else
            {
                domainGrid.Visible = false;
                label_continuousDomain.Visible = true;
                label_continuousDomain.Text = "این برچسب هر عدد حقیقی از "
                    + label.LabelDomain.minValue + " تا "
                    + label.LabelDomain.maxValue + " را می‌پذیرد.";
            }
            splitterLabelGroup.Visible = label.isSplitter;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            (new NewLabelWindow(label)).ShowDialog();
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

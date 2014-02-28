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
    public partial class LabelsWindow : Form
    {
        public string SelectedLabel { get; set; }
        public static string ShowLabels()
        {
            LabelsWindow a = new LabelsWindow();
            a.select.Visible=a.cancel.Visible=a.cancel.Enabled= true;
            a.delete.Visible = a.edit.Visible = false;
            a.assetsGrid.DoubleClick -= a.assetsGrid_DoubleClick;
            a.assetsGrid.DoubleClick += a.select_Click;
            if (a.ShowDialog() == DialogResult.OK)
            {
                return a.SelectedLabel;
            }
            return null;
        }

        public LabelsWindow()
        {
            InitializeComponent();
        }

        private void assetsTree_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void assetForm_Load(object sender, EventArgs e)
        {
            UIHelper.SetPlaceHolder(searchTxt, "جستجوی برچسب");

            for (int i = 0; i < 5; i++)
            {
                TreeNode trafficLight = new TreeNode("چراغ راهنمایی چهارراه بهبودی");
                TreeNode crossWalk = new TreeNode("خط‌کشی عابر پیاده چهارراه بهبودی");
                TreeNode behboodi = new TreeNode("چهارراه بهبودی", new TreeNode[] { trafficLight, crossWalk });
                TreeNode azadi = new TreeNode("خیابان آزادی", new TreeNode[] { behboodi });
                azadi.ExpandAll();
                //assetsTree.Nodes.Add(azadi);
            }

            for (int i = 0; i < 5; i++)
            {
                assetsGrid.Rows.Add(new object[] { "تعریف‌گر نوع دارایی", false, "", true });
                assetsGrid.Rows.Add(new object[] { "خیابان", true, "گسسته", true });
                assetsGrid.Rows.Add(new object[] { "خطکشی", true, "گسسته", true });
                assetsGrid.Rows.Add(new object[] { "چراغ راهنمایی", true, "گسسته", false });
            }
        }

        private void assetsGrid_SelectionChanged(object sender, EventArgs e)
        {
            bool selected = assetsGrid.SelectedCells.Count > 0;
            edit.Enabled = delete.Enabled = selected;
            if (select.Visible)
                select.Enabled = selected;
        }

        private void select_Click(object sender, EventArgs e)
        {
           SelectedLabel = (string)assetsGrid.SelectedCells[0].OwningRow.Cells[0].Value;
           DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void edit_Click_1(object sender, EventArgs e)
        {
            (new EditLabelWindow()).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new NewLabelWindow()).ShowDialog();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            contextMenuStrip2.Show(delete, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new LabelDetailsWindow()).ShowDialog();
        }

        private void assetsGrid_DoubleClick(object sender, EventArgs e)
        {
            button1_Click(null, null);
        }

        private void فقطازلیستپاککنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < assetsGrid.SelectedCells.Count; i++)
                set.Add(assetsGrid.SelectedCells[i].RowIndex);
            int cnt = set.Count;
            string message = "";
            if (cnt > 1)
            {
                message = "آیا از حذف " + cnt + " برچسب انتخاب شده مطمئنید؟";
            }
            else if (cnt == 1)
            {
                string name = (string)assetsGrid.SelectedCells[0].OwningRow.Cells[1].Value;
                message = "آیا از حذف برچسب «" + name + "» مطمئنید؟";
            }
            RemoveConfirmationBox.ShowConfirmation(message);
        }
    }
}

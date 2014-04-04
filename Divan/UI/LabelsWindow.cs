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
            a.labelsGrid.DoubleClick -= a.assetsGrid_DoubleClick;
            a.labelsGrid.DoubleClick += a.select_Click;
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
            
            labelsGrid.AutoGenerateColumns = false;
            labelsGrid.DataSource = LabelList.Instance.GetAll();

        }

        private void assetsGrid_SelectionChanged(object sender, EventArgs e)
        {
            bool selected = labelsGrid.SelectedCells.Count > 0;
            edit.Enabled = delete.Enabled = selected;
            if (select.Visible)
                select.Enabled = selected;
        }

        private void select_Click(object sender, EventArgs e)
        {
           SelectedLabel = (string)labelsGrid.SelectedCells[0].OwningRow.Cells[0].Value;
           DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void edit_Click_1(object sender, EventArgs e)
        {
            try
            {
                (new NewLabelWindow(getSelectedLabel())).ShowDialog();
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new NewLabelWindow()).ShowDialog();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            contextMenuStrip2.Show(delete, 0, 0);
        }

        private Label getSelectedLabel()
        {
            int id = (int)labelsGrid.SelectedRows[0].Cells["id"].Value;
            return LabelList.Instance.getLabelById(id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                (new LabelDetailsWindow(getSelectedLabel())).ShowDialog();
            }
            catch
            {
            }
        }

        private void assetsGrid_DoubleClick(object sender, EventArgs e)
        {
            button1_Click(null, null);
        }

        private void فقطازلیستپاککنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < labelsGrid.SelectedCells.Count; i++)
                set.Add(labelsGrid.SelectedCells[i].RowIndex);
            int cnt = set.Count;
            string message = "";
            if (cnt > 1)
            {
                message = "آیا از حذف " + cnt + " برچسب انتخاب شده مطمئنید؟";
            }
            else if (cnt == 1)
            {
                string name = (string)labelsGrid.SelectedCells[0].OwningRow.Cells[1].Value;
                message = "آیا از حذف برچسب " + name + " مطمئنید؟";
            }
            if (RemoveConfirmationBox.ShowConfirmation(message) == DialogResult.OK)
            {
                DivanDataContext.Instance.Labels.DeleteOnSubmit(getSelectedLabel());
            }
        }

        private void labelsGrid_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            button1_Click(null, null);
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (!searchTxt.WordWrap) // It's not place holder
                UIHelper.searchGrid(labelsGrid, searchTxt.Text);
        }
    }
}

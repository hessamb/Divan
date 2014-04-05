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
        private Asset asset;
        public Label SelectedLabel { get; set; }
        
        private static void initializeSelectComponents(LabelsWindow window)
        {
            window.select.Visible = window.cancel.Visible = window.cancel.Enabled = true;
            window.delete.Visible = window.edit.Visible = false;
            window.labelsGrid.CellDoubleClick -= window.labelsGrid_CellContentDoubleClick_1;
            window.labelsGrid.CellDoubleClick += window.select_Click;
        }

        public static Label ShowLabels()
        {
            LabelsWindow a = new LabelsWindow();
            initializeSelectComponents(a);
            if (a.ShowDialog() == DialogResult.OK)
            {
                return a.SelectedLabel;
            }
            return null;
        }

        public static Label ShowLabels(Asset asset)
        {
            LabelsWindow a = new LabelsWindow(asset);
            initializeSelectComponents(a);
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

        public LabelsWindow(Asset asset): this()
        {
            this.asset = asset;
        }

        private void assetsTree_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void assetForm_Load(object sender, EventArgs e)
        {
            UIHelper.SetPlaceHolder(searchTxt, "جستجوی برچسب");
            
            labelsGrid.AutoGenerateColumns = false;
            if (this.asset == null)
                labelsGrid.DataSource = LabelList.Instance.GetAll();
            else
            {
                BindingSource source = new BindingSource();
                source.DataSource = asset.getLabels();
                labelsGrid.DataSource = source;
            }
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
           SelectedLabel = getSelectedLabel();
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
                DivanDataContext.Instance.SubmitChanges();
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

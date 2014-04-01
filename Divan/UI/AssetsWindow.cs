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
    public partial class AssetsWindow : Form
    {
        public string SelectedAsset { get; set; }
        public static string ShowAssets()
        {
            AssetsWindow a = new AssetsWindow();
            a.select.Visible=a.cancel.Visible=a.cancel.Enabled= true;
            a.delete.Visible = a.edit.Visible = a.changeState.Visible = false;
            a.dataGrid_assets.DoubleClick -= a.assetsGrid_DoubleClick;
            a.dataGrid_assets.DoubleClick += a.select_Click; 

            if (a.ShowDialog() == DialogResult.OK)
            {
                return a.SelectedAsset;
            }

            return null;
        }

        public AssetsWindow()
        {
            InitializeComponent();
        }

        private void assetsTree_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void assetForm_Load(object sender, EventArgs e)
        {
            UIHelper.SetPlaceHolder(searchTxt, "جستجوی دارایی");

            dataGrid_assets.AutoGenerateColumns = false;
            dataGrid_assets.DataSource = AssetList.Instance.GetAll();
        }

        private void assetsGrid_SelectionChanged(object sender, EventArgs e)
        {
            bool selected = dataGrid_assets.SelectedCells.Count > 0;
            edit.Enabled = delete.Enabled = selected;
            if (select.Visible)
                select.Enabled = selected;
        }

        private void select_Click(object sender, EventArgs e)
        {
           SelectedAsset = (string)dataGrid_assets.SelectedCells[0].OwningRow.Cells[0].Value;
           DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void edit_Click_1(object sender, EventArgs e)
        {
            string uid = (string)dataGrid_assets.SelectedRows[0].Cells[0].Value;
            (new NewAssetWindow(AssetList.Instance.GetByUid(uid))).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new NewAssetWindow()).ShowDialog();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            contextMenuStrip2.Show(delete, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uid = (string)dataGrid_assets.SelectedRows[0].Cells[0].Value;
            Asset asset = AssetList.Instance.GetByUid(uid);
            (new AssetDetailsWindow(asset)).ShowDialog();
        }

        private void assetsGrid_DoubleClick(object sender, EventArgs e)
        {
            button1_Click(null, null);
        }

        private void changeState_Click(object sender, EventArgs e)
        {
            (new ChangeStateWindow()).ShowDialog();
        }

        private void فقطازلیستپاککنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < dataGrid_assets.SelectedCells.Count; i++)
                set.Add(dataGrid_assets.SelectedCells[i].RowIndex);
            int cnt = set.Count;
            string message = "";
            if (cnt > 1)
            {
                message = "آیا از حذف " + cnt + " دارایی انتخاب شده مطمئنید؟";
            }
            else if (cnt == 1)
            {
                string name = (string)dataGrid_assets.SelectedCells[0].OwningRow.Cells[1].Value;
                message = "آیا از حذف دارایی «" + name + "» مطمئنید؟";
            }
            RemoveConfirmationBox.ShowConfirmation(message);
        }

        private void assetsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
            reloadAssets();
        }

        private void reloadAssets(){
            dataGrid_assets.DataSource = AssetList.Instance.GetAllVisibles();
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
            if((new NewAssetWindow(AssetList.Instance.GetByUid(uid))).ShowDialog()==System.Windows.Forms.DialogResult.Yes)
                reloadAssets();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if((new NewAssetWindow()).ShowDialog()==System.Windows.Forms.DialogResult.Yes)
                this.reloadAssets();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            howToDeleteMenuStrip.Show(delete, 0, 0);
        }

        private Asset getSelectedAsset()
        {
            string uid = (string)dataGrid_assets.SelectedRows[0].Cells[0].Value;
            Asset asset = AssetList.Instance.GetByUid(uid);
            return asset;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new AssetDetailsWindow(getSelectedAsset())).ShowDialog();
        }

        private void assetsGrid_DoubleClick(object sender, EventArgs e)
        {
            button1_Click(null, null);
        }

        private void changeState_Click(object sender, EventArgs e)
        {
            (new ChangeStateWindow(getSelectedAsset())).ShowDialog();
        }

        private void فقطازلیستپاککنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cnt = dataGrid_assets.SelectedRows.Count;
            string message = "";
            if (cnt > 1)
            {
                message = "آیا از حذف " + cnt + " دارایی انتخاب شده مطمئنید؟";
            }
            else if (cnt == 1)
            {
                string name = (string)dataGrid_assets.SelectedRows[0].Cells[1].Value;
                message = "آیا از حذف دارایی " + name + " مطمئنید؟";
            }
            if (RemoveConfirmationBox.ShowConfirmation(message) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGrid_assets.SelectedRows)
                {
                    string uid = (string)row.Cells[0].Value;
                    Asset rowAsset = AssetList.Instance.GetByUid(uid);
                    DivanDataContext.Instance.Assets.DeleteOnSubmit(rowAsset);
                }
                DivanDataContext.Instance.SubmitChanges();
                dataGrid_assets.DataSource = AssetList.Instance.GetAll();
                reloadAssets();
            }
        }

        private void assetsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void فقطازلیستپاککنToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int cnt = dataGrid_assets.SelectedRows.Count;
            string message = "";
            if (cnt > 1)
            {
                message = "آیا از حذف " + cnt + " دارایی انتخاب شده مطمئنید؟";
            }
            else if (cnt == 1)
            {
                string name = (string)dataGrid_assets.SelectedRows[0].Cells[1].Value;
                message = "آیا از حذف دارایی " + name + " مطمئنید؟";
            }
            if (RemoveConfirmationBox.ShowConfirmation(message) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGrid_assets.SelectedRows)
                {
                    string uid = (string)row.Cells[0].Value;
                    Asset rowAsset = AssetList.Instance.GetByUid(uid);
                    rowAsset.visible=false;
                }
                DivanDataContext.Instance.SubmitChanges();
                dataGrid_assets.DataSource = AssetList.Instance.GetAll();
                reloadAssets();
            }
        }
    }
}

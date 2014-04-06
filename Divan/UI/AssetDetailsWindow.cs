using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
 
using System.Windows.Forms;

namespace Divan
{
    public partial class AssetDetailsWindow : Form
    {
        private Asset selectedAsset;

        public AssetDetailsWindow()
        {
            InitializeComponent();
        }

        public AssetDetailsWindow(Asset asset): this()
        {
            this.selectedAsset = asset;
        }

        private void NewAsset_Load(object sender, EventArgs e)
        {
            fillPrimaryInfoGrid();
            fillLabelInstancesGrid();
            fillSubAssetTree();
            if (!selectedAsset.AttachedFiles.Any())
                button_attachments.Enabled = false;
        }

        private void fillSubAssetTree()
        {
            foreach (Asset asset in selectedAsset.GetSubAssets())
            {
                treeView_subAsset.Nodes.Add(asset.getTreeNode());
            }
            treeView_subAsset.ExpandAll();
        }

        private void fillLabelInstancesGrid()
        {
            foreach (LabelInstance labelInstance in selectedAsset.LabelInstances)
            {
                Label label = labelInstance.Label;
                string value = labelInstance.value;
                dataGrid_labelInstance.Rows.Add(new object[] { label.name, value });
                if (!label.setValue)
                {
                    DataGridViewRow row = dataGrid_labelInstance.Rows[dataGrid_labelInstance.Rows.Count - 1];
                    row.Cells[1].Value = Label.UNASSANABLE_VALUE;
                }
            }
        }

        private void fillPrimaryInfoGrid()
        {
            dataGrid_primaryInfo.Rows.Add(new object[] { "شناسه", selectedAsset.UID });
            dataGrid_primaryInfo.Rows.Add(new object[] { "نام", selectedAsset.Name });
            if (selectedAsset.isHuman)
            {
                dataGrid_primaryInfo.Rows.Add(new object[] { "نام کوچک", selectedAsset.FirstName });
                dataGrid_primaryInfo.Rows.Add(new object[] { "نام خانوادگی", selectedAsset.LastName });
                dataGrid_primaryInfo.Rows.Add(new object[] { "کد ملی", selectedAsset.NationalID });
                dataGrid_primaryInfo.Rows.Add(new object[] { "کد پرسنلی", selectedAsset.PersonnelCode });
                dataGrid_primaryInfo.Rows.Add(new object[] { "توضیحات انسانی", selectedAsset.HumanDescription });
            }
            if (selectedAsset.isPhysical)
            {
                dataGrid_primaryInfo.Rows.Add(new object[] { "مشخصات ظاهری", selectedAsset.PhysicalDescription });
            }

            foreach (Property prop in selectedAsset.PrimaryInfos)
            {
                    dataGrid_primaryInfo.Rows.Add(new object[] { prop.Name, prop.Value });
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            (new NewAssetWindow(selectedAsset)).ShowDialog();
        }

        private void history_Click(object sender, EventArgs e)
        {
            (new AssetHistoryWindow()).ShowDialog();
        }

        private void subAssetsTree_DoubleClick(object sender, EventArgs e)
        {
            if(treeView_subAsset.SelectedNode!=null)
                (new AssetDetailsWindow(treeView_subAsset.SelectedNode.Tag as Asset)).ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void مشاهدهمشخصاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            subAssetsTree_DoubleClick(null, null);
        }

        private void changeState_Click(object sender, EventArgs e)
        {
            (new ChangeStateWindow()).ShowDialog();
        }

        private void فقطازلیستپاککنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RemoveConfirmationBox.ShowConfirmation() == System.Windows.Forms.DialogResult.Yes)
                DialogResult = System.Windows.Forms.DialogResult.Yes;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new AssetAttachementViewer(selectedAsset).ShowDialog();
        }
    }
}

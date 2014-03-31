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
    public partial class NewAssetWindow : Form
    {
        private List<Asset> subAssets = new List<Asset>();

        public NewAssetWindow()
        {
            InitializeComponent();
        }

        private void humanAssetCh_CheckedChanged(object sender, EventArgs e)
        {
            humanAssetProps.Visible = checkBox_isHuman.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            sensibleAssetProps.Visible = checkBox_isPhysical.Checked;
        }

        private void NewAsset_Load(object sender, EventArgs e)
        {
            UIHelper.SetPlaceHolder(labelSearchtxt, "جستجوی برچسب");
            treeView_subAssets.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            removeSubAssetBut.Enabled = treeView_subAssets.Focused && treeView_subAssets.SelectedNode != null;
        }

        private void subAssetsTree_Leave(object sender, EventArgs e)
        {
            removeSubAssetBut.Enabled = treeView_subAssets.Focused && treeView_subAssets.SelectedNode != null;
        }

        private void removeSubAssetBut_Click(object sender, EventArgs e)
        {
            if (RemoveConfirmationBox.ShowConfirmation() == System.Windows.Forms.DialogResult.Yes)
            {
                string text = treeView_subAssets.SelectedNode.Text;
                int index = text.LastIndexOf('(');
                string uid = text.Substring(index + 1, text.Length - index - 2);
                subAssets.Remove(AssetList.Instance.GetByUid(uid));
                treeView_subAssets.SelectedNode.Remove();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void compositAsset_CheckedChanged(object sender, EventArgs e)
        {
            GroupBox_subAssets.Visible = checkBox_Composite.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string assetUid = AssetsWindow.ShowAssets();
            if (assetUid == null)
            {
                return;
            }
            Asset subAsset = AssetList.Instance.GetByUid(assetUid);
            if (!subAssets.Contains(subAsset))
            {
                subAssets.Add(subAsset);
                treeView_subAssets.Nodes.Add(subAsset.getTreeNode());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                attachmentList.Items.Add(openFileDialog1.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (RemoveConfirmationBox.ShowConfirmation() == System.Windows.Forms.DialogResult.Yes)
                attachmentList.Items.RemoveAt(attachmentList.SelectedIndex);
        }

        private void attachmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteFileBut.Enabled = attachmentList.Focused && attachmentList.SelectedItem != null;
        }

        private void approveClicked(object sender, EventArgs e)
        {
            Asset newAsset = new Asset();

            DivanDataContext.Instance.Assets.InsertOnSubmit(newAsset);

            DivanDataContext.Instance.SubmitChanges();

            DivanDataContext.Instance.Properties.InsertOnSubmit(new Property(Asset.UID_STRING, textBox_UID.Text, newAsset));
            DivanDataContext.Instance.Properties.InsertOnSubmit(new Property(Asset.NAME_STRING, textBox_Name.Text, newAsset));

            DivanDataContext.Instance.SubmitChanges();

            newAsset.isHuman = checkBox_isHuman.Checked;
            if (newAsset.isHuman)
            {
                DivanDataContext.Instance.Properties.InsertOnSubmit(new Property(Asset.FIRST_NAME_STRING, textBox_FirstName.Text, newAsset));
                DivanDataContext.Instance.Properties.InsertOnSubmit(new Property(Asset.LAST_NAME_STRING, textBox_LastName.Text, newAsset));
                DivanDataContext.Instance.Properties.InsertOnSubmit(new Property(Asset.National_ID_STRING, textBox_NationalID.Text, newAsset));
                DivanDataContext.Instance.Properties.InsertOnSubmit(new Property(Asset.PERSONNEL_CODE_STRING, textBox_PersonnelCode.Text, newAsset));
                DivanDataContext.Instance.Properties.InsertOnSubmit(new Property(Asset.HUMAN_DESCRIPTION_STRING, textBox_HumanDescription.Text, newAsset));
            }
            newAsset.isPhysical = checkBox_isPhysical.Checked;
            if (newAsset.isPhysical)
            {
                DivanDataContext.Instance.Properties.InsertOnSubmit(new Property(Asset.PHYSICAL_DESCRIPTION_STRING, textBox_PhysicalDescription.Text, newAsset));
            }
            newAsset.isPortable = checkBox_isPortable.Checked;

            for (int i = 0; i < dataGrid_PrimaryInfo.RowCount - 1; i++)
            {
                DivanDataContext.Instance.Properties.InsertOnSubmit(new Property((string)dataGrid_PrimaryInfo.Rows[i].Cells[0].Value, (string)dataGrid_PrimaryInfo.Rows[i].Cells[2].Value, newAsset, (string)dataGrid_PrimaryInfo.Rows[i].Cells[1].Value));
            }

            foreach (String fileName in attachmentList.Items)
            {
                // TODO: attached files need to be uploaded.
                AttachedFile file = new AttachedFile();
                file.Asset = newAsset;
                file.path = fileName;
                DivanDataContext.Instance.AttachedFiles.InsertOnSubmit(file);
            }

            DivanDataContext.Instance.SubmitChanges();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}

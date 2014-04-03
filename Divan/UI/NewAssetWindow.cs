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
        private Asset asset;
        private List<Asset> subAssets = new List<Asset>();
        private List<int> splitterLabelId, otherLabelId;

        public NewAssetWindow()
        {
            InitializeComponent();
        }

        public NewAssetWindow(Asset asset)
            : this()
        {
            this.Text = "ویرایش عملیات";
            this.asset = asset;
        }

        private void humanAssetCh_CheckedChanged(object sender, EventArgs e)
        {
            humanAssetProps.Visible = checkBox_isHuman.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            sensibleAssetProps.Visible = checkBox_isPhysical.Checked;
        }

        private void loadFields()
        {
            loadPrimaryFields();
            loadProperties();
            loadLabelInstances();
            loadSubAssets();
            loadAttachments();
        }

        private void loadAttachments()
        {
            foreach (AttachedFile file in asset.AttachedFiles)
            {
                attachmentList.Items.Add(file.path);
            }
        }

        private void loadSubAssets()
        {
            checkBox_Composite.Checked = asset.isComposite();
            foreach (Asset a in this.asset.getSubAssets())
            {
                treeView_subAssets.Nodes.Add(a.getTreeNode());
            }
            treeView_subAssets.ExpandAll();
        }

        private void loadLabelInstances()
        {
            foreach (LabelInstance labelInstance in asset.LabelInstances)
            {
                int id = labelInstance.labelID;
                int index = splitterLabelId.IndexOf(id);
                if (index != -1)
                {
                    dataGrid_DefinerLabel.Rows[index].Cells[0].Value = true;
                    dataGrid_DefinerLabel.Rows[index].Cells[2].Value = labelInstance.value;
                }
                else
                {
                    index = otherLabelId.IndexOf(id);
                    if (index != -1)
                    {
                        dataGrid_OtherLabel.Rows[index].Cells[2].Value = labelInstance.value;
                        dataGrid_OtherLabel.Rows[index].Cells[0].Value = true;
                    }
                }
            }
        }

        private void loadProperties()
        {
            foreach (Property prop in asset.Properties)
            {
                if (!Asset.SPECIAL_NAMES.Contains(prop.name))
                {
                    dataGrid_PrimaryInfo.Rows.Add(new object[] { prop.name, prop.type, prop.value });
                }
            }
        }

        private void loadPrimaryFields()
        {
            textBox_Name.Text = asset.Name;
            textBox_UID.Text = asset.UID;
            checkBox_isHuman.Checked = asset.isHuman;
            textBox_FirstName.Text = asset.FirstName;
            textBox_LastName.Text = asset.LastName;
            textBox_NationalID.Text = asset.NationalID;
            textBox_PersonnelCode.Text = asset.PersonnelCode;
            textBox_HumanDescription.Text = asset.HumanDescription;
            checkBox_isPhysical.Checked = asset.isPhysical;
            textBox_PhysicalDescription.Text = asset.PhysicalDescription;
            checkBox_isPortable.Checked = asset.isPortable;
        }

        private void loadLabels()
        {
            IEnumerable<Label> labels = LabelList.Instance.GetAll();
            splitterLabelId = new List<int>();
            otherLabelId = new List<int>();

            foreach (Label label in labels)
            {
                DataGridView grid = label.isSplitter ? dataGrid_DefinerLabel
                    : dataGrid_OtherLabel;
                grid.Rows.Add(new object[] { false, label.name, label.setValue ? "" : Label.UNASSANABLE_VALUE });
                if (!label.setValue)
                {
                    UIHelper.disableCell( grid.Rows[grid.Rows.Count - 1].Cells[2] );
                }

                if (label.isSplitter)
                    splitterLabelId.Add(label.Id);
                else
                    otherLabelId.Add(label.Id);
            }
        }

        private void NewAsset_Load(object sender, EventArgs e)
        {
            UIHelper.SetPlaceHolder(labelSearchtxt, "جستجوی برچسب");
            loadLabels();
            if (asset != null)
            {
                loadFields();
            }
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

        private bool doesMatch(DataGridViewRow row, string pattern)
        {
            foreach (string word in pattern.Split(" ".ToCharArray()))
            {
                bool matched = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value is string && ((string)cell.Value).IndexOf(word) != -1)
                    {
                        matched = true;
                        break;
                    }
                }
                if (!matched)
                    return false;
            }
            return true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string pattern = labelSearchtxt.Text;
            foreach (DataGridViewRow row in dataGrid_OtherLabel.Rows)
            {
                row.Visible = doesMatch(row, pattern);
            }
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
            if (asset == null)
            {
                asset = new Asset();
                DivanDataContext.Instance.Assets.InsertOnSubmit(asset);
            }
            else
            {
                DivanDataContext.Instance.Properties.DeleteAllOnSubmit(asset.Properties);
                DivanDataContext.Instance.LabelInstances.DeleteAllOnSubmit(asset.LabelInstances);

                asset.Properties.Clear();
                asset.LabelInstances.Clear();
                DivanDataContext.Instance.SubmitChanges();
            }

            savePrimaryInfos();
            saveProperties();
            saveLabelInstances();
            saveSubAssets();
            saveAttachments();

            DivanDataContext.Instance.SubmitChanges();
        }

        private void saveAttachments()
        {
            foreach (String fileName in attachmentList.Items)
            {
                // TODO: attached files need to be uploaded.
                AttachedFile file = new AttachedFile();
                file.Asset = asset;
                file.path = fileName;
                DivanDataContext.Instance.AttachedFiles.InsertOnSubmit(file);
            }
        }

        private void saveSubAssets()
        {
            // TODO
        }

        private void saveLabelInstances()
        {
            for (int i = 0; i < dataGrid_DefinerLabel.Rows.Count; i++)
            {
                DataGridViewRow row = dataGrid_DefinerLabel.Rows[i];
                if ((bool)row.Cells[0].Value)
                {
                    DivanDataContext.Instance.LabelInstances.InsertOnSubmit(
                        new LabelInstance(asset.Id, splitterLabelId[i], (string)row.Cells[2].Value));
                }
            }

            for (int i = 0; i < dataGrid_OtherLabel.Rows.Count; i++)
            {
                DataGridViewRow row = dataGrid_OtherLabel.Rows[i];
                if ((bool)row.Cells[0].Value)
                {
                    DivanDataContext.Instance.LabelInstances.InsertOnSubmit(
                        new LabelInstance(asset.Id, otherLabelId[i], (string)row.Cells[2].Value));
                }
            }
        }

        private void saveProperties()
        {
            for (int i = 0; i < dataGrid_PrimaryInfo.RowCount - 1; i++)
            {
                DivanDataContext.Instance.Properties.InsertOnSubmit(new Property((string)dataGrid_PrimaryInfo.Rows[i].Cells[0].Value, (string)dataGrid_PrimaryInfo.Rows[i].Cells[2].Value, asset, (string)dataGrid_PrimaryInfo.Rows[i].Cells[1].Value));
            }
        }

        private void savePrimaryInfos()
        {
            DivanDataContext.Instance.Properties.InsertOnSubmit(new Property(Asset.UID_STRING, textBox_UID.Text, asset));
            DivanDataContext.Instance.Properties.InsertOnSubmit(new Property(Asset.NAME_STRING, textBox_Name.Text, asset));

            asset.isHuman = checkBox_isHuman.Checked;
            if (asset.isHuman)
            {
                DivanDataContext.Instance.Properties.InsertOnSubmit(new Property(Asset.FIRST_NAME_STRING, textBox_FirstName.Text, asset));
                DivanDataContext.Instance.Properties.InsertOnSubmit(new Property(Asset.LAST_NAME_STRING, textBox_LastName.Text, asset));
                DivanDataContext.Instance.Properties.InsertOnSubmit(new Property(Asset.NATIONAL_ID_STRING, textBox_NationalID.Text, asset));
                DivanDataContext.Instance.Properties.InsertOnSubmit(new Property(Asset.PERSONNEL_CODE_STRING, textBox_PersonnelCode.Text, asset));
                DivanDataContext.Instance.Properties.InsertOnSubmit(new Property(Asset.HUMAN_DESCRIPTION_STRING, textBox_HumanDescription.Text, asset));
            }
            asset.isPhysical = checkBox_isPhysical.Checked;
            if (asset.isPhysical)
            {
                DivanDataContext.Instance.Properties.InsertOnSubmit(new Property(Asset.PHYSICAL_DESCRIPTION_STRING, textBox_PhysicalDescription.Text, asset));
            }
            asset.isPortable = checkBox_isPortable.Checked;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}

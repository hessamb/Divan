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
        private List<Asset> deletedSubAssets = new List<Asset>();
        private List<int> splitterLabelId, otherLabelId;

        public NewAssetWindow()
        {
            InitializeComponent();
            UIHelper.Validation.ValidateNotEmpty(textBox_Name, errorProvider);
            UIHelper.Validation.ValidateNotEmpty(textBox_UID, errorProvider);
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

            if (checkBox_isHuman.Checked)
            {
                UIHelper.Validation.ValidateNotEmpty(textBox_FirstName, errorProvider);
                UIHelper.Validation.ValidateNotEmpty(textBox_NationalID, errorProvider);
                UIHelper.Validation.ValidateNotEmpty(textBox_PersonnelCode, errorProvider);
                UIHelper.Validation.ValidateNotEmpty(textBox_LastName, errorProvider);
            }
            else
            {
                UIHelper.Validation.CancelValidateNotEmpty(textBox_FirstName);
                UIHelper.Validation.CancelValidateNotEmpty(textBox_LastName);
                UIHelper.Validation.CancelValidateNotEmpty(textBox_NationalID);
                UIHelper.Validation.CancelValidateNotEmpty(textBox_PersonnelCode);
            }
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
            if (!asset.IsComposite)
                return;
            checkBox_Composite.Checked = true;
            foreach (Asset a in this.asset.SubAssets)
            {
                subAssets.Add(a);
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
            foreach (Property prop in asset.OtherProperties)
            {
                    dataGrid_PrimaryInfo.Rows.Add(new object[] { prop.Name, prop.Type, prop.Value });
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
            else
            {
                checkBox_isHuman.Checked = true;
                checkBox_isPhysical.Checked = true;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            removeSubAssetBut.Enabled = treeView_subAssets.Focused && treeView_subAssets.SelectedNode != null && treeView_subAssets.SelectedNode.Parent==null;
        }

        private void subAssetsTree_Leave(object sender, EventArgs e)
        {
            removeSubAssetBut.Enabled = treeView_subAssets.Focused && treeView_subAssets.SelectedNode != null && treeView_subAssets.SelectedNode.Parent == null;
        }

        private void removeSubAssetBut_Click(object sender, EventArgs e)
        {
            if (RemoveConfirmationBox.ShowConfirmation() == System.Windows.Forms.DialogResult.Yes)
            {
                Asset sub = treeView_subAssets.SelectedNode.Tag as Asset;
                subAssets.Remove(sub);
                deletedSubAssets.Add(sub);
                treeView_subAssets.SelectedNode.Remove();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!labelSearchtxt.WordWrap) // It's not place holder
                UIHelper.searchGrid(dataGrid_OtherLabel, labelSearchtxt.Text);
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
                if (asset != null && subAsset.Id == asset.Id)
                {
                    UIHelper.warningBox(this, "یک دارایی نمی‌تواند زیرداریی خودش باشد.");
                    return;
                }
                if (asset != null && subAsset.pathExists(asset))
                {
                    UIHelper.warningBox(this, "امکان اضافه شدن دارایی انتخاب شده وجود ندارد.\nاضافه کردن دارایی انتخاب شده موجب ایجاد دور در ساختار دارایی‌ها می‌شود.");
                    return;
                }
                subAssets.Add(subAsset);
                
                int index = treeView_subAssets.Nodes.Add(subAsset.getTreeNode());
                treeView_subAssets.Nodes[index].Expand();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                attachmentList.Items.Add(openFileDialog1.FileName);
                List<String> files = new List<String>();
                for(int i=0 ; i<attachmentList.Items.Count ; i++)
                    files.Add( (string)attachmentList.Items[i] );
                if (!UIHelper.Validation.isDisntinct(files))
                    attachmentList.Items.RemoveAt( attachmentList.Items.Count-1 );
            }
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

        private bool areFieldsValidated()
        {
            bool result = true;
            if (!UIHelper.Validation.DoNotEmptyValidation(textBox_Name))
                result = false;
            if (!UIHelper.Validation.DoNotEmptyValidation(textBox_UID))
                result = false;
            else
            {
                string uid = textBox_UID.Text;
                Asset uidAsset = AssetList.Instance.GetByUid(uid);
                if (uidAsset != null && (asset == null || uidAsset.Id != asset.Id))
                {
                    errorProvider.SetError(textBox_UID, "این شناسه تکراری است");
                    result = false;
                }
            }
            if (checkBox_isHuman.Checked)
            {
                if (!UIHelper.Validation.DoNotEmptyValidation(textBox_FirstName))
                    result = false;
                if (!UIHelper.Validation.DoNotEmptyValidation(textBox_LastName))
                    result = false;
                if (!UIHelper.Validation.DoNotEmptyValidation(textBox_NationalID))
                    result = false;
                if (!UIHelper.Validation.DoNotEmptyValidation(textBox_PersonnelCode))
                    result = false;
            }
            foreach(DataGridViewRow row in dataGrid_PrimaryInfo.Rows){
                if (row.IsNewRow)
                    continue;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (!UIHelper.Validation.isNonEmpty((String)cell.Value))
                    {
                        cell.ErrorText = "لطفا یک مقدار معتبر وارد کنید.";
                        result = false;
                    }
                    else if (cell.ErrorText != "")
                        result = false;
                }
            }
            foreach (DataGridView grid in new DataGridView[] { dataGrid_DefinerLabel, dataGrid_OtherLabel })
            {
                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (((Boolean)row.Cells[0].Value) && !UIHelper.Validation.isNonEmpty((String)row.Cells[2].Value))
                    {
                        row.Cells[2].ErrorText = "لطفا یک مقدار وارد کنید.";
                        result = false;
                    }
                }
            }
            return result;

        }

        private void approveClicked(object sender, EventArgs e)
        {
            if (!areFieldsValidated())
            {
                UIHelper.errorBox(this, "لطفا خطاهای ورودی را رفع کنید");
                this.DialogResult = DialogResult.None;
                return;
            }
            if (asset == null)
            {
                asset = new Asset();
                DivanDataContext.Instance.Assets.InsertOnSubmit(asset);
                DivanDataContext.Instance.SubmitChanges();
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
                AttachedFile file = new AttachedFile();
                file.Asset = asset;
                file.path = fileName;
                DivanDataContext.Instance.AttachedFiles.InsertOnSubmit(file);
            }
        }

        private void saveSubAssets()
        {
            if (!checkBox_Composite.Checked)
                return;
            asset.IsComposite = true;
            foreach(TreeNode n in treeView_subAssets.Nodes)
                asset.AddSubAsset((Asset)n.Tag);
            foreach (Asset sub in deletedSubAssets)
                asset.RemoveSubAsset(sub);
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
                    asset.LabelInstances.Add(
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

        private void dataGrid_OtherLabel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            grid.Rows[e.RowIndex].Cells[0].Value = true;
        }

        private void dataGrid_OtherLabel_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            grid.Rows[e.RowIndex].Cells[0].Value = true;
        }

        private void dataGrid_PrimaryInfo_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            if (grid.Rows[e.RowIndex].IsNewRow)
                return;
            DataGridViewRow row = grid.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells[e.ColumnIndex];
            if (!UIHelper.Validation.isNonEmpty((String)e.FormattedValue))
            {
                cell.ErrorText = "لطفا یک مقدار مشخص کنید";
                return;
            }
            cell.ErrorText = "";
            if (e.ColumnIndex == 0)
            {
                return;
            }
            String type = (String)row.Cells[1].Value;
            String value = (String)row.Cells[2].Value;

            if (!UIHelper.Validation.isNonEmpty(type)
                || !UIHelper.Validation.isNonEmpty(value))
                return;
            if (!LabelDomain.isCompatible(type, value))
                row.Cells[2].ErrorText = "لطفا یک مقدار معتبر وارد کنید";
            else
                row.Cells[2].ErrorText = "";
        }

        private void dataGrid_PrimaryInfo_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            if (grid.Rows[e.RowIndex].IsNewRow)
                return;
            DataGridViewRow row = grid.Rows[e.RowIndex];
            String type = (String)row.Cells[1].Value;
            String value = (String)row.Cells[2].Value;

            if (!UIHelper.Validation.isNonEmpty(type)
                || !UIHelper.Validation.isNonEmpty(value))
                return;
            if (!LabelDomain.isCompatible(type, value))
                row.Cells[2].ErrorText = "لطفا یک مقدار معتبر وارد کنید";
            else
                row.Cells[2].ErrorText = "";
        }

    }
}

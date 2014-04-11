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
        private string loc = "";

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
                UIHelper.Validation.ValidateNotEmpty(textBox_PersonnelCode, errorProvider);
                UIHelper.Validation.ValidateNotEmpty(textBox_LastName, errorProvider);
            }
            else
            {
                UIHelper.Validation.CancelValidateNotEmpty(textBox_FirstName);
                UIHelper.Validation.CancelValidateNotEmpty(textBox_LastName);
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
            loadConsistencyRules();
        }

        private void loadConsistencyRules()
        {
            foreach (ConsistencyRule cr in asset.ConsistencyRules)
            {
                dataGrid_consistencyRules.Rows.Add(new object[] {cr.mValue, cr.condition, cr.sValue, cr.ImportanceString });
            }
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
            {
                checkBox_Composite.Checked = false;
                GroupBox_subAssets.Visible = false;
                return;
            }
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
                if (labelInstance.Label.isSplitter)
                {
                    int index = splitterLabelId.IndexOf(id);
                    if (index == -1) // Label is invisible
                    {
                        index = dataGrid_DefinerLabel.Rows.Add(new object[] { false, labelInstance.Label.name, "", labelInstance.labelID});
                        splitterLabelId.Add(labelInstance.labelID);
                        if (!labelInstance.Label.setValue)
                            UIHelper.disableCell(dataGrid_DefinerLabel.Rows[index].Cells[2]);
                    }
                    dataGrid_DefinerLabel.Rows[index].Cells[0].Value = true;
                    dataGrid_DefinerLabel.Rows[index].Cells[2].Value = labelInstance.value;
                }
                else
                {
                    int index = otherLabelId.IndexOf(id);
                    if (index == -1) // Label is invisible
                    {
                        index = dataGrid_DefinerLabel.Rows.Add(new object[] { false, labelInstance.Label.name, "", labelInstance.labelID});
                        otherLabelId.Add(labelInstance.labelID);
                        if (!labelInstance.Label.setValue)
                            UIHelper.disableCell(dataGrid_DefinerLabel.Rows[index].Cells[2]);
                    }
                    dataGrid_OtherLabel.Rows[index].Cells[2].Value = labelInstance.value;
                    dataGrid_OtherLabel.Rows[index].Cells[0].Value = true;
                }
            }
        }

        private void loadProperties()
        {
            foreach (Property prop in asset.PrimaryInfos)
            {
                    dataGrid_PrimaryInfo.Rows.Add(new object[] { prop.Name, prop.Type, prop.Value });
            }
        }

        private void loadPrimaryFields()
        {
            textBox_Name.Text = asset.Name;
            textBox_UID.Text = asset.UID;
            checkBox_isHuman.Checked = asset.isHuman;
            if (!checkBox_isHuman.Checked)
                humanAssetProps.Visible = false;
            textBox_FirstName.Text = asset.FirstName;
            textBox_LastName.Text = asset.LastName;
            textBox_NationalID.Text = asset.NationalID;
            textBox_PersonnelCode.Text = asset.PersonnelCode;
            textBox_HumanDescription.Text = asset.HumanDescription;
            checkBox_isPhysical.Checked = asset.isPhysical;
            if (!checkBox_isPhysical.Checked)
                sensibleAssetProps.Visible = false;
            textBox_PhysicalDescription.Text = asset.PhysicalDescription;
            checkBox_isPortable.Checked = asset.isPortable;
            insuranceCmb.Text = asset.Insurance;
            insuranceTxt.Text = asset.InsuranceDescription;
            documentCmb.Text = asset.Document;
            documentTxt.Text = asset.DocumentDescription;
        }

        private void loadLabels()
        {
            IEnumerable<Label> labels = LabelList.Instance.GetAllVisibles();
            splitterLabelId = new List<int>();
            otherLabelId = new List<int>();

            foreach (Label label in labels)
            {
                DataGridView grid = label.isSplitter ? dataGrid_DefinerLabel
                    : dataGrid_OtherLabel;
                grid.Rows.Add(new object[] { false, label.name, label.setValue ? "" : Label.UNASSANABLE_VALUE, label.Id});
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
                insuranceCmb.SelectedIndex = 1;
                documentCmb.SelectedIndex = 1;
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
                if (subAsset.Parent != null && (asset==null || subAsset.Parent.Id!=asset.Id))
                {
                    UIHelper.warningBox(this, "یک دارایی نمی‌تواند در دو دارایی باشد.\n"
                        + "دارایی انتخاب شده زیردارایی " + subAsset.Parent + " است.");
                    return;
                }
                else if (asset != null && subAsset.Id == asset.Id)
                {
                    UIHelper.warningBox(this, "یک دارایی نمی‌تواند زیرداریی خودش باشد.");
                    return;
                }
                else if (asset != null && subAsset.pathExists(asset))
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
                if (!UIHelper.Validation.isNonEmpty(textBox_NationalID.Text))
                {
                    errorProvider.SetError(textBox_NationalID, "این مورد الزامی است.");
                    result = false;
                }
                else if (!UIHelper.Validation.isValidNationalID(textBox_NationalID.Text))
                {
                    errorProvider.SetError(textBox_NationalID, "لطفا یک کد ملی ده رقمی معتبر وارد کنید.");
                    result = false;
                }
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
                        cell.ErrorText = "این مورد الزامی است.";
                        result = false;
                    }
                    else if (cell.ErrorText != "")
                        result = false;
                }
            }
            if (errorProvider.GetError(dataGrid_PrimaryInfo) != "")
                result = false;
            foreach (DataGridView grid in new DataGridView[] { dataGrid_DefinerLabel, dataGrid_OtherLabel })
            {
                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (row.Cells[2].ErrorText != "")
                    {
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
                labelSearchtxt.Text = "";
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
                DivanDataContext.Instance.AttachedFiles.DeleteAllOnSubmit(asset.AttachedFiles);
                DivanDataContext.Instance.ConsistencyRules.DeleteAllOnSubmit(asset.ConsistencyRules);

                try
                {
                    var locprop = asset.Properties.Single(p => p.name == Asset.LOCATION_STRING);
                    loc = locprop.value;
                }
                catch { }
                
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

            if (!areInconsistencyFieldsValid())
            {
                UIHelper.errorBox(this, "تمام موارد جز قوانین سازگار سنجی ذخیره شد. لطفا خطا‌ها را رفع کنید.");
                labelSearchtxt.Text = "";
                this.DialogResult = DialogResult.None;
                return;
            }
            saveConsistencyRules();
        }

        private bool areInconsistencyFieldsValid()
        {
            bool result = true;
            foreach (DataGridViewRow row in dataGrid_consistencyRules.Rows)
            {
                if (row.IsNewRow)
                    continue;
                ConsistencyExpression m = row.Cells[0].Value == null ? null : ConsistencyExpression.parse(row.Cells[0].Value.ToString());
                ConsistencyExpression s = row.Cells[0].Value == null ? null : ConsistencyExpression.parse(row.Cells[2].Value.ToString());
                if (m == null)
                {
                    result = false;
                    row.Cells[0].ErrorText = "مقدار این فیلد نامعتبر است.";
                    continue;
                }
                else
                {
                    row.Cells[0].ErrorText = "";
                }
                if (s == null)
                {
                    result = false;
                    row.Cells[2].ErrorText = "مقدار این فیلد نامعتبر است.";
                    continue;
                }
                else
                {
                    row.Cells[2].ErrorText = "";
                }
                try
                {
                    bool res = (new ConsistencyRule() { mValue = row.Cells[0].Value.ToString(), sValue = row.Cells[2].Value.ToString(), condition = row.Cells[1].Value.ToString() }).Inconsistent;
                    row.Cells[1].ErrorText = "";
                }
                catch
                {
                    result = false;
                    row.Cells[1].ErrorText = "این شرط با مقادیر سازگار نیست.";
                }
            }
            return result;
        }

        private void saveConsistencyRules()
        {
            foreach (DataGridViewRow row in dataGrid_consistencyRules.Rows)
            {
                if (row.IsNewRow)
                    continue;
                ConsistencyRule rule = new ConsistencyRule();
                rule.mValue = (String)row.Cells[0].Value;
                rule.sValue = (String)row.Cells[2].Value;
                rule.condition = (String)row.Cells[1].Value;
                rule.importance = ConsistencyRule.getImportance((String)row.Cells[3].Value);
                asset.ConsistencyRules.Add(rule);
            }
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
                if ((string)dataGrid_PrimaryInfo.Rows[i].Cells[0].Value == Asset.LOCATION_STRING)
                    continue;
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
                DivanDataContext.Instance.Properties.InsertOnSubmit(new Property(Asset.INSURANCE_STRING, insuranceCmb.Text, asset));
                DivanDataContext.Instance.Properties.InsertOnSubmit(new Property(Asset.INSURANCE_DESC_STRING, insuranceTxt.Text, asset));
                DivanDataContext.Instance.Properties.InsertOnSubmit(new Property(Asset.DOCUMENT_STRING, documentCmb.Text, asset));
                DivanDataContext.Instance.Properties.InsertOnSubmit(new Property(Asset.DOCUMENT_DESC_STRING, documentTxt.Text, asset));
            }
            asset.isPortable = checkBox_isPortable.Checked;
            if (asset.isPortable)
            {
                try
                {
                    var gisr = DivanDataContext.Instance.GISRecords.Single(r => r.UID == asset.UID);
                    loc = gisr.location;
                }
                catch { }
                DivanDataContext.Instance.Properties.InsertOnSubmit(new Property(Asset.LOCATION_STRING, loc, asset));
            }

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
                row.Cells[2].ErrorText = "این مورد الزامی است.";
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

        private void dataGrid_OtherLabel_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            
        }

        private void textBox_NationalID_Validating(object sender, CancelEventArgs e)
        {
            if (!UIHelper.Validation.isNonEmpty(textBox_NationalID.Text))
                errorProvider.SetError(textBox_NationalID, "این مورد ضروری است.");
            else if (!UIHelper.Validation.isValidNationalID(textBox_NationalID.Text))
                errorProvider.SetError(textBox_NationalID, "لطفا یک کد ملی ده رقمی معتبر وارد کنید.");
            else
                errorProvider.SetError(textBox_NationalID, "");
        }

        private void dataGrid_PrimaryInfo_Validating(object sender, CancelEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            List<String> names = new List<string>();
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.Cells[0].Value != null)
                    names.Add((string)row.Cells[0].Value);
            }
            if (!UIHelper.Validation.isDisntinct(names))
            {
                errorProvider.SetError(grid, "مشخصات اولیه باید نام‌های یکتا داشته باشند.");
            }
            else
                errorProvider.SetError(grid, "");
        }

        private void dataGrid_OtherLabel_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            DataGridViewRow row = grid.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells[2];

            bool selected = (bool)row.Cells[0].Value;
            if (!selected)
            {
                cell.ErrorText = "";
                return;
            }
            Label rowLabel = LabelList.Instance.getLabelById((int)row.Cells[3].Value);
            if (!rowLabel.setValue)
                return;
            if (!UIHelper.Validation.isNonEmpty((string)cell.Value))
                cell.ErrorText = "این مورد الزامی است.";
            else if (!rowLabel.LabelDomain.IsValidValue((string)cell.Value))
                cell.ErrorText = "مقدار وارد شده در دامنه مقادیر برچسب " + rowLabel.name + " نیست.";
            else
                cell.ErrorText = "";
        }

    }
}

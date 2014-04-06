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
    public partial class NewActionWindow : Form
    {
        Asset asset;
        Label label;
        Action action;

        public NewActionWindow()
        {
            InitializeComponent();
        }

        private void removeSubAssetBut_Click(object sender, EventArgs e)
        {
            if (RemoveConfirmationBox.ShowConfirmation()==System.Windows.Forms.DialogResult.Yes)
                subActionList.Items.RemoveAt(subActionList.SelectedIndex);
        }

        private void مشاهدهمشخصاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new LabelDetailsWindow()).ShowDialog();
        }

        private void compositAsset_CheckedChanged(object sender, EventArgs e)
        {
            subAssets.Visible = compositAsset.Checked;
        }

        private void autoRunable_CheckedChanged(object sender, EventArgs e)
        {
            runTime.Visible = autoRunable.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String uid = AssetsWindow.ShowAssets();
            if (uid == null)
                return;
            asset = AssetList.Instance.GetByUid(uid);
            label = null;
            label_asset.Text = "دارایی: " + asset.Name;
            label_label.Text = "برچسب: " + asset.Name + " > انتخاب کنید";
            button_selectLabel.Enabled = true;
            textBox_value.Enabled = false;
            textBox_value.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label = LabelsWindow.ShowLabels(asset, true);
            if (label == null)
                return;
            LabelInstance labelInstance = asset.getLabelInstance(label);
            label_label.Text = "برچسب: " + asset.Name + " > " + label.name;
            textBox_value.Text = labelInstance.value;
            textBox_value.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Action a = ActionsWindow.ShowActions();
            if(a!=null){
                subActionList.Items.Add(a);
            }
        }

        private void subActionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeSubAssetBut.Enabled = subActionList.SelectedItem != null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button_selectAsset_Validating(null, null);
            button_selectLabel_Validating(null, null);

            if (errorProvider.GetError(button_selectLabel) != "" ||
                errorProvider.GetError(button_selectAsset) != "" ||
                errorProvider.GetError(textBox_value) != "" ||
                errorProvider.GetError(nameTxt) != "")
            {
                UIHelper.errorBox(this, "لطفا خطاهای ورودی را رفع کنید");
                this.DialogResult = System.Windows.Forms.DialogResult.None;
                return;
            }

            action = new Action();
            action.name = nameTxt.Text;
            action.Label = label;
            action.Asset = asset;
            action.value = textBox_value.Text;
            action.needsAutoRun = autoRunable.Checked;
            action.autoRunPeriod = Convert.ToInt32(textBox_period.Text);

            DivanDataContext.Instance.Actions.InsertOnSubmit(action);

            if (compositAsset.Checked)
            {
                for (int i = 0; i < subActionList.Items.Count; i++)
                {
                    Action item = (Action)subActionList.Items[i];
                    SubAction subAction = new SubAction();
                    subAction.Parent = action;
                    subAction.Child = item;
                    DivanDataContext.Instance.SubActions.InsertOnSubmit(subAction);
                }
            }
            DivanDataContext.Instance.SubmitChanges();
        }

        private void NewActionWindow_Load(object sender, EventArgs e)
        {
            UIHelper.Validation.ValidateNotEmpty(nameTxt, errorProvider);
            UIHelper.Validation.ValidateNotEmpty(textBox_value, errorProvider);
        }

        private void button_selectAsset_Validating(object sender, CancelEventArgs e)
        {
            if (asset == null)
            {
                errorProvider.SetError(button_selectAsset, "انتخاب دارایی اجباری است.");
            }
            else
            {
                errorProvider.SetError(button_selectAsset, "");
            }
        }

        private void button_selectLabel_Validating(object sender, CancelEventArgs e)
        {
            if (label == null)
            {
                errorProvider.SetError(button_selectLabel, "انتخاب برچسب اجباری است.");
            }
            else
            {
                errorProvider.SetError(button_selectLabel, "");
            }
        }

        private void textBox_value_Validated(object sender, EventArgs e)
        {
            if (!UIHelper.Validation.isNonEmpty(textBox_value.Text))
                return; // Error already provided in validating
            if (!label.LabelDomain.IsValidValue(textBox_value.Text))
                errorProvider.SetError(textBox_value, "مقدار وارد شده در دامنه مقادیر برچسب " + label.name + " نیست.");
            else
                errorProvider.SetError(textBox_value, "");
        }
    }
}

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
    public partial class NewActionWindow : Form
    {
        Asset asset;
        LabelInstance labelInstance;

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
            label_asset.Text = "دارایی: " + asset.Name;
            label_label.Text = "برچسب: " + asset.Name + " > انتخاب کنید";
            button_selectLabel.Enabled = true;
            textBox_value.Enabled = false;
            textBox_value.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Label result = LabelsWindow.ShowLabels(asset);
            if (result != null)
                labelInstance = asset.getLabelInstance(result);
            label_label.Text = "برچسب: " + asset.Name + " > " + result.name;
            textBox_value.Text = labelInstance.value;
            textBox_value.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = ActionsWindow.ShowActions();
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

        }
    }
}

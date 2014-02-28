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
            AssetsWindow.ShowAssets();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LabelsWindow.ShowLabels();
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
    }
}

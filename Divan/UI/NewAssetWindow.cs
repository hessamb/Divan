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
        public NewAssetWindow()
        {
            InitializeComponent();
        }

        private void humanAssetCh_CheckedChanged(object sender, EventArgs e)
        {
            humanAssetProps.Visible = humanAssetCh.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            sensibleAssetProps.Visible = sensibleAssetCh.Checked;
        }

        private void NewAsset_Load(object sender, EventArgs e)
        {
            UIHelper.SetPlaceHolder(labelSearchtxt,"جستجوی برچسب");
            subAssetsTree.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            removeSubAssetBut.Enabled = subAssetsTree.Focused && subAssetsTree.SelectedNode != null;
        }

        private void subAssetsTree_Leave(object sender, EventArgs e)
        {
            removeSubAssetBut.Enabled = subAssetsTree.Focused && subAssetsTree.SelectedNode != null;
        }

        private void removeSubAssetBut_Click(object sender, EventArgs e)
        {
            if (RemoveConfirmationBox.ShowConfirmation()==System.Windows.Forms.DialogResult.Yes)
                subAssetsTree.SelectedNode.Remove();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void compositAsset_CheckedChanged(object sender, EventArgs e)
        {
            subAssets.Visible = compositAsset.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ns=AssetsWindow.ShowAssets();
            if (ns != null)
            {
                subAssetsTree.Nodes.Add(ns);
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


    }
}

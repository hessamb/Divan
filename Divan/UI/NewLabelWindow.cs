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
    public partial class NewLabelWindow : Form
    {
        public NewLabelWindow()
        {
            InitializeComponent();
        }

        private void NewAsset_Load(object sender, EventArgs e)
        {
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
            if (RemoveConfirmationBox.ShowConfirmation()==System.Windows.Forms.DialogResult.OK)
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
            string ns=LabelsWindow.ShowLabels();
            if (ns != null)
            {
                subAssetsTree.Nodes.Add(ns);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            distictProps.Visible = !distinctOpt.Checked;
            continiousProps.Visible = distinctOpt.Checked;
        }

        private void orderedValues_CheckedChanged(object sender, EventArgs e)
        {
            domainGrid.Columns[0].Visible = orderedValues.Checked;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            domainGroup.Visible = valueableOpt.Checked;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            (new PlugInCodeWindow()).ShowDialog();
        }

        private void autoChangableCh_CheckedChanged(object sender, EventArgs e)
        {
            AutoChangableProps.Visible = autoChangableCh.Checked;
        }

    }
}

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
    public partial class EditLabelWindow : Form
    {
        public EditLabelWindow()
        {
            InitializeComponent();
        }

        private void NewAsset_Load(object sender, EventArgs e)
        {
            domainGrid.Rows.Add(new object[] { "۱", "بد" });
            domainGrid.Rows.Add(new object[] { "۲", "متوسط" });
            domainGrid.Rows.Add(new object[] { "۳", "خوب" });

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

        private void button1_Click(object sender, EventArgs e)
        {
            string ns=LabelsWindow.ShowLabels();
            if (ns != null)
            {
                subAssetsTree.Nodes.Add(ns);
            }
        }

        private void مشاهدهمشخصاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new LabelDetailsWindow()).ShowDialog();
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

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
    public partial class ChangeStateWindow : Form
    {
        public ChangeStateWindow()
        {
            InitializeComponent();
        }

        private void NewAsset_Load(object sender, EventArgs e)
        {
            propsGrid.Rows.Add(new object[] { "مشخصه", "azdst1" });
            propsGrid.Rows.Add(new object[] { "نام", "خیابان آزادی" });
            propsGrid.Rows.Add(new object[] { "مرکب", "بلی" });
            propsGrid.Rows.Add(new object[] { "انسانی", "خیر" });
            propsGrid.Rows.Add(new object[] { "ملموس", "بلی" });
            propsGrid.Rows.Add(new object[] { "متغییر در زمان", "خیر" });
            propsGrid.Rows.Add(new object[] { "مکان‌مند", "خیر" });
            propsGrid.Rows.Add(new object[] { "عرض", "20m" });
            propsGrid.Rows.Add(new object[] { "طول", "4km" });

            labelsTree.ExpandAll();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            (new EditAssetWindow()).ShowDialog();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (RemoveConfirmationBox.ShowConfirmation() == System.Windows.Forms.DialogResult.Yes)
                DialogResult = System.Windows.Forms.DialogResult.Yes;
        }

        private void history_Click(object sender, EventArgs e)
        {
            (new AssetHistoryWindow()).ShowDialog();
        }

        private void subAssetsTree_DoubleClick(object sender, EventArgs e)
        {
            (new AssetDetailsWindow()).ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void مشاهدهمشخصاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            subAssetsTree_DoubleClick(null, null);
        }

        private void labelsTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string[] s =labelsTree.SelectedNode.Text.Split(':');
            labelLbl.Text = s[0]+":";
            valueTxt.Text = s[1];
        }
    }
}

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
        Asset selectedAsset;
        public ChangeStateWindow()
        {
            InitializeComponent();
        }

        public ChangeStateWindow(Asset selectedAsset)
            : this()
        {
            this.selectedAsset = selectedAsset;
        }

        private void fillPrimaryInfoGrid()
        {
            dataGrid_primaryInfo.Rows.Add(new object[] { "شناسه", selectedAsset.UID });
            dataGrid_primaryInfo.Rows.Add(new object[] { "نام", selectedAsset.Name });
            if (selectedAsset.isHuman)
            {
                dataGrid_primaryInfo.Rows.Add(new object[] { "نام کوچک", selectedAsset.FirstName });
                dataGrid_primaryInfo.Rows.Add(new object[] { "نام خانوادگی", selectedAsset.LastName });
                dataGrid_primaryInfo.Rows.Add(new object[] { "کد ملی", selectedAsset.NationalID });
                dataGrid_primaryInfo.Rows.Add(new object[] { "کد پرسنلی", selectedAsset.PersonnelCode });
                dataGrid_primaryInfo.Rows.Add(new object[] { "توضیحات انسانی", selectedAsset.HumanDescription });
            }
            if (selectedAsset.isPhysical)
            {
                dataGrid_primaryInfo.Rows.Add(new object[] { "مشخصات ظاهری", selectedAsset.PhysicalDescription });
            }

            foreach (Property prop in selectedAsset.Properties)
            {
                if (!Asset.SPECIAL_NAMES.Contains(prop.name))
                {
                    dataGrid_primaryInfo.Rows.Add(new object[] { prop.name, prop.value });
                }
            }
        }

        private void NewAsset_Load(object sender, EventArgs e)
        {
            fillPrimaryInfoGrid();
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

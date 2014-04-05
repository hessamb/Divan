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
        List<int> labelId;

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

        private void loadLabelInstances()
        {
            IEnumerable<LabelInstance> labels = selectedAsset.LabelInstances;
            labelId = new List<int>();

            foreach (LabelInstance label in labels)
            {
                DataGridView grid = dataGrid_Label;
                int index = grid.Rows.Add(new object[] { label.Label.name, label.Label.setValue ? label.value : Label.UNASSANABLE_VALUE });
                if (!label.Label.setValue)
                {
                    UIHelper.disableCell(grid.Rows[index].Cells[1]);
                }
                labelId.Add(label.Id);
            }
        }

        private void NewAsset_Load(object sender, EventArgs e)
        {
            UIHelper.SetPlaceHolder(labelSearchText, "جستجوی برچسب");
            fillPrimaryInfoGrid();
            loadLabelInstances();
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
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < labelId.Count; i++)
            {
                int id = labelId[i];
                var labelInstance = from label in DivanDataContext.Instance.LabelInstances
                                    where label.Id == id
                                    select label;
                try
                {
                    LabelInstance row = labelInstance.First();
                    row.value = (string)dataGrid_Label.Rows[i].Cells[1].Value;
                }
                catch
                {
                }
            }
            DivanDataContext.Instance.SubmitChanges();
        }


        private void labelSearchText_TextChanged(object sender, EventArgs e)
        {
            if (!labelSearchText.WordWrap) // It's not place holder
                UIHelper.searchGrid(dataGrid_Label, labelSearchText.Text);
        }
    }
}

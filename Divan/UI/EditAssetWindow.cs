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
    public partial class EditAssetWindow : Form
    {
        Asset asset;
        public EditAssetWindow()
        {
            InitializeComponent();
        }

        public EditAssetWindow(Asset asset) : this()
        {
            this.asset = asset;
        }

        private void NewAsset_Load(object sender, EventArgs e)
        {
            textBox_Name.Text = asset.Name;
            textBox_UID.Text = asset.UID;
            checkBox_isHuman.Checked = asset.isHuman;
            textBox_FirstName.Text = asset.FirstName;
            textBox_LastName.Text = asset.LastName;
            textBox_NationalID.Text = asset.NationalID;
            textBox_PersonnelCode.Text = asset.PersonnelCode;
            textBox_HumanDescription.Text = asset.HumanDescription;
            checkBox_isPhysical.Checked = asset.isPhysical;
            textBox_PhysicalDescription.Text = asset.PhysicalDescription;
            checkBox_isPortable.Checked = asset.isPortable;

            foreach (Property prop in asset.Properties)
            {
                if (!Asset.SPECIAL_NAMES.Contains(prop.name))
                {
                    dataGrid_PrimaryInfo.Rows.Add(new object[] { prop.name, prop.type, prop.value });
                }
            }

            checkBox_Composite.Checked = asset.isComposite();
            foreach (Asset a in this.asset.getSubAssets())
            {
                treeView_subAssets.Nodes.Add( a.getTreeNode() );
            }

            foreach(AttachedFile file in asset.AttachedFiles)
            {
                attachmentList.Items.Add(file.path);
            }
        }

        private void checkBox_isPhysical_CheckedChanged(object sender, EventArgs e)
        {
            sensibleAssetProps.Visible = checkBox_isPhysical.Checked;
        }

        private void checkBox_isHuman_CheckedChanged(object sender, EventArgs e)
        {
            humanAssetProps.Visible = checkBox_isHuman.Checked;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DivanDataContext.Instance.Properties.DeleteAllOnSubmit(asset.Properties);
            asset.Properties.Clear();
            DivanDataContext.Instance.SubmitChanges();

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
            }
            asset.isPortable = checkBox_isPortable.Checked;

            for (int i = 0; i < dataGrid_PrimaryInfo.RowCount - 1; i++)
            {
                DivanDataContext.Instance.Properties.InsertOnSubmit(new Property((string)dataGrid_PrimaryInfo.Rows[i].Cells[0].Value, (string)dataGrid_PrimaryInfo.Rows[i].Cells[2].Value, asset, (string)dataGrid_PrimaryInfo.Rows[i].Cells[1].Value));
            }

            foreach (String fileName in attachmentList.Items)
            {
                // TODO: attached files need to be uploaded.
                AttachedFile file = new AttachedFile();
                file.Asset = asset;
                file.path = fileName;
                DivanDataContext.Instance.AttachedFiles.InsertOnSubmit(file);
            }

            DivanDataContext.Instance.SubmitChanges();
        }

    }
}

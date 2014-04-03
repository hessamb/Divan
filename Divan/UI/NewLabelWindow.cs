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
        Label label;
        public NewLabelWindow()
        {
            InitializeComponent();
        }

        public NewLabelWindow(Label label): this()
        {
            this.Text = "ویرایش برچسب";
            this.label = label;
        }

        private void NewAsset_Load(object sender, EventArgs e)
        {
            if (label != null)
            {
                nameTxt.Text = label.name;
                valueableOpt.Checked = label.setValue;
                discreteRadio.Checked = label.LabelDomain.isDiscrete();
                if (discreteRadio.Checked)
                {
                    IEnumerable<DiscreteDomainValue> values = label.LabelDomain.DiscreteDomainValues
                        .OrderBy((DiscreteDomainValue value) => value.rank).AsEnumerable();
                    foreach (DiscreteDomainValue value in values)
                    {
                        domainGrid.Rows.Add(value.value);
                    }
                    ordinalValues.Checked = label.LabelDomain.isOrdered ?? false;
                }
                else
                {
                    textBox_minValue.Text = Convert.ToString(label.LabelDomain.minValue);
                    textBox_maxValue.Text = Convert.ToString(label.LabelDomain.maxValue);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            distictProps.Visible = !discreteRadio.Checked;
            continiousProps.Visible = discreteRadio.Checked;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            domainGroup.Visible = valueableOpt.Checked;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            (new PlugInCodeWindow()).ShowDialog();
        }

        private void orderedValues_CheckedChanged(object sender, EventArgs e)
        {
            domainGrid.Columns["MoveUp"].Visible = ordinalValues.Checked;
            domainGrid.Columns["MoveDown"].Visible = ordinalValues.Checked;
        }

        private void domainGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == 1 && e.RowIndex>0)
            {
                string tmp = (string)domainGrid.Rows[e.RowIndex - 1].Cells[0].Value;
                domainGrid.Rows[e.RowIndex - 1].Cells[0].Value = domainGrid.Rows[e.RowIndex].Cells[0].Value;
                domainGrid.Rows[e.RowIndex].Cells[0].Value = tmp;
            }
            else if (e.ColumnIndex == 2 && e.RowIndex < domainGrid.RowCount - 2)
            {
                string tmp = (string)domainGrid.Rows[e.RowIndex + 1].Cells[0].Value;
                domainGrid.Rows[e.RowIndex + 1].Cells[0].Value = domainGrid.Rows[e.RowIndex].Cells[0].Value;
                domainGrid.Rows[e.RowIndex].Cells[0].Value = tmp;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label != null)
            {
                DivanDataContext.Instance.DiscreteDomainValues.DeleteAllOnSubmit(label.LabelDomain.DiscreteDomainValues);
                DivanDataContext.Instance.LabelDomains.DeleteOnSubmit(label.LabelDomain);
            }
            if (unvalueableRadio.Checked)
            {
                if (label == null)
                    label = new Label();

                label.name = nameTxt.Text;
                label.setValue = false;
                label.isSplitter = checkBox_splitter.Checked;
                label.LabelDomain = null;

                string name = label.name;
                DivanDataContext.Instance.Labels.InsertOnSubmit(label);
            }
            else if (!discreteRadio.Checked)
            {
                LabelDomain domain = new LabelDomain(Convert.ToDouble(textBox_minValue.Text),
                    Convert.ToDouble(textBox_maxValue.Text), null);
                DivanDataContext.Instance.LabelDomains.InsertOnSubmit(domain);
                if (label == null)
                    label = new Label();
                label.name = nameTxt.Text;
                label.setValue = true;
                label.isSplitter = checkBox_splitter.Checked;
                label.LabelDomain = domain;
                DivanDataContext.Instance.Labels.InsertOnSubmit(label);
            }
            else
            {
                LabelDomain domain = new LabelDomain(null, null, ordinalValues.Checked);
                for (int i = 0; i < domainGrid.Rows.Count-1 ; i++)
                {
                    DataGridViewRow row = domainGrid.Rows[i];
                    DiscreteDomainValue value = new DiscreteDomainValue();
                    value.LabelDomain = domain;
                    value.rank = i;
                    value.value = (string)row.Cells[0].Value ?? "";
                    DivanDataContext.Instance.DiscreteDomainValues.InsertOnSubmit(value);
                }
                DivanDataContext.Instance.LabelDomains.InsertOnSubmit(domain);
                if (label == null)
                    label = new Label();
                label.name = nameTxt.Text;
                label.setValue = true;
                label.isSplitter = checkBox_splitter.Checked;
                label.LabelDomain = domain;
                DivanDataContext.Instance.Labels.InsertOnSubmit(label);
            }

            DivanDataContext.Instance.SubmitChanges();
        }

    }
}

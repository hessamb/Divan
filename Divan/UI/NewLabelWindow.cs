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

        private bool areFieldsValidated()
        {
            if (error.GetError(nameTxt) != "")
            {
                return false;
            }
            Label label = LabelList.Instance.labelByName(nameTxt.Text);
            if (label != null)
            {
                if (this.label == null || this.label.Id != label.Id) // If editing, previous name is allowed.
                {
                    error.SetError(nameTxt, "نام برچسب تکراری است");
                    return false;
                }
            }
            if (valueableOpt.Checked && continuousRadio.Checked)
            {
                if (error.GetError(textBox_minValue) != ""
                    || error.GetError(textBox_maxValue) != "")
                    return false;
            }
            if (valueableOpt.Checked && discreteRadio.Checked)
            {
                if (error.GetError(domainGrid) != "")
                    return false;
                foreach (DataGridViewRow row in domainGrid.Rows)
                {
                    if (!row.IsNewRow && !UIHelper.Validation.isNonEmpty((String)row.Cells["name"].Value))
                        return false;
                }
            }
            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!areFieldsValidated())
            {
                UIHelper.errorBox(this, "لطفا خطاهای ورودی را رفع کنید");
                this.DialogResult = DialogResult.None;
                return;
            }
            if (label != null)
            {
                DivanDataContext.Instance.DiscreteDomainValues.DeleteAllOnSubmit(label.LabelDomain.DiscreteDomainValues);
                DivanDataContext.Instance.LabelDomains.DeleteOnSubmit(label.LabelDomain);
                DivanDataContext.Instance.SubmitChanges();
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
                LabelDomain domain = new LabelDomain(float.Parse(textBox_minValue.Text),
                    float.Parse(textBox_maxValue.Text), null);
                DivanDataContext.Instance.LabelDomains.InsertOnSubmit(domain);
                DivanDataContext.Instance.SubmitChanges();
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
                DivanDataContext.Instance.SubmitChanges();
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

        private void nameTxt_Validating(object sender, CancelEventArgs e)
        {
            if (!UIHelper.Validation.isNonEmpty(nameTxt.Text))
            {
                error.SetError(nameTxt, "لطفا نام برچسب را مشخص کنید.");
            }
            else
            {
                error.SetError(nameTxt, "");
            }
        }

        private void domainGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            DataGridViewCell cell = grid.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (grid.Rows[e.RowIndex].IsNewRow)
                return;
            if (!UIHelper.Validation.isNonEmpty((String)e.FormattedValue))
            {
                cell.ErrorText = "لطفا یک مقدار معتبر برای دامنه وارد کنید.";
            }
            else
            {
                cell.ErrorText = "";
            }
        }

        private void textBox_minValue_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!UIHelper.Validation.isDouble(textBox.Text))
            {
                error.SetError(textBox, "لطفا یک مقدار اعشاری معتبر وارد کنید.");
            }
            else
            {
                error.SetError(textBox, "");
            }
        }

        private void domainGrid_Validating(object sender, CancelEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            List<String> list = new List<String>();
            foreach (DataGridViewRow row in grid.Rows)
            {
                list.Add((String)row.Cells["name"].Value);
            }

            if (!UIHelper.Validation.isDisntinct(list))
            {
                error.SetError(grid, "مقادیر دامنه باید یکتا باشند.");
            }
            else
            {
                error.SetError(grid, "");
            }
        }

    }
}

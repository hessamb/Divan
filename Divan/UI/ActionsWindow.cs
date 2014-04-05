﻿using System;
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
    public partial class ActionsWindow : Form
    {
        public Action SelectedAction { get; set; }
        public static Action ShowActions()
        {
            ActionsWindow a = new ActionsWindow();
            a.select.Visible = a.cancel.Visible = a.cancel.Enabled = true;
            a.delete.Visible = a.runBut.Visible = false;
            a.actionsGrid.DoubleClick -= a.assetsGrid_DoubleClick;
            a.actionsGrid.DoubleClick += a.select_Click;
            if (a.ShowDialog() == DialogResult.OK)
            {
                return a.SelectedAction;
            }
            return null;
        }

        public ActionsWindow()
        {
            InitializeComponent();
        }

        private void assetsTree_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void assetForm_Load(object sender, EventArgs e)
        {
            UIHelper.SetPlaceHolder(searchTxt, "جستجوی عملیات");
            actionsGrid.AutoGenerateColumns = false;
            reloadActions();
        }

        private void reloadActions()
        {
            actionsGrid.DataSource = ActionList.Instance.GetAll();
            actionsGrid.Refresh();
        }

        private void assetsGrid_SelectionChanged(object sender, EventArgs e)
        {
            bool selected = actionsGrid.SelectedCells.Count > 0;
            delete.Enabled = runBut.Enabled = selected;
            if (select.Visible)
                select.Enabled = selected;
        }

        private void select_Click(object sender, EventArgs e)
        {
            SelectedAction = actionsGrid.SelectedRows[0].DataBoundItem as Action;
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void edit_Click_1(object sender, EventArgs e)
        {
            (new EditLabelWindow()).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new NewActionWindow()).ShowDialog();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < actionsGrid.SelectedCells.Count; i++)
                set.Add(actionsGrid.SelectedCells[i].RowIndex);
            int cnt = set.Count;
            string message = "";
            if (cnt > 1)
            {
                message = "آیا از حذف " + cnt + " عملیات انتخاب شده مطمئنید؟";
            }
            else if (cnt == 1)
            {
                string name = (string)actionsGrid.SelectedCells[0].OwningRow.Cells[0].Value;
                message = "آیا از حذف عملیات «" + name + "» مطمئنید؟";
            }
            RemoveConfirmationBox.ShowConfirmation(message);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("عملیات با موفقیت اجرا شد.");
        }

        private void assetsGrid_DoubleClick(object sender, EventArgs e)
        {
            button1_Click(null, null);
        }
    }
}

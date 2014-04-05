using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
 
using System.Windows.Forms;

namespace Divan
{
    public partial class EventsWindow : Form
    {
        public string SelectedAction { get; set; }
        public static string ShowEvents()
        {
            EventsWindow a = new EventsWindow();
            a.select.Visible = a.cancel.Visible = a.cancel.Enabled = true;
            a.delete.Visible = a.runBut.Visible = false;
            a.eventsGrid.DoubleClick -= a.assetsGrid_DoubleClick;
            a.eventsGrid.DoubleClick += a.select_Click;
            if (a.ShowDialog() == DialogResult.OK)
            {
                return a.SelectedAction;
            }
            return null;
        }

        public EventsWindow()
        {
            InitializeComponent();
        }

        private void assetsTree_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void assetForm_Load(object sender, EventArgs e)
        {
            UIHelper.SetPlaceHolder(searchTxt, "جستجوی رخداد");
            eventsGrid.AutoGenerateColumns = false;
            reloadEvents();
        }

        private void reloadEvents()
        {
            eventsGrid.DataSource = EventList.Instance.GetAll();
            eventsGrid.Refresh();
        }

        private void assetsGrid_SelectionChanged(object sender, EventArgs e)
        {
            bool selected = eventsGrid.SelectedCells.Count > 0;
            delete.Enabled = runBut.Enabled = selected;
            if (select.Visible)
                select.Enabled = selected;
        }

        private void select_Click(object sender, EventArgs e)
        {
            SelectedAction = (string)eventsGrid.SelectedCells[0].OwningRow.Cells[0].Value;
           DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void edit_Click_1(object sender, EventArgs e)
        {
            (new EditLabelWindow()).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new NewEventWindow()).ShowDialog();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < eventsGrid.SelectedCells.Count; i++)
                set.Add(eventsGrid.SelectedCells[i].RowIndex);
            int cnt = set.Count;
            string message = "";
            if (cnt > 1)
            {
                message = "آیا از حذف " + cnt + " رخداد انتخاب شده مطمئنید؟";
            }
            else if (cnt == 1)
            {
                string name = (string)eventsGrid.SelectedCells[0].OwningRow.Cells[0].Value;
                message = "آیا از حذف رخداد «" + name + "» مطمئنید؟";
            }
            if (RemoveConfirmationBox.ShowConfirmation(message) == System.Windows.Forms.DialogResult.Yes)
            {
                foreach (DataGridViewRow r in eventsGrid.SelectedRows)
                {
                    DivanDataContext.Instance.Events.DeleteOnSubmit(r.DataBoundItem as Event);
                }
                DivanDataContext.Instance.SubmitChanges();
                reloadEvents();
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Event ev = eventsGrid.SelectedRows[0].DataBoundItem as Event;
            ev.RunAction();
            MessageBox.Show("عملیات مربوط به این رخداد با موفقیت اجرا شد.");
        }

        private void assetsGrid_DoubleClick(object sender, EventArgs e)
        {
            button1_Click(null, null);
        }
    }
}

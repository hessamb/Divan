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
    public partial class NewEventWindow : Form
    {
        Action selectedAction;

        public NewEventWindow()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var action = ActionsWindow.ShowActions();
            if (action != null)
            {
                selectedAction = action;
                actionLabel.Text = "عملیات: " + action.name;
            }
            button2_Validating(sender, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2_Validating(sender, null);
            nameTxt_Validating(sender, null);

            if (errorProvider.GetError(button2) != "" || errorProvider.GetError(nameTxt) != "")
            {
                UIHelper.errorBox(this, "لطفا خطاها را رفع کنید.");
                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
            else
            {
                Event ev = new Event();
                ev.Action = selectedAction;
                ev.Name = nameTxt.Text;
                DivanDataContext.Instance.Events.InsertOnSubmit(ev);
                DivanDataContext.Instance.SubmitChanges();
            }
        }

        private void nameTxt_Validating(object sender, CancelEventArgs e)
        {
            if (!NameIsValid())
                errorProvider.SetError(nameTxt, "نام رخداد اجباری است.");
            else
                errorProvider.SetError(nameTxt, "");
        }

        private bool ActionIsValid()
        {
            return selectedAction != null;
        }

        private bool NameIsValid()
        {
            return UIHelper.Validation.isNonEmpty(nameTxt.Text);
        }

        private void button2_Validating(object sender, CancelEventArgs e)
        {
            if (!ActionIsValid())
                errorProvider.SetError(button2, "انتخاب عملیات اجباری است.");
            else
                errorProvider.SetError(button2, "");
        }
    }
}

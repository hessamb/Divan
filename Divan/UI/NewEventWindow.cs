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
        }
    }
}

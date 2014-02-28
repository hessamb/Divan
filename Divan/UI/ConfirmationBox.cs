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
    public partial class ConfirmationBox : Form
    {
        public static DialogResult ShowConfirmation(string message, string action)
        {
            return (new ConfirmationBox()).ShowDialog(message, action);
        }

        public DialogResult ShowDialog(string text, string action)
        {
            this.textLbl.Text = text;
            this.Size = new Size(this.flowPanel.Size.Width + 24, this.flowPanel.Height + 24);
            this.action.Text = action;
            return this.ShowDialog();
        }

        public ConfirmationBox()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
        }

        private void RemoveConfirmation_Load(object sender, EventArgs e)
        {
            this.Location = new Point(MousePosition.X - this.Width / 2, MousePosition.Y - this.Height / 2);
        }
    }
}

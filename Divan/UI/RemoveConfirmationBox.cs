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
    public partial class RemoveConfirmationBox : Form
    {
        public static DialogResult ShowConfirmation(String message)
        {
            return (new RemoveConfirmationBox()).ShowDialog(message);
        }
        public static DialogResult ShowConfirmation()
        {
            return (new RemoveConfirmationBox()).ShowDialog();
        }

        public DialogResult ShowDialog(String text)
        {
            this.textLbl.Text = text;
            this.Size = new Size(this.flowPanel.Size.Width + 24, this.flowPanel.Height + 24);
            return this.ShowDialog();
        }

        public RemoveConfirmationBox()
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

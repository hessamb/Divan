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
    public partial class NewBaselineWindow : Form
    {
        public NewBaselineWindow()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DivanDataContext.BackupDatabase(nameTxt.Text+".dbb");
            MessageBox.Show("پیکر بندی فعلی سامانه به عنوان یک نقطه‌ی مبنا ثبت شد.");
        }

    }
}

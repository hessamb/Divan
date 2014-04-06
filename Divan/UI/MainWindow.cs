using Divan.UI;
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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new NewAssetWindow()).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new AssetsWindow()).ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            (new NewLabelWindow()).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new LabelsWindow()).ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            String uid;
            if ((uid = AssetsWindow.ShowAssets()) != null)
            {
                (new ChangeStateWindow(AssetList.Instance.GetByUid(uid))).ShowDialog();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            (new NewActionWindow()).ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Action a = ActionsWindow.ShowActions();
            if (a != null)
            {
                a.Run();
                MessageBox.Show("عملیات " + a + " با موفقیت اجرا شد.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            (new ActionsWindow()).ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            (new NewEventWindow()).ShowDialog();
        }

        private void button9_Click(object sender, EventArgs eventArg)
        {
            Event e=Divan.EventsWindow.ShowEvents();
            if (e != null)
            {
                e.RunAction();
                MessageBox.Show("عملیات مربوط به رویداد " + e + " با موفقیت اجرا شد.");
            }
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            (new EventsWindow()).ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            (new NewBaselineWindow()).ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string a = BaselinesWindow.Show‌Baselines();
            if (a != null)
            {
                MessageBox.Show("پیکربندی سامانه به نقطه‌ي مبنای "+a+" بازگشت");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            (new ReportAsset()).Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            (new ReportLabelWindow()).Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            (new ReportActionWindow()).Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            (new ReportInconsistencies()).Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            (new SettingsWindow()).ShowDialog();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

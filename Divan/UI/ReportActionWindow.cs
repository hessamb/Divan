using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Divan
{
    public partial class ReportActionWindow : Form
    {
        public ReportActionWindow()
        {
            InitializeComponent();
        }

        private void subAssets_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ns = ActionsWindow.ShowActions();
            if (ns != null)
            {
                assetLabel.Text = ns;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ReportAsset_Load(object sender, EventArgs e)
        {
            chart.Series[0].ChartType = SeriesChartType.Line;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (chartPeriod.SelectedIndex)
            {
                case 0:
                    loadDaily();
                    break;
                case 1:
                    loadWeekly();
                    break;
                case 2:
                    loadMonthly();
                    break;
                case 3:
                    loadYearly();
                    break;
            }
        }

        private void ReportAsset_Load_1(object sender, EventArgs e)
        {
            propsGrid.Rows.Add(new object[] { "۲ تیر ۱۳۹۲ ۱۰:۰۰", "تغییر کیفیت چراغ راهنمایی چهارراه بهبودی از عالی به متوسط" });
            propsGrid.Rows.Add(new object[] { "۲ تیر ۱۳۹۲ ۱۰:۰۰", "تغییر کیفیت پل عابر چهارراه بهبودی از عالی به متوسط" });
            propsGrid.Rows.Add(new object[] { "۲ تیر ۱۳۹۲ ۱۰:۰۰", "تغییر کیفیت چهارراه بهبودی از عالی به متوسط" });
            propsGrid.Rows.Add(new object[] { "۲ تیر ۱۳۹۲ ۱۰:۰۱", "تغییر کیفیت خیابان آزادی از عالی به متوسط" });
            instrTree.ExpandAll();
            chartPeriod.SelectedIndex = 0;
            loadDaily();
        }

        private void loadDaily()
        {
            chart.ChartAreas[0].AxisX.Title = "روز";
            loadChart(1, 30, 4, 10);
        }

        private void loadWeekly()
        {
            chart.ChartAreas[0].AxisX.Title = "هفته";
            loadChart(1, 52, 1, 30);
        }

        private void loadMonthly()
        {
            chart.ChartAreas[0].AxisX.Title = "ماه";
            loadChart(1, 12, 1, 120);
        }

        private void loadYearly()
        {
            chart.ChartAreas[0].AxisX.Title = "سال";
            loadChart(1389, 4, 1, 1440);
        }
        private void loadChart(int start, int pp, int prob, int maxi)
        {
            Random r = new Random();
            for (int i = 0; i < 1; i++)
            {
                chart.Series[i].Points.Clear();
                for (int j = 0; j < pp; j++)
                    if (r.Next(prob) == 0)
                        chart.Series[i].Points.Add(new DataPoint(j + start, r.Next(maxi)));
                    else
                        chart.Series[i].Points.Add(new DataPoint(j + start, 0));
            }
        }
    }
}

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
    public partial class ReportPeriod : Form
    {
        public ReportPeriod()
        {
            InitializeComponent();
        }

        private void subAssets_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void combo(object sender, EventArgs e, Chart chart, int num, ComboBox comboBox)
        {
            switch (comboBox.SelectedIndex)
            {
                case 0:
                    loadDaily(chart, num);
                    break;
                case 1:
                    loadWeekly(chart, num);
                    break;
                case 2:
                    loadMonthly(chart, num);
                    break;
                case 3:
                    loadYearly(chart, num);
                    break;
            }
        }

        private void ReportAsset_Load_1(object sender, EventArgs e)
        {
            propsGridAsset.Rows.Add(new object[] { "۲ تیر ۱۳۹۲", "میدان", "ایجاد برچسب" });
            propsGridAsset.Rows.Add(new object[] { "۲ تیر ۱۳۹۲", "میدان آزادی", "ایجاد دارایی" });
            propsGridAsset.Rows.Add(new object[] { "۳ تیر ۱۳۹۲", "میدان آزادی", "تغییر وضعیت به عالی" });



            propsGridAsset.Rows.Add(new object[] { "۱۵ مرداد ۱۳۹۲", "میدان", "اضافه کردن دامنه تغییر جدید" });
            propsGridAsset.Rows.Add(new object[] { "۱۵ مرداد ۱۳۹۲", "میدان آزادی", "اضافه کردن یک مشخصه‌ی جدید" });
            propsGridAsset.Rows.Add(new object[] { "۲۰ شهریور ۱۳۹۲", "میدان", "اضافه کردن دامنه تغییر جدید" });


            propsGridAsset.Rows.Add(new object[] { "۲۰ شهریور ۱۳۹۲", "میدان آزادی", "فرسوده شدن دارایی. تغییر وضعیت به متوسط" });

            chartPeriodTag.SelectedIndex = 0;
            chartPeriodAsset.SelectedIndex = 0;
            chartPeriodInstr.SelectedIndex = 0;
            loadDaily(chartAsset, 3);
            loadDaily(chartTag, 3);
            loadDaily(chartInstr, 1);
        }

        private void loadDaily(Chart chart, int num)
        {
            chart.ChartAreas[0].AxisX.Title = "روز";
            loadChart(1, 30, 4, 10, chart, num);
        }

        private void loadWeekly(Chart chart, int num)
        {
            chart.ChartAreas[0].AxisX.Title = "هفته";
            loadChart(1, 52, 1, 30, chart, num);
        }

        private void loadMonthly(Chart chart, int num)
        {
            chart.ChartAreas[0].AxisX.Title = "ماه";
            loadChart(1, 12, 1, 120, chart, num);
        }

        private void loadYearly(Chart chart, int num)
        {
            chart.ChartAreas[0].AxisX.Title = "سال";
            loadChart(1389, 4, 1, 1440, chart, num);
        }
        private void loadChart(int start, int pp, int prob, int maxi, Chart chart, int num)
        {
            Random r = new Random();
            for (int i = 0; i < num; i++)
            {
                chart.Series[i].Points.Clear();
                for (int j = 0; j < pp; j++)
                    if (r.Next(prob) == 0)
                        chart.Series[i].Points.Add(new DataPoint(j + start, r.Next(maxi)));
                    else
                        chart.Series[i].Points.Add(new DataPoint(j + start, 0));
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo(sender, e, chartInstr, 1, chartPeriodInstr);
        }

        private void viewCheck_CheckedChanged(object sender, EventArgs e)
        {
            chartAsset.Series[0].Enabled = viewCheckAsset.Checked;
            chartAsset.Series[1].Enabled = changeCheckAsset.Checked;
            chartAsset.Series[2].Enabled = updateCheckAsset.Checked;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            combo(sender, e, chartAsset, 3, chartPeriodAsset);
        }

        private void chartPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo(sender, e, chartTag, 3, chartPeriodTag);
        }

        private void viewCheckTag_CheckedChanged(object sender, EventArgs e)
        {
            chartTag.Series[0].Enabled = viewCheckTag.Checked;
            chartTag.Series[1].Enabled = changeCheckTag.Checked;
            chartTag.Series[2].Enabled = updateCheckTag.Checked;
        }

        private void changeCheckTag_CheckedChanged(object sender, EventArgs e)
        {
            chartTag.Series[0].Enabled = viewCheckTag.Checked;
            chartTag.Series[1].Enabled = changeCheckTag.Checked;
            chartTag.Series[2].Enabled = updateCheckTag.Checked;
        }

        private void updateCheckTag_CheckedChanged(object sender, EventArgs e)
        {
            chartTag.Series[0].Enabled = viewCheckTag.Checked;
            chartTag.Series[1].Enabled = changeCheckTag.Checked;
            chartTag.Series[2].Enabled = updateCheckTag.Checked;
        }
    }
}

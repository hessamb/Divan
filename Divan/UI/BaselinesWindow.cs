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
    public partial class BaselinesWindow : Form
    {
        public string SelectedBaseline { get; set; }
        public static string Show‌Baselines()
        {
            BaselinesWindow a = new BaselinesWindow();
            if (a.ShowDialog() == DialogResult.OK)
            {
                return a.SelectedBaseline;
            }
            return null;
        }

        public BaselinesWindow()
        {
            InitializeComponent();
        }

        private void assetsTree_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void assetForm_Load(object sender, EventArgs e)
        {
            UIHelper.SetPlaceHolder(searchTxt, "جستجوی نقطه‌ی مبنا");

            assetsGrid.Rows.Add(new object[] { "پیکربندی اولیه", "۰۹/۰۷/۹۲" });
            assetsGrid.Rows.Add(new object[] { "پیکربندی دوم", "۱۲/۱۷/۹۲" });
        }

        private void select_Click(object sender, EventArgs e)
        {
            SelectedBaseline = (string)assetsGrid.SelectedCells[0].OwningRow.Cells[0].Value;
           DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void assetsGrid_DoubleClick(object sender, EventArgs e)
        {
            select_Click(null, null);
        }
    }
}

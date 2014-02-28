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
    public partial class AssetHistoryWindow : Form
    {
        public AssetHistoryWindow()
        {
            InitializeComponent();
        }

        private void revert_Click(object sender, EventArgs e)
        {
            if (ConfirmationBox.ShowConfirmation("آیا مطمثنید که می‌خواهید این دارایی را به این تاریخ بازگردانید؟", "بازگردان") == System.Windows.Forms.DialogResult.OK)
                DialogResult = System.Windows.Forms.DialogResult.Yes;
        }

        private void AssetHistory_Load(object sender, EventArgs e)
        {
            propsGrid.Rows.Add(new object[] { "۲ تیر ۱۳۹۲", "ایجاد دارایی" });
            propsGrid.Rows.Add(new object[] { "۳ تیر ۱۳۹۲", "تغییر وضعیت به عالی" });
            propsGrid.Rows.Add(new object[] { "۱۵ مرداد ۱۳۹۲", "اضافه کردن یک مشخصه‌ی جدید" });
            propsGrid.Rows.Add(new object[] { "۲۰ شهریور ۱۳۹۲", "فرسوده شدن دارایی. تغییر وضعیت به متوسط" });

        }
    }
}

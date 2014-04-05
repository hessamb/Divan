using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Divan
{
    public partial class AssetAttachementViewer : Form
    {
        private Asset asset;
        private FileInfo fileInfo;
        private PersianCalendar cal = new PersianCalendar();
        public AssetAttachementViewer(Asset asset)
        {
            InitializeComponent();
            this.asset = asset;
        }

        private void listBox_attachement_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            AttachedFile attachment = (AttachedFile)listBox.SelectedItem;
            fileInfo = new FileInfo(attachment.path);
            reloadDetails();
        }

        private string fileSizeNormalizer(long length)
        {
            if (length < 3000)
                return length + " بایت";
            else if (length < 2000000)
                return (length / 1024) + " کیلوبایت";
            else if (length < 2000000000)
                return (length / 1024 / 1024) + " مگابایت";
            else
                return (length / 1024 / 1024 / 1024) + " گیگابایت";
        }

        private void reloadDetails()
        {
            label_error.Visible = !fileInfo.Exists;
            button_exec.Enabled = fileInfo.Exists;
            tableLayoutPanel_info.Visible = fileInfo.Exists;
            if (!fileInfo.Exists){
                return;
            }
            label_name.Text = "نام فایل: " + fileInfo.Name;
            label_size.Text = "حجم فایل: " + fileSizeNormalizer(fileInfo.Length);
            label_lastModification.Text = "آخرین تاریخ بروز رسانی: " + getPerisanTime(fileInfo.LastWriteTime);
        }

        private string getPerisanTime(DateTime dateTime)
        {
            return cal.GetYear(dateTime) + "/" + cal.GetMonth(dateTime) + "/"
                + cal.GetDayOfMonth(dateTime) + " " + cal.GetHour(dateTime) + ":"
                + cal.GetMinute(dateTime);
        }



        private void AssetAttachementViewer_Load(object sender, EventArgs e)
        {
            foreach (AttachedFile file in asset.AttachedFiles)
            {
                listBox_attachement.Items.Add(file);
            }
            listBox_attachement.SelectedIndex = 0;
            AttachedFile attachment = (AttachedFile)listBox_attachement.SelectedItem;
            fileInfo = new FileInfo(attachment.path);
            reloadDetails();
        }

        private void button_exec_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(fileInfo.FullName);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

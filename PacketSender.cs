using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PacketSender
{
    public partial class PacketSender : Form
    {
        public PacketSender()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = WinHTTP.SendRequest(
                CB_Method.SelectedItem.ToString(),
                TB_URL.Text,
                TB_UA.Text,
                TB_Referer.Text,
                TB_Cookie.Text,
                TB_ContentTYpe.Text,
                textBox2.Text,
                textBox1.Text,
                TB_Data.Text);
            this.TB_Result.Text = result;
        }

        private void BTN_Clipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.TB_Result.Text);
        }

        private void BTN_NotePad_Click(object sender, EventArgs e)
        {
            try {
                StreamWriter sw = new StreamWriter("ResponseResultLog.txt", true, Encoding.UTF8);
                sw.WriteLine(DateTime.Now.ToString("yyyy-MM/dd tt HH:mm:ss"));
                sw.WriteLine(TB_Result.Text);
                sw.WriteLine();
                sw.Flush();
                sw.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.Trim());
            }
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Method = CB_Method.SelectedIndex;
            Properties.Settings.Default.Url = this.TB_URL.Text;
            Properties.Settings.Default.UserAgent = this.TB_UA.Text;
            Properties.Settings.Default.Referer = this.TB_Referer.Text;
            Properties.Settings.Default.Cookie = this.TB_Cookie.Text;
            Properties.Settings.Default.ContentType = this.TB_ContentTYpe.Text;
            Properties.Settings.Default.Data = this.TB_Data.Text;
            Properties.Settings.Default.Save();
        }

        private void BTN_Load_Click(object sender, EventArgs e)
        {
            this.CB_Method.SelectedIndex = Properties.Settings.Default.Method;
            this.TB_URL.Text = Properties.Settings.Default.Url;
            this.TB_UA.Text = Properties.Settings.Default.UserAgent;
            this.TB_Referer.Text = Properties.Settings.Default.Referer;
            this.TB_Cookie.Text = Properties.Settings.Default.Cookie;
            this.TB_ContentTYpe.Text = Properties.Settings.Default.ContentType;
            this.TB_Data.Text = Properties.Settings.Default.Data;
        }
    }
}

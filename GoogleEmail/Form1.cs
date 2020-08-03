using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace GoogleEmail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SendMail_Click(object sender, EventArgs e)
        {
            //test
            string YuorGoogleAddress = "";
            string YuorGooglePassword="";
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            //收信人
            msg.To.Add("收件人Email");
            msg.From = new MailAddress(YuorGoogleAddress, "寄件名稱", System.Text.Encoding.UTF8);
            msg.Subject = "測試標題";//郵件標題
            msg.SubjectEncoding = System.Text.Encoding.UTF8;//郵件標題編碼
            msg.Body = "郵件內文"; //郵件內容
            msg.BodyEncoding = System.Text.Encoding.UTF8;//郵件內容編碼 
            //msg.Attachments.Add(new Attachment(@"D:\test2.docx"));  //附件
            msg.IsBodyHtml = true;//是否是HTML郵件 
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential(YuorGoogleAddress, YuorGooglePassword); //帳號跟密碼

            client.Host = "smtp.gmail.com"; //設定smtp Server
            client.Port = 25; //設定Port
            client.EnableSsl =true; //gmail預設開啟驗證
            client.Send(msg); //寄出信件
            client.Dispose();
            msg.Dispose();
            MessageBox.Show(this, "郵件寄送成功！");

        }
    }
}

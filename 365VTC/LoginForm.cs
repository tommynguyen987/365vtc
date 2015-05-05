using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUtility
{
    public partial class LoginForm : Form
    {
        const string PhoneNumber = "0909182406";
        const string Password = "pA55Word24612!@#"; 
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            PostRequest();
        }

        private void PostRequest()
        {
            try
            {
                var url = "https://365.vtc.vn/";
                webBrowser1.Url = new Uri(url);
                webBrowser1.DocumentCompleted += wbr_DocumentCompleted;            
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error!" + System.Environment.NewLine + ex.Message);
            }
        }

        private void wbr_DocumentCompleted(object sender, System.Windows.Forms.WebBrowserDocumentCompletedEventArgs e)
        {
            System.Windows.Forms.WebBrowser wbr = sender as System.Windows.Forms.WebBrowser;
            try
            {
                if (wbr.ReadyState == System.Windows.Forms.WebBrowserReadyState.Complete)
                {
                    System.Windows.Forms.HtmlElement form = wbr.Document.GetElementById("mainform");
                    if (form != null)
                    {
                        wbr.Document.GetElementById("username").SetAttribute("value", PhoneNumber);
                        wbr.Document.GetElementById("password").SetAttribute("value", Password);                       

                        wbr.DocumentCompleted -= wbr_DocumentCompleted;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error!" + System.Environment.NewLine + ex.Message);
            }
        }
    }
}

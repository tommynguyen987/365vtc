using System;
using System.Windows.Forms;

namespace MyUtility
{
    public partial class OnlinePaymentSoft : Form
    {
        const string PhoneNumber = "0909182406";
        const string Password = "pA55Word24612!@#";        
        public OnlinePaymentSoft()
        {
            InitializeComponent();            
        }                         
      
        private void SetEnableFunctions(bool isEnabled)
        {
            btnCellPhone.Enabled = isEnabled;
            btnFixedPhone.Enabled = isEnabled;
            btnInterPhone.Enabled = isEnabled;
        }

        private void OnlinePaymentSoft_Load(object sender, EventArgs e)
        {
            containerPane.Visible = false;
            //PostRequest();
            System.Threading.Thread.Sleep(5 * 1000);
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }    

        private void PostRequest()
        {            
            try
            {
                var url = "https://365.vtc.vn/";
                webBrowser1.Url = new Uri(url);

                //System.Threading.Thread.Sleep(5 * 1000);

                //url = "http://hcm.vieclam.24h.com.vn/ntv-trang-quan-tri-tin-tim-viec.html";
                //webBrowser1.Navigate(url);
                
                //webBrowser1.DocumentCompleted += wbr_DocumentCompleted;            
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
                if (!wbr.Url.AbsoluteUri.Contains("/dich-vu-393/dien-thoai-di-dong-397/21") && wbr.ReadyState == System.Windows.Forms.WebBrowserReadyState.Complete)
                {
                    System.Windows.Forms.HtmlElement form = wbr.Document.GetElementById("mainform");
                    if (form != null)
                    {
                        wbr.Document.GetElementById("username").SetAttribute("value", PhoneNumber);
                        wbr.Document.GetElementById("password").SetAttribute("value", Password);
                        form.InvokeMember("submit");
                        form.SetAttribute("action", "/dich-vu-393/dien-thoai-di-dong-397/21");
                        form.InvokeMember("submit");

                        wbr.DocumentCompleted -= wbr_DocumentCompleted;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error!" + System.Environment.NewLine + ex.Message);
            }
        }

        private void btnCellPhone_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = false;
            containerPane.Visible = true;
            var cellPhone = new CellPhoneControl();
            containerPane.Controls.Add(cellPhone);
        }

        private void btnFixedPhone_Click(object sender, EventArgs e)
        {

        }

        private void btnInterPhone_Click(object sender, EventArgs e)
        {

        }        
    }
}

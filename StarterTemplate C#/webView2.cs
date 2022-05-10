using Microsoft.Web.WebView2.Core;

namespace webView2_Starter_Template
{
    public partial class webView : Form
    {
        public webView()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Form_Resize);
        }
        private void Form_Resize(object sender, EventArgs e)
        {
            myWebView.Size = this.ClientSize - new System.Drawing.Size(myWebView.Location);
            BtnConfirm.Left = this.ClientSize.Width - BtnConfirm.Width;
            AddressBox.Width = BtnConfirm.Left - AddressBox.Left;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            LoadUrl();
        }
        private void LoadUrl()
        {
            //Checks to see if link is valid
            string address = AddressBox.Text;
            if (address.Length < 9 || address.Substring(0, 8) != "https://")
            {
                myWebView.CoreWebView2.ExecuteScriptAsync($"alert('Link is not valid, remember to start with https://')");
            }
            //Link is almost valid enough
            else
            {
                try
                {
                    //To check what browser type is set go to: https://www.deviceinfo.me/
                    //webView.CoreWebView2.Settings.UserAgent = Globals.edgeUA; //Change useragent to edge
                    myWebView.CoreWebView2.Navigate(AddressBox.Text);
                }
                //Catch any other errors we might not have accounted for
                catch (Exception)
                {
                    myWebView.CoreWebView2.ExecuteScriptAsync($"alert('Not a valid link')");
                }
            }
        }

        private void AddressBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadUrl();
            }
        }
    }
}
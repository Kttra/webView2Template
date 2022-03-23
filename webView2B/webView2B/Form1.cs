using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace webView2B
{
   public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Form_Resize);
            webView.NavigationStarting += EnsureHttps;
        }
        //Ensure that the address starts with "https://"
        void EnsureHttps(object sender, CoreWebView2NavigationStartingEventArgs args)
        {
            String uri = args.Uri;
            if (!uri.StartsWith("https://"))
            {
                webView.CoreWebView2.ExecuteScriptAsync($"alert('{uri} is not safe, try an https link')");
                args.Cancel = true;
            }
        }
        //Resize address bar and go button
        private void Form_Resize(object sender, EventArgs e)
        {
            webView.Size = this.ClientSize - new System.Drawing.Size(webView.Location);
            goButton.Left = this.ClientSize.Width - goButton.Width;
            addressBar.Width = goButton.Left - addressBar.Left;
        }

        private void goButton_Click(object sender, EventArgs e)
        {   
            //Checks to see if link is valid
            string address = addressBar.Text;
            if (address.Length < 8 || address.Substring(0, 8) != "https://" || addressBar.Text == "https://")
            {
                webView.CoreWebView2.ExecuteScriptAsync($"alert('Link is not valid, remember to start with https://')");
            }
            //Link is almost valid enough
            else
            {
                try
                {
                    webView.CoreWebView2.Navigate(addressBar.Text);
                }
                //Catch any other errors we might not have accounted for
                catch(Exception error)
                {
                    webView.CoreWebView2.ExecuteScriptAsync($"Not a valid link");
                }
            }
        }

    }
}

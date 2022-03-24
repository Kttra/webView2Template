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
using System.Runtime.InteropServices;

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
            requestButton.Left = this.ClientSize.Width - requestButton.Width;
            addressBar.Width = goButton.Left - addressBar.Left;
        }
        private void goButton_Click(object sender, EventArgs e)
        {   
            //Checks to see if link is valid
            string address = addressBar.Text;
            if (address.Length < 9 || address.Substring(0, 8) != "https://")
            {
                webView.CoreWebView2.ExecuteScriptAsync($"alert('Link is not valid, remember to start with https://')");
            }
            //Link is almost valid enough
            else
            {
                try
                {
                    //webView.CoreWebView2.Settings.UserAgent = "Mozilla/5.0 (X11; U; Iphone i686; en-US; rv:1.9.0.4) Gecko/20100101 Firefox/4.0";
                    webView.CoreWebView2.Navigate(addressBar.Text);
                }
                //Catch any other errors we might not have accounted for
                catch(Exception)
                {
                    webView.CoreWebView2.ExecuteScriptAsync($"Not a valid link");
                }
            }
        }
        //Show form2 on request
        private void requestButton_Click(object sender, EventArgs e)
        {
            extraMenu f2 = new extraMenu();
            f2.Show();
        }
        //Loads information from json file
        private void loadButton_Click(object sender, EventArgs e)
        {
            var json = System.IO.File.ReadAllText(@"c:\bing.json");
        }
        //Automated runner
        private void runButton_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
            else
            {
                backgroundWorker1.RunWorkerAsync();
                //Updating progressbar values
                
                progressBar1.Value++;
                progressLabel1.Text = "Progress " + progressBar1.Value + "/" + 30;
            }
            if (backgroundWorker2.IsBusy)
            {
                backgroundWorker2.CancelAsync();
            }
            else{
                backgroundWorker2.RunWorkerAsync();
            }
        }
        //Cancel the 1st task
        private void progressBar1_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
        }
        //Cancel the 2nd task
        private void progressBar2_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
        }
        //Cancel the 3rd task
        private void progressBar3_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
        }
        //First Background worker
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        //Second Background Worker
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        //Cancel all tasks
        private void stopButton_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
            backgroundWorker2.CancelAsync();
        }
    }
    //Globals
    static class Globals
    {
        //global int
        public static int counter;

        //Global function
        public static string HelloWorld()
        {
            return "Hello World";
        }
        public static Random random = new Random();
        //Generate random string with only letters
        public static string randomLetters(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using System.IO; //FILE
using Newtonsoft.Json;
using System.Threading;


namespace webView2B
{
    public partial class Form1 : Form
    {
        CancellationTokenSource cts = new CancellationTokenSource();
        public Form1()
        {
            InitializeComponent();
            Task delayTask = InitializeBrowser();
            this.Resize += new System.EventHandler(this.Form_Resize);
            webView.NavigationStarting += EnsureHttps;
            initalizeSearchCount();
            initalizeLabels();
        }
        //Initializes the browser for the setup version
        private async Task InitializeBrowser()
        {
            var userDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AppName";
            var env = await CoreWebView2Environment.CreateAsync(null, userDataFolder);
            await webView.EnsureCoreWebView2Async(env);
            await webViewb.EnsureCoreWebView2Async(env);
            webViewb.CoreWebView2.Settings.UserAgent = Globals.mobileUA;
        }
        //Intailizes the search count based on user settings
        private void initalizeSearchCount()
        {
            Globals.edgeSearches = Properties.Settings.Default.userEdge;
            Globals.mobileSearches = Properties.Settings.Default.userMobile;
            Globals.desktopSearches = Properties.Settings.Default.userDesktop;
            Properties.Settings.Default.Save();
            initalizeLabels();
        }
        //Intailizes the labels under the progress bars
        private void initalizeLabels()
        {
            progressLabel1.Text = "Progress: 0/" + Globals.edgeSearches;
            progressLabel2.Text = "Progress: 0/" + Globals.mobileSearches;
            progressLabel3.Text = "Progress: 0/" + Globals.desktopSearches;
            progressBar1.Maximum = Globals.edgeSearches;
            progressBar2.Maximum = Globals.mobileSearches;
            progressBar3.Maximum = Globals.desktopSearches;
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
            //webView.Size = this.ClientSize - new System.Drawing.Size(webView.Location);
            goButton.Left = this.ClientSize.Width - goButton.Width;
            requestButton.Left = this.ClientSize.Width - requestButton.Width;
            addressBar.Width = goButton.Left - addressBar.Left;
        }

//------------------------------------Button Presses----------------------------------------------------------
        //Go Button Press
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
                    //To check what browser type is set go to: https://www.deviceinfo.me/
                    //webView.CoreWebView2.Settings.UserAgent = Globals.edgeUA; //Change useragent to edge
                    webView.CoreWebView2.Navigate(addressBar.Text);
                }
                //Catch any other errors we might not have accounted for
                catch(Exception)
                {
                    webView.CoreWebView2.ExecuteScriptAsync($"alert('Not a valid link')");
                }
            }
        }
        //REQUEST BUTTON PRESS ---------------------------------------Show form2 on request
        private void requestButton_Click(object sender, EventArgs e)
        {
            extraMenu f2 = new extraMenu();
            f2.ShowDialog(); //f2.Show() will make it so the below code runs before we close form2
            //#pragma warning disable 4014
            extraSearch();
            //#pragma warning restore 4014
        }

        //LOAD BUTTON PRESS--------------------------------------------Loads information from json file
        private void loadButton_Click(object sender, EventArgs e)
        {
            string fileName = @"c:\google.json";
            if (File.Exists(fileName))
            {
                //Load json file info
                List<searchValues> searches = JsonConvert.DeserializeObject<List<searchValues>>(File.ReadAllText(fileName));
                
                //Update the progress
                progressBar1.Maximum = searches[0].edge;
                progressBar2.Maximum = searches[0].mobile;
                progressBar3.Maximum = searches[0].desktop;
                Globals.edgeSearches = searches[0].edge;
                Globals.desktopSearches = searches[0].desktop;
                Globals.mobileSearches = searches[0].mobile;
                progressLabel1.Text = "Progress: 0/"+ searches[0].edge;
                progressLabel2.Text = "Progress: 0/" + searches[0].mobile;
                progressLabel2.Text = "Progress: 0/" + searches[0].desktop;
            }
            //If the json file doesn't exist, open form3 where we can edit the app settings
            else
            {
                appSettings f3 = new appSettings();
                f3.ShowDialog();
                initalizeSearchCount();
            }
        }
        //RUN BUTTON PRESS-----------------------------------------------Automated runner
        private void runButton_Click(object sender, EventArgs e)
        {
            //Check if the searches are running
            if (Globals.inProgress == false) {
                //Reset everything
                Globals.inProgress = true;

                //Reset all the progress
                progressBar1.Value = 0;
                progressBar2.Value = 0;
                progressBar3.Value = 0;
                progressLabel1.Text = "Progress 0/" + Globals.edgeSearches;
                progressLabel2.Text = "Progress 0/" + Globals.mobileSearches;
                progressLabel3.Text = "Progress 0/" + Globals.desktopSearches;
                progressBar1.Maximum = Globals.edgeSearches;
                progressBar2.Maximum = Globals.mobileSearches;
                progressBar3.Maximum = Globals.desktopSearches;

                //Create new token
                cts = new CancellationTokenSource();
                var token = cts.Token;

                //Run the tasks
                edge(cts.Token);
                mobile(cts.Token);
            }
            else
            {
                cts.Cancel();
                addressBar.Text = "Attempting to stop...";
                Globals.inProgress = false;
                cts.Dispose();
            }
        }
        //Edge Searches
        private async void edge(CancellationToken cancellationToken)
        {
            //Change User Agent to edge
            webView.CoreWebView2.Settings.UserAgent = Globals.edgeUA;
            for (int i = 0; i < Globals.edgeSearches; i++)
            {
                //Two ways to end the async method
                if(cancellationToken.IsCancellationRequested)
                {
                    progressLabel1.Text = "Stopped";
                    progressLabel3.Text = "Stopped";
                    return;
                }
                if (Globals.requestE_End)
                {
                    progressLabel1.Text = "Stopped";
                    progressLabel3.Text = "Stopped";
                    Globals.requestE_End = false;
                    return;
                }

                //Load random webpage
                string address = Globals.Link + Globals.randomLetters(Globals.randomNumber(7));
                webView.CoreWebView2.Navigate(address);

                //Update Progress
                progressBar1.Value++;
                progressLabel1.Text = "Progress " + progressBar1.Value + "/" + Globals.edgeSearches;

                //Wait
                await Task.Delay(Globals.randomTime(7500));
            }

            desktop(cts.Token);
        }
        //Mobile Searches
        private async void mobile(CancellationToken cancellationToken)
        {
            await Task.Delay(Globals.randomTime(7500));

            //Set UserAgent to mobile
            webViewb.CoreWebView2.Settings.UserAgent = Globals.mobileUA;

            for (int i = 0; i < Globals.mobileSearches; i++)
            {
                //Two ways to end the async method
                if (cancellationToken.IsCancellationRequested)
                {
                    progressLabel2.Text = "Stopped";
                    addressBar.Text = "";
                    return;
                }
                if (Globals.requestM_End)
                {
                    progressLabel2.Text = "Stopped";
                    Globals.requestM_End = false;
                    return;
                }

                //Load random webpage
                string address = Globals.Link + Globals.randomLetters(Globals.randomNumber(7));
                webViewb.CoreWebView2.Navigate(address);

                //Update progress
                progressBar2.Value++;
                progressLabel2.Text = "Progress " + progressBar2.Value + "/" + Globals.mobileSearches;

                //Wait
                await Task.Delay(Globals.randomTime(7500));
            }
        }
        //Desktop Searches
        private async void desktop(CancellationToken cancellationToken)
        {
            //Change User Agent to chrome/desktop
            webView.CoreWebView2.Settings.UserAgent = Globals.firefoxUA;

            for (int i = 0; i < Globals.desktopSearches; i++)
            {
                //Two ways to end the async method
                if (cancellationToken.IsCancellationRequested)
                {
                    progressLabel3.Text = "Stopped";
                    addressBar.Text = "";
                    return;
                }
                if (Globals.requestD_End)
                {
                    progressLabel3.Text = "Stopped";
                    Globals.requestD_End = false;
                    return;
                }

                //Load random webpage
                string address = Globals.Link + Globals.randomLetters(Globals.randomNumber(7));
                webView.CoreWebView2.Navigate(address);

                //Update progress
                progressBar3.Value++;
                progressLabel3.Text = "Progress " + progressBar3.Value + "/" + Globals.desktopSearches;

                //Wait
                await Task.Delay(Globals.randomTime(7500));
            }

            //All asyncs are done
            Globals.inProgress = false;
        }
        //Extra search, but we need to make sure it doesn't run all at once, so we do it this way
        private async void extraSearch()
        {
            for(int i = 0; i < Globals.doSearch.Count; i++)
            {
                Task t = extraSearches(Globals.doSearch[i]);
                await t;
            }
            //Clears the list just in case user calls it again
            Globals.doSearch.Clear();
        }
        //Extra Searches
        private async Task extraSearches(string type)
        {

            //Determine which useragent to use
            switch (type)
            {
                case "Edge":
                    webView.CoreWebView2.Settings.UserAgent = Globals.edgeUA;
                    break;
                case "Mobile":
                    webViewb.CoreWebView2.Settings.UserAgent = Globals.mobileUA;
                    break;
                case "Desktop":
                    webView.CoreWebView2.Settings.UserAgent = Globals.firefoxUA;
                    break;
                default:
                    webView.CoreWebView2.Settings.UserAgent = Globals.firefoxUA;
                    break;
            }
           
            for (int i = 0; i < Globals.iterations; i++)
            {
                //Load random webpage
                string address = Globals.Link + Globals.randomLetters(Globals.randomNumber(7));
                
                //Load webViewb if it's a mobile search
                if (type == "Mobile")
                {
                    webViewb.CoreWebView2.Navigate(address);
                }
                else
                {
                    webView.CoreWebView2.Navigate(address); 
                }
                addressBar.Text = type + ": " + (i+1) + "/" + Globals.iterations;
                //Wait
                await Task.Delay(Globals.randomTime(7500));
            }
        }
        //PROGRESSBAR1 PRESS--------------------------------------------Cancel the 1st task
        private void progressBar1_Click(object sender, EventArgs e)
        {
            Globals.requestE_End = true;
            Globals.inProgress = false;
        }
        //PROGRESSBAR2 PRESS--------------------------------------------Cancel the 2nd task
        private void progressBar2_Click(object sender, EventArgs e)
        {
            Globals.requestM_End = true;
            Globals.inProgress = false;
        }
        //PROGRESSBAR3 PRESS--------------------------------------------Cancel the 3rd task
        private void progressBar3_Click(object sender, EventArgs e)
        {
            Globals.requestD_End = true;
            Globals.inProgress = false;
        }
        //STOP BUTTON PRESS----------------------------------------------Cancel all tasks
        private void stopButton_Click(object sender, EventArgs e)
        {
            //Cancel all the async methods
            try
            {
                cts.Cancel();
            }
            //Error
            catch(Exception)
            {
                MessageBox.Show("Task has already been stopped!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            addressBar.Text = "Attempting to stop..."; 
            Globals.inProgress = false;
            cts.Dispose();
        }
    }
    //Globals
    static class Globals
    {
        //Global variables
        //User Agent strings
        public const string mobileUA = "Mozilla/5.0 (iPhone; CPU iPhone OS 13_5_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/13.1.1 Mobile/15E148 Safari/604.1";
        public const string edgeUA = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36 Edg/91.0.864.59";
        public const string desktopUA = "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51.0.2704.103 Safari/537.36";
        public const string firefoxUA = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:98.0) Gecko/20100101 Firefox/98.0";
        //Number of searches to do for each category
        public static int edgeSearches = 6;
        public static int mobileSearches = 22;
        public static int desktopSearches = 32;
        //Whether or not the task is running
        public static bool inProgress = false;
        //Cancel requests for specific tasks
        public static bool requestE_End = false;
        public static bool requestM_End = false;
        public static bool requestD_End = false;
        //Link we want to load
        public static readonly string Link = "https://www.google.com/search?q=define+";
        //Global variables for form2 (Extra Searches)
        public static List<String> doSearch = new List<String>();
        public static int iterations; //Number of extra searches to do

        //Global functions
        public static Random random = new Random();
        //Generate random string with only letters
        public static string randomLetters(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        //Generate random integer with addition and power function
        public static int randomTime(int length)
        {
            return random.Next(5000, length);
        }
        public static int randomNumber(int length)
        {
            return random.Next(3, length);
        }
    }
}

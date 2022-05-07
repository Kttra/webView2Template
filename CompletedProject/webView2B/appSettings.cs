using System;
using System.Windows.Forms;

namespace webView2B
{
    public partial class appSettings : Form
    {
        //Step is initialized, used to check how much inputs were accepted
        private static int step = 0;
        public appSettings()
        {
            InitializeComponent();
        }
        //Enter button is pressed in the textbox
        private void userTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            //If the enter button is pressed
            if (e.KeyCode == Keys.Enter)
            {
                ChangeSettings();
            }
        }
        //Confirm button is pressed
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            ChangeSettings();
        }
        //Update userinput and change the application settings
        private void ChangeSettings()
        {
            int numSearches;
            string userInput = userTextbox.Text;

            //Validates if the input is an integer
            try
            {
                numSearches = int.Parse(userInput);
                switch (step)
                {
                    case 0:
                        Properties.Settings.Default.userEdge = numSearches;
                        step++;
                        label1.Text = "Enter how many MOBILE searches you would like to change to";
                        ConfirmButton.Text = "Confirm";
                        userTextbox.Text = "";
                        break;
                    case 1:
                        Properties.Settings.Default.userMobile = numSearches;
                        step++;
                        label1.Text = "Enter how many DESKTOP searches you would like to change to";
                        ConfirmButton.Text = "Confirm";
                        userTextbox.Text = "";
                        break;
                    case 2:
                        Properties.Settings.Default.userDesktop = numSearches;
                        label1.Text = "Enter how many EDGE searches you would like to change to";
                        ConfirmButton.Text = "Confirm";
                        userTextbox.Text = "";
                        step = 0;
                        this.Close();
                        break;
                }
            }
            catch
            {
                ConfirmButton.Text = "Invalid!";
            }
        }
    }
}

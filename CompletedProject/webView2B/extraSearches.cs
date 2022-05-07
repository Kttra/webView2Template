using System;
using System.Windows.Forms;

namespace webView2B
{
    public partial class extraMenu : Form
    {
        public extraMenu()
        {
            InitializeComponent();
        }
        //Confirm button is clicked
        private void menu2Confirm_Click(object sender, EventArgs e)
        {
            confirmCheck();
        }
        //Enter button is pressed in the textbox
        private void extraTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            //If the button pressed is enter check user input
            if (e.KeyCode == Keys.Enter)
            {
                confirmCheck();
            }
        }
        //Check what the user wants and see if it is valid
        private void confirmCheck()
        {
            int iterations;
            string userInput = extraTextbox.Text;

            //Validates if the input is an integer
            try
            {
                iterations = int.Parse(userInput);

                //If it is an integer, run the requested function
                executeExtra(iterations);

                this.Close();
            }
            catch
            {
                extraTextbox.Text = "Invalid!";
            }
        }
        //Checks the user's request
        private void executeExtra(int iterations)
        {
            //Add each request to the list
            if (checkBoxE.Checked)
            {
                Globals.doSearch.Add("Edge");
            }
            if (checkBoxM.Checked)
            {
                Globals.doSearch.Add("Mobile");
            }
            if (checkBoxD.Checked)
            {
                Globals.doSearch.Add("Desktop");
            }

            //Gives form1 the amount of iterations to be done
            Globals.iterations = iterations;
        }
    }
}

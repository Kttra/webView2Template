using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webView2B
{
    public partial class extraMenu : Form
    {
        public extraMenu()
        {
            InitializeComponent();
        }

        private void menu2Confirm_Click(object sender, EventArgs e)
        {
            int id;

            string userInput = extraTextbox.Text;

            //Validates if the input is an integer
            try
            {
                id = int.Parse(userInput);

                //If it is an integer, run the requested function
                executeExtra(id);

                this.Close();
            }
            catch
            {
                extraTextbox.Text = "Invalid!";
            }
        }
        int executeExtra(int iterations)
        {
            //Do stuff depending on which checkbox is checked
            if (checkBoxB.Checked)
            {
                for (int i = 0; i < iterations; i++)
                {
                    Globals.randomLetters(5);
                }
            }
            if (checkBoxC.Checked)
            {
                for (int i = 0; i < iterations; i++)
                {
                    
                }
            }
            if (checkBoxE.Checked)
            {
                for (int i = 0; i < iterations; i++)
                {

                }
            }

            return 1;
        }
    }
}

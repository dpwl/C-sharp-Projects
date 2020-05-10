// Program Name:    T04 P02 GUI Technical Support
//
// Author:          Yeji Soh
//
// Date:            01-April-2020
//
// Description:     Task 2 of GUI Practice Program
//                  
//                  A program that notify users of what to do when facing any issues on their computers.
//                  The issue category checks if the computer beeps and if discdrive spins.
//                  Depending on the user's issue, user can answer by checking or unchecking them.
//                  After checking is done, user can click on "what should I do?" button, and
//                  the textbox will show what to do depending on the user's answer.
//                  In case that users would like to exit the program, they can simply click "Quit" button.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T04_P02_GUI_Technical_Support
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // When user clicks "What shoul I do?" button, show different message in solutionTextbox.
        private void processButton_Click(object sender, EventArgs e)
        {
            // When computer beeps and discdrive spins
            if (computerBeepCheckbox.Checked == true && discSpinCheckbox.Checked == true)
            {
                solutionTextbox.ForeColor = Color.Red;
                solutionTextbox.Text = "Contact Tech Support.";
            }

            // When computer beeps and discdrive does not spin
            else if (computerBeepCheckbox.Checked == true && discSpinCheckbox.Checked == false)
            {
                solutionTextbox.ForeColor = Color.Red;
                solutionTextbox.Text = "Check drive cables.";
            }

            // When computer does not beep and discdrive does not spin
            else if (computerBeepCheckbox.Checked == false && discSpinCheckbox.Checked == false)
            {
                solutionTextbox.ForeColor = Color.Red;
                solutionTextbox.Text = "Bring computer to repair centre.";
            }

            // When computer does not beep and discdrive spins
            else if (computerBeepCheckbox.Checked == false && discSpinCheckbox.Checked == true)
            {
                solutionTextbox.ForeColor = Color.Red;
                solutionTextbox.Text = "Check the speaker contacts.";
            }

        }

        // When user clicks "Quit" button, exit the program.
        private void quitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

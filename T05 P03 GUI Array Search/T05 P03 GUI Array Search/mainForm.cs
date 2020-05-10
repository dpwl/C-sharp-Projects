// Program Name:    T05 P03 GUI Array Search
//
// Author:          Yeji Soh
//
// Date:            06-April-2020
//
// Description:     Task 3 of Array Practice Programs
//                  
//                  A program that shows ten random numbers in between 10 and 99, and
//                  let the use to search on if the number that user enters exists in
//                  the Random Number List. Note that ten numbers shown in the Random
//                  Number List is automatically generated once the app runs.
//                  When clicking on 'Search' button after user enters in the number,
//                  the relevant message beside the button will pop up depending on
//                  the existance of the number.
//                  In this app, it assumes that user only enters numeric value in the
//                  textbox.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T05_P03_GUI_Array_Search
{
    public partial class mainForm : Form
    {
        // Create a list of which the size is 10
        const int LIST_SIZE = 10;
        private List<int> randomNumbers = new List<int>(LIST_SIZE);

        public mainForm()
        {
            InitializeComponent();
        }

        // Load ten randomly generated numbers, whose range is [10,99], in the randonNumberTextbox.
        private void mainForm_Load(object sender, EventArgs e)
        {
            System.Random random = new System.Random();

            for (int i = 0; i < LIST_SIZE; i++)
            {
                randomNumbers.Add(random.Next(10, 99));
            }

            foreach (int number in randomNumbers)
            {
                randomNumberTextbox.Text += $"{number, 4}";
            }
        }

        // When clicking on 'Search' button,
        private void searchButton_Click(object sender, EventArgs e)
        {
            // Declare the index variable and assign it as
            // the value that user types in valueSearchTextbox
            int index = randomNumbers.IndexOf(int.Parse(valueSearchTextbox.Text.Trim()));

            // When the user inputted number is not found in the list,
            if (index == -1)
            {
                searchResultLabel.Visible = true;   // Make the label visible
                // Show the relevant message beside the button
                searchResultLabel.Text = $"The value {valueSearchTextbox.Text} was NOT found.";
            }

            // When the user inputted number is found in the list,
            else
            {
                searchResultLabel.Visible = true;   // Make the label visible
                // Show the relevant message beside the button
                searchResultLabel.Text = $"The value {valueSearchTextbox.Text} was found at index {index}";
            }
        }
    }
}

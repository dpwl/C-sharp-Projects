// Program Name:    T04 P01 GUI Trapezoid Area
//
// Author:          Yeji Soh
//
// Date:            01-April-2020
//
// Description:     Task 1 of GUI Practice Program
//                  
//                  A program that helps users to calculate the trapezoid area.
//                  When users enters non-numeric value for each variable: length of
//                  parallel side 1 and 2, and Length of height, the error messgae will
//                  pop up and ask users to try again with numeric values.
//                  If user enters any negative values, that will also give users
//                  an error message asking users to enter positive values.
//                  The result of trapezoid area will show up beside Calculate button.

using System;
using System.Windows.Forms;

namespace T04_P01_GUI_Trapezoid_Area
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // When user clicks "Quit" button, the user can exit the program.
        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // When user click "Calculate" button, check the user-entered value is proper.
        private void calculateButton_Click(object sender, EventArgs e)
        {
            double Side1;
            double Side2;
            double height;

            // when user enters non-numeric value for Parallel side 1 length.
            if (!double.TryParse(side1Textbox.Text, out Side1))
            {
                MessageBox.Show("Parallel Side 1 length is NOT a number. Try again!");
                return;     // user still can go back to enter to right value.
            }

            // when user enters negative or 0 value for Parallel side 1 length.
            if (Side1 <= 0)
            {
                MessageBox.Show("Parallel Side 1 length must be positive. Try again!");
                return;     // user still can go back to enter to right value.
            }

            // when user enters non-numeric value for Parallel side 2 length.
            if (!double.TryParse(side2Textbox.Text, out Side2))
            {
                MessageBox.Show("Parallel Side 2 length is NOT a number. Try again!");
                return;     // user still can go back to enter to right value.
            }

            // when user enters negative or 0 value for Parallel side 2 length.
            if (Side2 <= 0)
            {
                MessageBox.Show("Parallel Side 2 length must be positive. Try again!");
                return;     // user still can go back to enter to right value.
            }

            // when user enters non-numeric value for height.
            if (!double.TryParse(heightTextbox.Text, out height))
            {
                MessageBox.Show("Height is NOT a number. Try again!");
                return;     // user still can go back to enter to right value.
            }

            // when user enters negative or 0 value for height.
            if (height <= 0)
            {
                MessageBox.Show("Height must be positive. Try again!");
                return;     // user still can go back to enter to right value.
            }

            // Calculate the trapezoid area
            double area = 0.5 * (Side1 + Side2) * height;

            // Output the result in resultLabel
            resultLabel.Text = $"The Area of Trapezoid is {area:N2}";
            resultLabel.Visible = true;

        }
    }
}

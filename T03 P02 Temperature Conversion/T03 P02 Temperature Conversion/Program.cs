// Program Name:    T03 P02 Temperature Conversion
//
// Author:          Yeji Soh
//
// Date:            30-March-2020
//
// Description:     Task 2 of Method Miniprojects
//                  
//                  A program that helps users to have a temprature unit conversion.
//                  A user will be asked to type in the unit that they'd like to start with.
//                  In here, two choices will be shown explicitly, however, if the user enters
//                  invalid value or the value outside of the given choices, they will receive
//                  error message. If they choose one of the choices given, the prompt will ask
//                  user to enter the value of temperature in double. If the user types any
//                  non-numeric values, they will receive an error message saying the input is
//                  not double number, asking users to try again. When the proper double value of
//                  temperature is given, the result of temperature conversion will be shown, and
//                  the program will ask users if wanting to continue to another conversion or not.
//                  Depending on user's answer either Y(Yes) or N(No), the program will start from
//                  the beginning, or the program will end.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03_P02_Temperature_Conversion
{
    class Program
    {
        // getChoice method (get proper choice from user)
        static char getChoice(string prompt, char choice1, char choice2)
        {
            char choice;                        // The user's choice
            bool haveGoodValue = false;         // Boolean value to check valid choice of users

            do
            {
                Console.Write(prompt);          // Prompt pops up for the first time,
                                                // and re-pops up with invalid(Bad) value

                // 1.       Check if the user's answer is in char type

                // 1.1      If in char type
                if (char.TryParse(Console.ReadLine(), out choice))
                {
                    // 2.   Check if user's input is either choice 1 or choice 2

                    // 2.1  If neighter choice 1 nor choice 2
                    if (choice != choice1 && choice != choice2)     
                    {
                        Console.WriteLine($"Must enter one of '{choice1}' or '{choice2}'.");
                    }

                    // 2.2  If either choice 1 or choice 2
                    else
                    {
                        haveGoodValue = true;   // true to get out of the loop with valid input
                    }
                }

                // 1.2      If NOT in char type
                else
                {
                    Console.WriteLine($"Invalid value. Please try again with '{choice1}' or '{choice2}'!");
                }

            } while (!haveGoodValue);

            return choice;                      // returned value of getChoice method
        }

        // getDouble method (get double value from user)
        static double getDouble(string prompt)
        {
            double temperature;                 // User Input
            bool haveGoodValue = false;         // Boolean value to check valid input of users

            do
            {
                Console.Write(prompt);          // Prompt pops up for the first time,
                                                // and re-pops up with invalid(Bad) value

                // 1.   Check if the user's input is in double datatype

                // 1.1  If NOT in double datatype
                if ( !double.TryParse(Console.ReadLine(), out temperature) )
                {
                    Console.WriteLine("Input is NOT a double number. Try again!");
                }

                // 1.2  If in double datatype
                else
                {
                    haveGoodValue = true;       // true to get out of the loop with valid input
                }

            } while (!haveGoodValue);

            return temperature;                 // returned value of getDouble method
        }

        // toFahrenheit method (Celsius to Fahrenheit Conversion)
        static double toFahrenheit(double celsius)
        {
            double fahrenheit;
            fahrenheit = (double)9 / 5 * celsius + 32;

            return fahrenheit;                  // returned fahrenheit temperature value
        }

        // toCelsius method (Fahrenheit to Celsius Conversion)
        static double toCelsius(double fahrenheit)
        {
            double celsius;
            celsius = (double)5 / 9 * (fahrenheit - 32);

            return celsius;                     // returned celsius temperature value
        }

        static void Main(string[] args)
        {
            char inputUnits;   // records the units of the input temperature (either 'F' or 'C')
            char outputUnits;  // gets the letter that represents the output temperature units
            double inputTemp;    // gets the temperature input by the user
            double outputTemp;   // gets the output temperature calculated by the program
            char moreToDo;     // gets the letter 'Y if more temperatures to be converted


            // jump into a do while that asks for input units, and input temperature. 
            // Then based on the input units, the appropriate conversion function is 
            // called to produce the output temperature
            // 
            // the original temperature and its converted value is output, with units, 
            // using an interpolated string.
            //
            // finally the user is asked if they have more to convert and based on that 
            // input, the loop is repeated (or not)

            do
            {
                // get input units and temperature

                inputUnits = getChoice("What is the input temperature units? [FC] :", 'F', 'C');
                inputTemp = getDouble("Enter temperature to be converted: ");

                if (inputUnits == 'C')           // convert celsius -> to fahrenheit
                {
                    outputTemp = toFahrenheit(inputTemp);
                    outputUnits = 'F';

                }
                else                            // convert fahrenheit -> to celsius
                {
                    outputTemp = toCelsius(inputTemp);
                    outputUnits = 'C';
                }

                // output results

                Console.WriteLine($" {inputTemp}°{inputUnits} =  {outputTemp:N2}°{outputUnits}");

                // ask if more to do

                moreToDo = getChoice("Convert another temperature? [YN]? :", 'Y', 'N');
            } while (moreToDo == 'Y');
        }
    }
}

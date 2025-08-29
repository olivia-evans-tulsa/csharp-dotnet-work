using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Project name: OliviaEvansProg04DistConv 
 * Author: Olivia Evans
 * Date: 9/15/24
 * Description: Takes a number input by the user and converts it from one 
 *    user-selected unit to the other user-selected unit (ex, input "10" converted from inches to feet).
 * Add'l Notes: Created calcAmt to act purely as a calculation function. Called within convertButton_onClick
 *    to make it more succinct and understandable, as there were 3 nested if-else's AND a switch-case which 
 *    muddled clarity. <i>And because I'm an overachiever I guess</i>
 */


namespace OliviaEvansProg04DistConv
{
    public partial class Form1 : Form
    {

        // calculation function that takes two units to convert from and to
        // and a value to convert.
        private double calcAmt(string unitFrom, string unitTo, double input) {
            // originally part of convertButton_click but it was hutring my brain
            double result = -1;

            if (unitFrom == unitTo) // if the same unit is selected,
            {
                result = input; // result is the same as input
            }
            else
            {
                // run this switch statement
                switch (unitFrom) // if unitFrom = [case], run [case]
                {
                    case "Inches":
                        switch (unitTo)
                        { // (duplicates are already filtered out, so we just do the other two options)
                            case "Feet":
                                result = input / 12.0; // 12in in a foot
                                break;
                            case "Yards":
                                result = input / 36.0; // 36in in a yard
                                break;
                        }
                        break; // break switch case

                    case "Feet":
                        switch (unitTo)
                        {
                            case "Inches":
                                result = input * 12.0; // 12in in a foot
                                break;
                            case "Yards":
                                result = input / 3.0; // 3ft in a yard
                                break;
                        }
                        break; // break switch case

                    case "Yards":
                        switch (unitTo)
                        {
                            case "Inches":
                                result = input * 36; // 36in in a yard
                                break;
                            case "Feet":
                                result = input * 3; // 3ft in a yard
                                break;
                        }
                        break; // break switch case

                    default: // if something goes crazy and nothing matches
                        MessageBox.Show("Something went wrong. Try again."); // throw an error
                        break;
                } // END OF SWITCH CASE
            } // END OF IF/ELSE

            return result;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            // breaks if i dont give any one of these a value on init
            string unitFrom = ""; 
            string unitTo = "";
            double result = -1; 

            double input;

            if (unitFromListBox.SelectedIndex != -1 & unitToListBox.SelectedIndex != -1) // if SOMETHING IS SELECTED
            {
                unitFrom = unitFromListBox.SelectedItem.ToString();
                unitTo = unitToListBox.SelectedItem.ToString();

                if (double.TryParse(userAmtTextBox.Text, out input)) // if user input can be converted,
                {
                    // send to calculation function bc i was getting a headache looking at allat in here
                    result = calcAmt(unitFrom, unitTo, input); 

                    // after result has a value, pass result to label
                    distanceConvertedLabel.Text = result.ToString("n1");

                }
                else // if user input CANNOT BE CONVERTED TO A DOUBLE.
                {
                    MessageBox.Show("The value you entered is not valid. Try again."); // throw an error
                }
            }
            else // if something IS NOT SELECTED in one or both listboxes
            {
                MessageBox.Show("Select a value in both the From and To boxes.");
            }

            // never. NEVER. trust a person. when it is interacting w your code. amiright hahaha
            // anyways DONE THATS IT

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // close program <3
            this.Close();
        }
    }
}

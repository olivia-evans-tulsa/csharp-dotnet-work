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
 * Project name:  OliviaEvansProg08Sum  
 * Author: Olivia Evans
 * Date: 10/13/2024
 * Description: Program which parses user input into numbers, sums them, and returns total
 */

namespace OliviaEvansProg08Sum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // handler function which does basically everything (parses, sums, returns)
        private string strip(ref string input) 
        {
            int total = 0;

            // user input divided into an array of numbers (still as a string)
            char[] delim = {','};
            string[] tokens = input.Split(delim);

            // for-each number in the array,
            foreach (string str in tokens)
            {
                if (int.TryParse(str.Trim(), out int num)) // attempt to parse
                {
                    total += num; // add number to running total
                } 
                else // if token was NOT ABLE to parse
                {
                    MessageBox.Show("Invalid input."); // show error message
                    return "Error"; // return val, ending this function
                }
            }

            return total.ToString(); // return val as a string
        }

        // calculate button triggers this. calls helper function, prints result to outputLabel
        private void calcButton_Click(object sender, EventArgs e)
        {
            string str = numStringTextbox.Text.Trim(); // user input
            string total = strip(ref str); // sends input ref to handler function

            if (total != "Error")
            {
                outputLabel.Text = total; // TOTAL IS ALREADY CONVERTED TO A STRING
            }
            else
            {
                outputLabel.Text = " "; // clear sum box
            }
        }

        // close the form
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); // close the form
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Project name : OliviaEvansProg03CelFah 
Author : Olivia Evans
Date : 9/8/2024
Description : Temperature Converter
*/

namespace OliviaEvansProg03CelFah
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // treat user input as F and convert to celsius
        private void toCelButton_Click(object sender, EventArgs e)
        {
            //I LOVE CHECKING INPUT!!!!
            try
            {
                // define variables
                double usertemp; // doubles work with int and floats!
                double conversion;
                string txt; // store formatted output, then send to label

                // take and store user input
                usertemp = double.Parse(userTempTextBox.Text);
                // use formula to convert to Celsius
                conversion = (5.0 / 9.0) * (usertemp - 32);

                // link output to degree symbol
                txt = conversion.ToString() + "°C";
                convertedLabel.Text = txt; // print
            } 
            catch (Exception ex) // IF SOMETHING IN TRY GOES WRONG,
            {
                // throw error to user and dont crash program
                MessageBox.Show("Invalid data entered. Please enter a number.");
            }

        }

        // treat user input as C and convert to fahrenheit
        private void toFarButton_Click(object sender, EventArgs e)
        {
            try
            {
                // define variables
                double usertemp;
                double conversion;
                string txt;

                // take and store user input
                usertemp = double.Parse(userTempTextBox.Text);
                // use formula to convert to fahrenheit
                conversion = ((9.0 / 5.0) * usertemp) + 32;

                // link output to degree symbol
                txt = conversion.ToString() + "°F";
                convertedLabel.Text = txt; // print
            }
            catch (Exception ex) // IF SOMETHING GOES WRONG,
            {
                // throw error to user and dont crash program
                MessageBox.Show("Invalid data entered. Please enter a number.");
            }

        }

        // clear all boxes
        private void clearButton_Click(object sender, EventArgs e)
        {
            // clear text box and printed temp
            userTempTextBox.Text = "";
            convertedLabel.Text = "";
        }

        // close program
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
 * Project name:   OliviaEvansProg11Employee
 * Author : Olivia Evams
 * Date : 11/3/2024
 * Description : Display details input into the form
 */

namespace OliviaEvansProg11Employee
{
    public partial class Form1 : Form
    {
        ProductionWorker pdWorker = new ProductionWorker();

        public Form1()
        {
            InitializeComponent();
        }

        // displays info stored in the pdWorker class
        private void displayButton_Click(object sender, EventArgs e)
        {
            try
            {
                pdWorker.Name = nameTextBox.Text; // parse name textbox
                pdWorker.Number = int.Parse(numberTextBox.Text); // parse number textbox
                pdWorker.HourlyRate = decimal.Parse(payRateTextBox.Text); // parse pay rate textbox
                outputLabel.Text = "Employee Name: " + pdWorker.Name + "\n" +
                    "Employee Number: " + pdWorker.Number + "\n" +
                    "Shift Number: " + pdWorker.ShiftNum + "\n" +
                    "Hourly pay rate: " + pdWorker.HourlyRate.ToString("c"); // print to label !
            }
            catch (Exception ex) // if something fails:
            {
                MessageBox.Show(ex.Message); // pop up error message
            }
        }

        // change pdWorker's ShiftNum property
        private void nightRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (nightRadioButton.Checked) // if night button selected
            {
                pdWorker.ShiftNum = 2; // shift number is 2/Night
            }
        }

        // change pdWorker's ShiftNum property
        private void dayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (dayRadioButton.Checked) // if day button is selected
            {
                pdWorker.ShiftNum = 1; // shift number is 1/Day
            }
        }

        // close the form
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); // close the form
        }
    }
}

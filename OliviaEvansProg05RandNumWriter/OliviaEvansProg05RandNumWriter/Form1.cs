using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/*
Project name : OliviaEvansProg05RandNumWriter 
Author : Olivia Evans
Date : 9/22/2024
Description : Create and save a text file with random numbers, then open and read from it.
Add'l : I wanted to review what exactly to do but blackboard crashed. And when it came up I saw that this is actually
        one assignment with an extra credit assignment... I misread so actually! Here's both!
*/


namespace OliviaEvansProg05RandNum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            uint amount; // uint = unsigned integer (will fail if a neg number OR any decimal val)
            int num;

            if (uint.TryParse(numAmtTextBox.Text, out amount)) // if user input is + whole num
            {
                StreamWriter outputFile;
                Random rand = new Random();

                saveFileDialog1 = new SaveFileDialog();

                if (saveFileDialog1.ShowDialog() == DialogResult.OK) // if file is created,
                {
                    outputFile = File.CreateText((saveFileDialog1.FileName) + ".txt"); // make it a text file

                    while (amount > 0) // while amount (of numbers) isn't 0,
                    {
                        num = rand.Next(100) + 1; // next(100) is actually 0 to 99 range, +1 makes it 1 to 100
                        outputFile.WriteLine(num);
                        amount--;
                        // make a random number, add it, and subtract 1 from amount
                    }

                    outputFile.Close();

                    MessageBox.Show("File saved.");
                }
                else // if file wasnt created,
                {
                    MessageBox.Show("Operation cancelled.");
                }

            }
            else // if tryparse fails
            {
                MessageBox.Show("Enter a whole, non-negative number in the textbox.");
            }

        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;
            int count = 0, total = 0;
            int curr;

            try // see i think im alright? but sure. a safety net
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK) // file selected
                {
                    inputFile = File.OpenText(openFileDialog1.FileName); // open selected file

                    // while the file going and the line can be converted to an int,
                    while (!inputFile.EndOfStream && int.TryParse(inputFile.ReadLine(), out curr)) 
                    {
                        count++; // add how many numbers there are (genuinely almost wrote COUNT(*) sql is killing me rn)
                        total += curr; // add line-number to total
                    }

                    // put on little boxes on screen !
                    countLabel.Text = count.ToString();
                    totalLabel.Text = total.ToString();

                }
                else // no file selected or. whatever
                {
                    MessageBox.Show("Operation cancelled.");
                }
            }
            catch (Exception ex) // if something does something??
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close(); // close :)
        }

    }
}

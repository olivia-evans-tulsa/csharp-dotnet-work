using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Project name:   OliviaEvansProg07WorldSeries  
Author : Olivia Evans
Date : 10/2/2024
Description : counts occurances of a string, matching listbox user selection (and populated by Teams.txt), in a 
              file containing each World Series winner on each line (WorldSeriesWinners.txt)
*/

namespace OliviaEvansProg07WorldSeries
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // load in listbox when form 1 is loading onto screen -- empty list DOES NOT appear to user
        private void Form1_Load(object sender, EventArgs e)
        {
            try 
            {
                StreamReader teams = File.OpenText("Teams.txt");

                while (!teams.EndOfStream) 
                {
                    teamList.Items.Add(teams.ReadLine());
                }

            }
            catch (Exception ex) 
            {
                // if something goes wrong, display an error message, clear listbox
                MessageBox.Show(ex.Message);
                teamList.Items.Clear();
            }
        }


        // displays pop-up saying that info runs from 1903-2012 and that there was no World Series in 1904 & 1994 on button click
        private void disclaimerButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Records refer to all MLB World Series between 1903 and 2012 and are not up to date. " +
                "Please note that there was no World Series in 1904 or 1994.");
        }

        // checks if anything is selected in list and returns boolean value
        private bool checkSelection() {
            // returning to bool isSelected

            int select = teamList.SelectedIndex;
            if (select == -1) // meaning nothing is selected
            {
                return false; // NOTHING is selected
            }
            
            // since returns break out of the function, if program is still reading, then
            return true; // SOMETHING is selected
        }

        // checks selection and counts occurances in WorldSeriesWinners.txt file on button click
        private void searchButton_Click(object sender, EventArgs e)
        {
            bool isSelected = checkSelection(); 

            if (isSelected) // or, if (isSelected == true)
            {
                try
                {
                    // if nothing is selected, the following line will crash -- but isSelected
                    // indicates if something is selected (isSelected == true). this try-catch will only
                    // execute when isSelected is evaluated to true.
                    string selected = teamList.SelectedItem.ToString();

                    StreamReader wins = File.OpenText("WorldSeriesWinners.txt");
                    string currLine = "";
                    int numWins = 0; // init counter

                    while (!wins.EndOfStream) // or, while (wins.EndOfStream != true)
                    {
                        currLine = wins.ReadLine(); // temporarily store the line being read
                        if (selected == currLine) // compare to selection in listBox
                        {
                            numWins++; // if it matches, the team has won that World Series, and numWins increases
                        }
                    }

                    numWinsLabel.Text = numWins.ToString(); // display numWins in empty box
                }
                catch (Exception ex) // if something goes wrong,
                {
                    MessageBox.Show(ex.Message); // display error message
                }
            }
            else // or, if (isSelected == false)
            {
                MessageBox.Show("Select a team."); // display error message
            }
        }

        // closes form on button click
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); // close the form
        }
    }
}

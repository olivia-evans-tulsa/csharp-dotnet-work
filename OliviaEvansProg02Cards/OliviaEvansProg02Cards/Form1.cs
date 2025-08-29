
/*
Project name : OliviaEvansProg02Cards
Author : Olivia Evans
Date : 9/1/2024
Description : Card Identifier
*/

//init
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OliviaEvansProg02Cards
{
    public partial class Form1 : Form //everything contained in the form:
    {
        public Form1()
        {
            InitializeComponent(); //make it exist
        }

        //cards, L to R
        //each changes bottom label to its "card name"
        //(for lack of better words ig)

        private void blackJokerBox_Click(object sender, EventArgs e)
        {
            cardIDLabel.Text = "The Black Joker";
        }

        private void heartTenBox_Click(object sender, EventArgs e)
        {
            cardIDLabel.Text = "Ten of Hearts";
        }

        private void spadeFourBox_Click(object sender, EventArgs e)
        {
            cardIDLabel.Text = "Four of Spades";
        }

        private void clubKingBox_Click(object sender, EventArgs e)
        {
            cardIDLabel.Text = "King of Clubs";
        }

        private void diamondTwoBox_Click(object sender, EventArgs e)
        {
            cardIDLabel.Text = "Two of Diamonds";
        }


        //bottom exit button
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); //crazy coding skills here
        }
    }
}

//end of program

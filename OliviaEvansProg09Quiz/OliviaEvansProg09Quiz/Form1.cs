using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OliviaEvansProg09Quiz
{
    public partial class Form1 : Form
    {

        private Dictionary<string, string> capitals = new Dictionary<string, string>()
        {
            {"Alabama", "Montgomery"}, {"Alaska", "Juneau"}, {"Arizona", "Phoenix"},
            {"Arkansas", "Little Rock"}, {"California", "Sacramento"}, {"Colorado", "Denver"},
            {"Connecticut", "Hartford"}, {"Delaware", "Dover"}, {"Florida", "Tallahassee"},
            {"Georgia", "Atlanta"}, {"Hawaii", "Honolulu"}, {"Idaho", "Boise"},
            {"Illinois", "Springfield"}, {"Indiana", "Indianapolis"}, {"Iowa", "Des Moines"},
            {"Kansas", "Topeka"}, {"Kentucky", "Frankfort"}, {"Louisiana", "Baton Rouge"},
            {"Maine", "Augusta"}, {"Maryland", "Annapolis"}, {"Massachusetts", "Boston"},
            {"Michigan", "Lansing"}, {"Minnesota", "St Paul"}, {"Mississippi", "Jackson"},
            {"Missouri", "Jefferson City"}, {"Montana", "Helena"}, {"Nebraska", "Lincoln"},
            {"New Hampshire", "Concord"}, {"New Jersey", "Trenton"}, {"New Mexico", "Santa Fe"},
            {"New York", "Albany"}, {"North Carolina", "Raleigh"}, {"North Dakota", "Bismark"},
            {"Ohio", "Columbus"}, {"Oklahoma", "Oklahoma City"}, {"Oregon", "Salem"},
            {"Pennsylvania", "Harrisburg"}, {"Rhode Island", "Providence"}, 
            {"South Carolina", "Columbia"}, {"South Dakota", "Pierre"}, {"Tennessee", "Nashville"},
            {"Texas", "Austin"}, {"Utah", "Salt Lake City"}, {"Vermont", "Montpelier"},
            {"Virginia", "Richmond"}, {"Washington", "Olympia"}, {"West Virginia", "Charleston"},
            {"Wisconsin", "Madison"}, {"Wyoming", "Cheyenne"}
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            int dictLength = capitals.Count;
            var selected = capitals.ElementAt(rand.Next(0, dictLength));

            stateLabel.Text = capitals[selected.Key];

        }        

        private void correctCountLabel_Click(object sender, EventArgs e)
        {
            answerPanel.Visible = true;
        }

        private void popupClose_Click(object sender, EventArgs e)
        {
            answerPanel.Visible = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

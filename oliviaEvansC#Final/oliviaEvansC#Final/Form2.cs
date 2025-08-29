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
 * The go button in form1 is doing most of the heavy lifting. hopefully i'm able to
 * port the resulting table over?? please advise me on the best way to show results in a
 * new form :D 
 * AS IT IS NOW, this is pretty much just a frame for the work done in form1, so
 * its mostly graphical!
 * 
 * Estimated completion: 75%
 */

namespace oliviaEvansC_Final
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            download prompt = new download();
            prompt.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // UPDATE ACTUAL TABLE NAME AND SEND REQUEST
        private void sortAlpha_Click(object sender, EventArgs e)
        {
            string request = "SELECT * FROM [output] ORDER BY [output].Offenses";
        }

        // UPDATE ACTUAL TABLE NAME AND SEND REQUEST
        private void sortReverse_Click(object sender, EventArgs e)
        {
            string request = "SELECT * FROM [output] ORDER BY [output].Offenses DESC";
        }
    }
}

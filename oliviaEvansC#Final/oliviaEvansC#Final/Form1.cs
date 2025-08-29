using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Olivia Evans
 * C# Final, 12/1/24
 * 
 * DESCRIPTION: this form serves as a UI for the underlying SQL framework.
 * using various filters like campus and year this form will JOIN tables,
 * use WHERE statements (a lot of them), and overall do some heavy lifting to create
 * a new (temporary) table according to user input (to make it look pretty) 
 * for the user to download.
 * 
 * 
 */

namespace oliviaEvansC_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // global booleans to check certain status
        Boolean allSelected = false;
        Boolean filterByAmt = false;

        // LINQ link
        private TCCDataContext tcc = new TCCDataContext();


        // OMG I <3 LINQ
        // populate checkboxlist with contents of dbo.offense.offensetype
        private void Form1_Load(object sender, EventArgs e)
        { 
            var grab = from Offense in tcc.Offenses select Offense.OffenseType; 
            // create string reference list from offense type ^

            offenseListBox.Items.Clear(); // clear the object
            offenseListBox.Items.Add("All"); //create all shortcut

            foreach (string type in grab) // add each offense
            {
                offenseListBox.Items.Add(type); 
            }
        }

        // unchecks any/all checked item(s) in the offense list box
        private void uncheckAll()
        {
            for (int i = 0; i < offenseListBox.Items.Count; i++)
            {
                offenseListBox.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        // unchecks all campus checkboxes
        private void uncheckCampus() 
        {
            neCheckBox.Checked = false;
            seCheckBox.Checked = false;
            westCheckBox.Checked = false;
            metroCheckBox.Checked = false;
        }

        // checks which campuses are selected and returns an int[] with the selected ones
        private int[] getCampus() 
        {
            int[] campus = new int[4];
            if (metroCheckBox.Checked) { campus.Append(1);}
            if (neCheckBox.Checked) { campus.Append(2); }
            if (seCheckBox.Checked) { campus.Append(3);}
            if (westCheckBox.Checked) { campus.Append(4);}
            return campus;
        }

        // rechecks all years in year groupbox
        private void uncheckYears() 
        { 
            radio2021.Checked = false;
            radio2022.Checked = false;
            radio2023.Checked = false;
        }

        private string getYear() 
        {
            if (radio2021.Checked) { return "y2021"; } // if 2021 is selected, return y2021 (col name)
            else if (radio2022.Checked) { return "y2022"; } // if 2022 is selected, return y2022 (col name)
            else if (radio2023.Checked) { return "y2023"; } // if 2023 is selected, return y2023 (col name)
            else { return "ERROR";  }; 
            // ^ if still reading, then an error has occurred and the task should be aborted
        }

        // FIXME
        // register input and convert to query, open form2
        private void goButton_Click(object sender, EventArgs e)
        {
            string year = getYear();
            var checkeditems = offenseListBox.SelectedItems;
            if (year != "ERROR") // if a year has been selected
            {
                DataTable newTable = new DataTable();
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\olivi\\source\\repos\\oliviaEvansC#Final\\oliviaEvansC#Final\\TCC2023.mdf;Integrated Security=True;Connect Timeout=30";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    IQueryable query;
                    // theres going to be a lot of this.
                    var query1 = from o in tcc.Offenses
                            select o.OffenseType;

                    newTable.Columns.Add("Offenses", typeof(string));
                    foreach (string type in query1) 
                    {
                        if (checkeditems.Contains(type)) 
                        {
                            newTable.Rows.Add(type);
                        }
                    }

                    if (getCampus().Contains(1)) { // if metro is selected
                        // define query to join tables
                        if (year == "y2021")
                        {
                            query = from c in tcc.Metros
                                    join o in tcc.Offenses
                                    on c.id equals o.id
                                    select new { c.y2021, o.OffenseType };
                            foreach (string o in query) {
                                if (checkeditems.Contains(o)) {
                                    newTable.Rows.Add(o);
                                }
                            }
                        }
                        else if (year == "y2022")
                        {
                            query = from c in tcc.Metros
                                    join o in tcc.Offenses
                                    on c.id equals o.id
                                    select c.y2022;
                        }
                        else 
                        {
                            query = from c in tcc.Metros
                                    join o in tcc.Offenses
                                    on c.id equals o.id
                                    select c.y2023;
                        }

                        // add column to datatable
                        newTable.Columns.Add("Metro", typeof(int));

                        foreach (var item in query)
                        {
                            if (newTable.Columns.Contains(item.id))
                            {
                                newTable.Rows.Add(item);
                            }
                        }
                    }
                    if (getCampus().Contains(2)) { // if northeast is selected
                        if (year == "y2021")
                        {
                            query = from c in tcc.Northeasts
                                    join o in tcc.Offenses
                                    on c.id equals o.id
                                    select c.y2021;
                        }
                        else if (year == "y2022")
                        {
                            query = from c in tcc.Northeasts
                                    join o in tcc.Offenses
                                    on c.id equals o.id
                                    select c.y2022;
                        }
                        else
                        {
                            query = from c in tcc.Northeasts
                                    join o in tcc.Offenses
                                    on c.id equals o.id
                                    select c.y2023;
                        }

                        // add column to datatable
                        newTable.Columns.Add("Northeast", typeof(int));

                        foreach (var item in query)
                        {
                            newTable.Rows.Add(item);
                        }
                    }
                    if (getCampus().Contains(3)) // if southeast is selected
                    {
                        if (year == "y2021")
                        {
                            query = from c in tcc.Southeasts
                                    join o in tcc.Offenses
                                    on c.id equals o.id
                                    select c.y2021;
                        }
                        else if (year == "y2022")
                        {
                            query = from c in tcc.Southeasts
                                    join o in tcc.Offenses
                                    on c.id equals o.id
                                    select c.y2022;
                        }
                        else
                        {
                            query = from c in tcc.Southeasts
                                    join o in tcc.Offenses
                                    on c.id equals o.id
                                    select c.y2023;
                        }

                        // add column to datatable
                        newTable.Columns.Add("Southeast", typeof(int));

                        foreach (var item in query)
                        {
                            newTable.Rows.Add(item);
                        }
                    }
                    if (getCampus().Contains(4)) // if west is selected
                    {
                        if (year == "y2021")
                        {
                            query = from c in tcc.Wests
                                    join o in tcc.Offenses
                                    on c.id equals o.id
                                    select c.y2021;
                        }
                        else if (year == "y2022")
                        {
                            query = from c in tcc.Wests
                                    join o in tcc.Offenses
                                    on c.id equals o.id
                                    select c.y2022;
                        }
                        else
                        {
                            query = from c in tcc.Wests
                                    join o in tcc.Offenses
                                    on c.id equals o.id
                                    select c.y2023;
                        }

                        // add column to datatable
                        newTable.Columns.Add("West", typeof(int));

                        foreach (var item in query)
                        {
                            newTable.Rows.Add(item);
                        }
                    }

                    // upload to the datagridview
                    dataGridView1.DataSource = newTable;
                }
            }


        }




        // I AM A GENIUS FOR THIS NGL. makes "all" item exclusive
        private void offenseListBox_ItemCheck(object sender, ItemCheckEventArgs e) // e sends the object clicked
        {
            // I FORGOT HOW GREAT E IS
            if (e.Index == 0 && e.CurrentValue == CheckState.Unchecked) // if "all" is clicked AND it is NOT ALREADY CHECKED
            {
                uncheckAll();
                allSelected = true;
            }
            else if (e.Index != 0) // else if "all" is NOT being clicked on
            {
                offenseListBox.SetItemCheckState(0, CheckState.Unchecked); // double check that "all" is not checked
                // (and if checked, uncheck "all")
                allSelected = false;
            }
        }

        // click event handler sends to resetting helper function
        private void clearReportButton_Click(object sender, EventArgs e)
        {
            uncheckAll();
        }

        // calls all "resetting" helper functions
        private void resetButton_Click(object sender, EventArgs e)
        {
            uncheckAll();
            uncheckCampus();
            uncheckYears();
        }

        // close ALL forms
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

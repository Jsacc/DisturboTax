/**
 * Programmer: James Sacchetti
 * Program: Distrubo Tax
 * Professor: Arland Richmond
 * Last Modified: 2/23/2017
***/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/** Copied to each cs file...
 * Disturbotax 
 * James F. Sacchetti Jr.
 *  The program calculates inputed information into the person class, where it is calculated to display tax information.
 * In form3 or TaxInfo3.cs we get an output of information. The infomation is stored in a list in the CreatePersonList class, and then displayed 
 * in calculationdisplay.cs. Once the user clicks next we sort the data by way of a bubble sort using the ssn, where it is displayed highest ssn to lowest in taxinfo3.cs.
 * In future versions, the data will be sorted by name (first or last) city or state, but for now, data is sorted by ssn only also futurre versions will save information to a file, was not requested in the order.
 * The program required only ten records to be submitted, but with the addition of the addNew button, a list can be created of a size depent on the systems memory. 
 *  Incorrect input is vaidated by way of try catch, a bad input sets a false boolean flag, setting the bool varible to false in taxpayerinfo.cs, makes it so the program will send out 
 *  messages to the user for the fields he or she needs to correct without continuing on and letting a new object of form2 ( taxpayer...) be created. If the quit button is hit on form2, 
 *  bool flag keepOn is set to false, which allows the appliction to exit without it running createperson list as desciredabove. 
 *  As an added bonus, to the project, if the user clicks on a name in the listbox, a disply of an inputted persons information pops up. More detailed information can be displayed if 
 *  this feature is of use to the consumer, it can also be disabled by the programmer on request.
 */

namespace Project_1_DisturboTax
{

    public partial class TaxInfo3 : Form
    {
        private TaxPayerInfoInput taxPayerForm;

        private CalculationDisplay form2 = new CalculationDisplay();

        public TaxInfo3()
        {
            InitializeComponent();
            CreatePersonList.sortItOut();
            addTolistView();
        }

        public void listBox1_SelectionChanged(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("{0:000-00-0000} \n", CreatePersonList.person[listBox1.SelectedIndex].getSSN())
                + '\n' + CreatePersonList.person[listBox1.SelectedIndex].getLastName() + ", " + CreatePersonList.person[listBox1.SelectedIndex].getFirstName() + "\n" + CreatePersonList.person[listBox1.SelectedIndex].getAddress() + '\n' + CreatePersonList.person[listBox1.SelectedIndex].getCity() 
                + " " + CreatePersonList.person[listBox1.SelectedIndex].getState() + '\n' + owe_Refund(listBox1.SelectedIndex));
        }

       

        public void addNewBtn_Click(object sender, EventArgs e)
        {
            this.Close();

            taxPayerForm = new TaxPayerInfoInput();

            taxPayerForm.Focus();

            Program.keepON = true;
        }

        public void Form3_Load(object sender, EventArgs e)
        {

            form2.Visible = false;

        }

        public string owe_Refund(int i)
        {
            if (CreatePersonList.person[i].getAmountOwed() > CreatePersonList.person[i].getRefundAmount())
                return "Owed: " +CreatePersonList.person[i].getAmountOwed().ToString();
            else
                return "Refund: " + CreatePersonList.person[i].getRefundAmount().ToString();
        }

        public void addTolistView() //adds to the listbox in form 3, was previously a 'ListView' hence the function name waste of money to change it
        { // b4 it comes back here the list is sorted in ListPeron class


            for (int j = 0; j < CreatePersonList.person.Count(); j++)
            {
                listBox1.Items.Add((String.Format("{0:000-00-0000} ", CreatePersonList.person[j].getSSN())
                 + CreatePersonList.person[j].getLastName() + ", " + CreatePersonList.person[j].getFirstName() + "\n " + owe_Refund(j)));//displays ssn in real form
            }
        }

        public void quitBtn_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.YesNo);
            if (result1.ToString() == "Yes")
            {
                Program.keepON = false; //sets the varible in main() to false so we exit with no problem... without it the program trys to read input from the text boxes
                CreatePersonList.person.Clear();
                Application.Exit();

            }

        }
    }
}

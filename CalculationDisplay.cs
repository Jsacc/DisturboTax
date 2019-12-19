/**
 * Programmer: James Sacchetti
 * Program: Distrubo Tax
 * Professor: Arland Richmond
 * Last Modified: 2/22/2017
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

    public partial class CalculationDisplay : Form
    {
        //private double adjustedGrossIn; // from doCalculation(); //moved to person class
        private double amountWithHeld; // from w2 input form1
        private double calculatedTax;// from get tax bracket
        private double owedToFed; //gross * calculated tax percentage
        private double refund; //complete!!!!!!!!!!!!!!!!!!!!!!!!!
        private double penalty; //done!!!!!!!!
        private TaxPayerInfoInput taxPayerForm;
        private List<Person> myList;
        private TaxInfo3 form3;
        private static int i; //iterates every time to keep track of which person in list

        public CalculationDisplay()
        {
            
            InitializeComponent();
            
            //PROBLEM IS I CANT READ THE LIST FROM LISTPERSON CLASS solved 2/21/2017 10:57PM called ListPerson static // solved!!!!
            myList = CreatePersonList.GetList();

            i = myList.Count() - 1;

            myList[i].setAdjustedGrossIn(); // does the first calculation to get the ball rolling on the others
            
            amountWithHeld = myList[i].getFedWithHold(); // direct from w2

            calculatedTax = myList[i].getTaxBracket(myList[i].getAdjustedGrossIn()); //FIND A NEATER WAY OR LEAVE IT **IT WORKS**

            owedToFed = myList[i].taxesOwed(myList[i].getAdjustedGrossIn(), calculatedTax); 

            refund = myList[i].taxRefund(myList[i].getAdjustedGrossIn(), calculatedTax);

            penalty = myList[i].penaltyBox(owedToFed, amountWithHeld);

            setForm2();
            
        }



        public void Form2_Load(object sender, EventArgs e)
        {
            taxPayerForm.Visible = false;
        }

        public void setForm2()
        {
            adjustedTB.Text = Convert.ToString( myList[i].getGrossEarn().ToString("c"));

            amountWithHeldTB.Text = Convert.ToString(amountWithHeld.ToString("c"));

            calculatedTaxTB.Text = Convert.ToString(calculatedTax.ToString("c"));

            owedToFedTB.Text = Convert.ToString(owedToFed.ToString("c"));

            refundTB.Text = Convert.ToString(refund.ToString("c"));

            penaltyTB.Text = Convert.ToString(penalty.ToString("c"));

        }

        public void nextBtn_Click(object sender, EventArgs e)
        {
            this.Close();

            form3 = new TaxInfo3();

            form3.Focus();

        }

    }
}

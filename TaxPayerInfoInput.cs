/**
 * Programmer: James Sacchetti
 * Program: Distrubo Tax
 * Professor: Arland Richmond
 * Last Modified: 2/22/2017
***/


using System;
using System.Collections;
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

    public partial class TaxPayerInfoInput : Form
    {
        //private ListPerson person;
        private Person individual;
        private CalculationDisplay form2;

        public TaxPayerInfoInput()
        {

            InitializeComponent();
        }

       
        private void nextBtn_Click(object sender, EventArgs e)
        {
            bool exceptionThrown = false; //set to true in the catches so we dont run form2 if a exception is thrown  

            individual = new Person();
            
            //for neatness of code nested try catch is single lined, preference of programmer. 
            //first ever "throw nem exception" if this is used wrong let me know obviously
            try { if (!isStringNull(nameTB.Text.ToString())) { throw new Exception(); } else individual.setName(nameTB.Text.ToString()); }
            catch (Exception) { MessageBox.Show("Name field invalid, enter \"firstname lastname\"", "Invalid Field", MessageBoxButtons.OK); exceptionThrown = true; }
            
            try { if (!isStringNull(addressTB.Text.ToString())) { throw new Exception(); } else individual.setAddress(addressTB.Text.ToString()); }
            catch (Exception) { MessageBox.Show("Address field empty", "Invalid Field", MessageBoxButtons.OK); exceptionThrown = true; }
            
            try { if (!isStringNull(cityTB.Text.ToString())) { throw new Exception(); } else individual.setCity(cityTB.Text.ToString());  }
            catch (Exception) { MessageBox.Show("City field empty", "Invalid Field", MessageBoxButtons.OK); exceptionThrown = true; }
            
            try { if (!isStringNull(stateTB.Text.ToString())) { throw new Exception(); } else individual.setState(stateTB.Text.ToString()); }
            catch (Exception) { MessageBox.Show("State field empty", "Invalid Field", MessageBoxButtons.OK); exceptionThrown = true; }
            
            try { individual.setSSN(int.Parse(ssnTB.Text.ToString())); }
            catch (Exception) { MessageBox.Show("SSN field empty.", "Invalid Field", MessageBoxButtons.OK); exceptionThrown = true; }
            
            try { individual.setZip(int.Parse(zipCodeTB.Text.ToString())); }
            catch (Exception) { MessageBox.Show("ZipCode field empty", "Invalid Field", MessageBoxButtons.OK); exceptionThrown = true; }
            
            try { individual.setNumExep(int.Parse(exemptionTB.Text.ToString())); }
            catch (Exception) { MessageBox.Show("Excemption field empty", "Invalid Field", MessageBoxButtons.OK); exceptionThrown = true; }
            
            try { individual.setGrossEarn(double.Parse(grossEarnTB.Text.ToString())); }
            catch (Exception) { MessageBox.Show("Gross Income field empty", "Invalid Field", MessageBoxButtons.OK); exceptionThrown = true; }
            
            try { individual.setCapitalGain(double.Parse(capitalGainTB.Text.ToString())); }
            catch (Exception) { MessageBox.Show("Capital Gain field empty", "Invalid Field", MessageBoxButtons.OK); exceptionThrown = true; }
            
            try { individual.setRealEstate(double.Parse(realEstateTB.Text.ToString())); }
            catch (Exception) { MessageBox.Show("Realestate Field field empty", "Invalid Field", MessageBoxButtons.OK); exceptionThrown = true; }
            
            try { individual.setExciseTax(double.Parse(exciseTaxTB.Text.ToString())); }
            catch (Exception) { MessageBox.Show("Excise tax field empty", "Invalid Field", MessageBoxButtons.OK); exceptionThrown = true; }
            
            try { individual.setMedicalExpen(double.Parse(medicalExpenTB.Text.ToString())); }
            catch (Exception) { MessageBox.Show("Medical Expense field empty", "Invalid Field", MessageBoxButtons.OK); exceptionThrown = true; }
            
            try { individual.setFedWithHold(double.Parse(fedTaxTB.Text.ToString())); }
            catch (Exception) { MessageBox.Show("Fed Withholding field empty", "Invalid Field", MessageBoxButtons.OK); exceptionThrown = true; }

            //if exception thrown, by way of bool we dont run the second screen; exception thrown set to true in the catch blocks
            if (exceptionThrown == false)
            {
                CreatePersonList.person.Add(individual);
                this.Close(); // closes 
                form2 = new CalculationDisplay();
                form2.Focus();//calls to focus form 2
            }
        }

        private bool isStringNull(string ckString) // wasn't sure how else to do it so I rigged it
        {
            bool isNull = false; //false if "" true i
            if (ckString != "" && ckString != " ")
            {
                isNull = true;
            }
            return isNull;
        }
        
        public void quitBtn_Click(object sender, EventArgs e)
        {

            DialogResult result1 = MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.YesNo);
            if (result1.ToString() == "Yes")
            {
                Program.keepON = false; //sets the varible in main() to false so we exit with no problem... without it the program trys to read input from the text boxes
                Application.Exit();
            }
                
        }

        private void TaxPayerInfoInput_Load(object sender, EventArgs e)
        {

        }

        private void exemptionTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }
    }
}

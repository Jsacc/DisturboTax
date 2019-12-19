/**
 * Programmer: James Sacchetti
 * Program: Distrubo Tax
 * Professor: Arland Richmond
 * Last Modified: 2/23/2017
***/

using System;
using System.Collections.Generic;
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
    public class Person
    {
        private int ssn, zip, amountOwed, refundAmount, numExep;

        private double
            grossEarn, capitalGain, realEstate,
            exciseTax, medicalExpen, fedWithHold;

        private string firstName, lastName, address, city, state;

        public Person() {
            firstName = null; lastName = null;  
            address = null; city = null; state = null;
        }

        private double adjustedGrossIn; // from doCalculation();

        
        public double getAdjustedGrossIn()
        {
            return adjustedGrossIn;
        }

        public void setNumExep(int numExep)
        {

            this.numExep = numExep;

        }

        public int getNumExep()
        {
            return numExep;
        }


        public void setFedWithHold(double fedWithHold)
        {

            this.fedWithHold = fedWithHold;

        }

        public double getFedWithHold()
        {
            return fedWithHold;
        }

        public void setMedicalExpen(double medicalExpen)
        {
            this.medicalExpen = medicalExpen;
        }

        public double getMedicalExpen()
        {
            return medicalExpen;
        }

        public void setExciseTax(double exciseTax)
        {
            this.exciseTax = exciseTax;
        }

        public double getExciseTax()
        {
            return exciseTax;
        }


        public void setCapitalGain(double capitalGain)
        {
            this.capitalGain = capitalGain;
        }

        public double getCapitalGain()
        {
        
            return capitalGain;

        }

        public void setRealEstate(double realEstate)
        {

            this.realEstate = realEstate;

        }

        public double getRealEstate()
        {
            
            return realEstate;
        
        }


        public void setGrossEarn(double grossEarn)
        {
            this.grossEarn = grossEarn;
        }

        public double getGrossEarn()
        {
            return grossEarn;
        }

        public void setState(string state)
        {
            this.state = state;
        }

        public string getState()
        {
            return state;
        }

        public void setCity(string city)
        {
            this.city = city;
        }

        public string getCity()
        {
            return city;
        }

        public void setAddress(string address)
        {
            this.address = address;
        }

        public string getAddress()
        {
            return address;
        }

        public void setName(string name)// set value for person class
        {
            string[] firstLastName = splitName(name);
            
            this.firstName = firstLastName[0];
            this.lastName = firstLastName[1];
        }

        public string[] splitName(string fullName)
        {
            string[] names = fullName.Split(' ');
            return names;
        }

        public string getFirstName()//returns value for form 3
        {
            return firstName;
        }

        public string getLastName()//returns value for form 3
        {
            return lastName;
        }

        public void setZip(int zip)//set value for zip
        {
            this.zip = zip;
        }

        public int getZip(int zip) //return zip
        {
            return zip;
        }

        public void setSSN(int ssn)// set value for person class
        {
            this.ssn = ssn;
        }

        public int getSSN()//returns value for form 3
        {
            return ssn;
        }

        public void setAmountOwed(int amountOwed)// set value for person class
        {
            this.amountOwed = amountOwed;
        }

        public int getAmountOwed()//returns value for form 3
        {
            return amountOwed;
        }

        public void setRefundAmount(int refundAmount)// set value for person class
        {
            this.refundAmount = refundAmount;
        }

        public int getRefundAmount()//returns value for form 3
        {
            return refundAmount;
        }

        public void setAdjustedGrossIn()
        {
            double capVal = 0.00;

            if (capitalGain > 0.00) // do this calculation makes it easier to work with
            {
                capVal += capitalGain * .015;
            }
            else
            {
                capVal -= capitalGain * .015;              
            }

            adjustedGrossIn = Math.Round(((grossEarn) - ((Convert.ToDouble((numExep * 1000.00)
                + (medicalExpen * 0.08) + (realEstate * 0.25) + (exciseTax * 0.25)) + capVal))));

        }

        public double getTaxBracket(double gross) //why return the bracket find the amount paid 
        {
            double taxPaid;
            if (gross >= 0 && gross < 1000)
                taxPaid = gross * 0.10;
            else if (gross >= 1000 && gross < 10000)
                taxPaid = gross * 0.15;
            else if (gross >= 10000 && gross < 20000)
                taxPaid = gross * 0.20;
            else if (gross >= 20000 && gross < 30000)
                taxPaid = gross * 0.25;
            else
                taxPaid = gross * 0.28;

            return taxPaid;
        }

        public double taxesOwed(double gross, double taxPay)
        {
            double amountOwed;
            if (taxPay > gross)
                amountOwed = (taxPay - gross);
            else
                amountOwed = 0;
            return amountOwed;
        }

        public double taxRefund(double gross, double taxPay)
        {
            double refund;
            if (taxPay < gross)
                refund = (gross - taxPay);
            else
                refund = 0;
            return refund;

        }

        public double penaltyBox(double taxPaid, double taxWithheld)
        {
            double penalty;
            if (taxPaid > taxWithheld)
                penalty = 0.01 * (taxPaid - taxWithheld);
            else
                penalty = 0.01 * (taxWithheld - taxPaid);

            return penalty;
        }



    }
}

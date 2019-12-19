/**
 * Programmer: James Sacchetti
 * Program: Distrubo Tax
 * Professor: Arland Richmond
 * Last Modified: 2/22/2017
***/

using System;
using System.Collections.Generic;
using System.Linq;
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
    static class Program
    {
        public static bool keepON = true; //'keepOn' flag originally just for 3rd form add but used to exit as well 
                                          //so we skip running the rest when quit is hit 


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            while(keepON)// set from form 3 and 1. It allows user to add more taxrecords or exit 
            {
                Application.Run(new TaxPayerInfoInput());
                if (keepON) // rigged there has to be a better way to quit fRom fOrm 1 w/o error  
                            //which is because form 2 ("calculationDisplay") runs while input fields are blank
                            // **THought but functions add more lines!
                {
                    Application.Run(new CalculationDisplay());
                    Application.Run(new TaxInfo3());
                }
            } 
            Application.Exit();
        }
    }
}

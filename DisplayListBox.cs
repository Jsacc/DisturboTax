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
            MessageBox.Show(String.Format("{0:000-00-0000}", CreatePersonList.person[listBox1.SelectedIndex].getSSN() 
                +'\n'+ CreatePersonList.person[listBox1.SelectedIndex].getName() + "\n" + owe_Refund(listBox1.SelectedIndex)));
        }

        public void quitBtn_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.YesNo);
            if (result1.ToString() == "Yes")
            {
                CreatePersonList.person.Clear();
                System.Environment.Exit(1);

            }

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
                return CreatePersonList.person[i].getAmountOwed().ToString();
            else
                return CreatePersonList.person[i].getRefundAmount().ToString();
        }

        public void addTolistView() //adds to the listbox in form 3, was previously a 'ListView' hence the function name waste of money to change it
        { // b4 it comes back here the list is sorted in ListPeron class


            for (int j = 0; j < CreatePersonList.person.Count(); j++)
            {
                listBox1.Items.Add((String.Format("{0:000-00-0000}", CreatePersonList.person[j].getSSN() 
                 + CreatePersonList.person[j].getName() + " " + " " + owe_Refund(j))));//displays ssn in real form
            }
        }
    }
}

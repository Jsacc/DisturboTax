/**
 * Programmer: James Sacchetti
 * Program: Distrubo Tax
 * Professor: Arland Richmond
 * Last Modified: 2/22/2017
***/

namespace Project_1_DisturboTax
{
    partial class TaxPayerInfoInput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaxPayerInfoInput));
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelZipCode = new System.Windows.Forms.Label();
            this.labelSSN = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.cityTB = new System.Windows.Forms.TextBox();
            this.stateTB = new System.Windows.Forms.TextBox();
            this.zipCodeTB = new System.Windows.Forms.TextBox();
            this.ssnTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelGrossEarn = new System.Windows.Forms.Label();
            this.labelFedTax = new System.Windows.Forms.Label();
            this.labelCapitalGain = new System.Windows.Forms.Label();
            this.labelRealEstate = new System.Windows.Forms.Label();
            this.exemptionTB = new System.Windows.Forms.TextBox();
            this.grossEarnTB = new System.Windows.Forms.TextBox();
            this.fedTaxTB = new System.Windows.Forms.TextBox();
            this.capitalGainTB = new System.Windows.Forms.TextBox();
            this.realEstateTB = new System.Windows.Forms.TextBox();
            this.labelExcise = new System.Windows.Forms.Label();
            this.labelMedical = new System.Windows.Forms.Label();
            this.exciseTaxTB = new System.Windows.Forms.TextBox();
            this.medicalExpenTB = new System.Windows.Forms.TextBox();
            this.nextBTN = new System.Windows.Forms.Button();
            this.quitBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(31, 47);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(31, 89);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(58, 15);
            this.labelAddress.TabIndex = 1;
            this.labelAddress.Text = "Address:";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.BackColor = System.Drawing.Color.Transparent;
            this.labelCity.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.Location = new System.Drawing.Point(31, 131);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(34, 15);
            this.labelCity.TabIndex = 2;
            this.labelCity.Text = "City:";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.BackColor = System.Drawing.Color.Transparent;
            this.labelState.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelState.Location = new System.Drawing.Point(31, 174);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(43, 15);
            this.labelState.TabIndex = 3;
            this.labelState.Text = "State:";
            // 
            // labelZipCode
            // 
            this.labelZipCode.AutoSize = true;
            this.labelZipCode.BackColor = System.Drawing.Color.Transparent;
            this.labelZipCode.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZipCode.Location = new System.Drawing.Point(226, 28);
            this.labelZipCode.Name = "labelZipCode";
            this.labelZipCode.Size = new System.Drawing.Size(60, 15);
            this.labelZipCode.TabIndex = 4;
            this.labelZipCode.Text = "Zip Code:";
            // 
            // labelSSN
            // 
            this.labelSSN.AutoSize = true;
            this.labelSSN.BackColor = System.Drawing.Color.Transparent;
            this.labelSSN.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSSN.Location = new System.Drawing.Point(226, 71);
            this.labelSSN.Name = "labelSSN";
            this.labelSSN.Size = new System.Drawing.Size(145, 15);
            this.labelSSN.TabIndex = 5;
            this.labelSSN.Text = "Social Security Number:";
            // 
            // nameTB
            // 
            this.nameTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTB.Location = new System.Drawing.Point(31, 67);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(139, 20);
            this.nameTB.TabIndex = 6;
            // 
            // addressTB
            // 
            this.addressTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addressTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressTB.Location = new System.Drawing.Point(31, 108);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(139, 20);
            this.addressTB.TabIndex = 7;
            // 
            // cityTB
            // 
            this.cityTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cityTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cityTB.Location = new System.Drawing.Point(31, 151);
            this.cityTB.Name = "cityTB";
            this.cityTB.Size = new System.Drawing.Size(139, 20);
            this.cityTB.TabIndex = 8;
            // 
            // stateTB
            // 
            this.stateTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.stateTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stateTB.Location = new System.Drawing.Point(31, 194);
            this.stateTB.Name = "stateTB";
            this.stateTB.Size = new System.Drawing.Size(139, 20);
            this.stateTB.TabIndex = 9;
            // 
            // zipCodeTB
            // 
            this.zipCodeTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.zipCodeTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zipCodeTB.Location = new System.Drawing.Point(226, 48);
            this.zipCodeTB.Name = "zipCodeTB";
            this.zipCodeTB.Size = new System.Drawing.Size(139, 20);
            this.zipCodeTB.TabIndex = 10;
            // 
            // ssnTB
            // 
            this.ssnTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ssnTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ssnTB.Location = new System.Drawing.Point(226, 91);
            this.ssnTB.Name = "ssnTB";
            this.ssnTB.Size = new System.Drawing.Size(139, 20);
            this.ssnTB.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(226, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Number Exemptions:";
            // 
            // labelGrossEarn
            // 
            this.labelGrossEarn.AutoSize = true;
            this.labelGrossEarn.BackColor = System.Drawing.Color.Transparent;
            this.labelGrossEarn.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrossEarn.Location = new System.Drawing.Point(226, 155);
            this.labelGrossEarn.Name = "labelGrossEarn";
            this.labelGrossEarn.Size = new System.Drawing.Size(96, 15);
            this.labelGrossEarn.TabIndex = 13;
            this.labelGrossEarn.Text = "Gross Earnings:";
            // 
            // labelFedTax
            // 
            this.labelFedTax.AutoSize = true;
            this.labelFedTax.BackColor = System.Drawing.Color.Transparent;
            this.labelFedTax.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFedTax.Location = new System.Drawing.Point(226, 198);
            this.labelFedTax.Name = "labelFedTax";
            this.labelFedTax.Size = new System.Drawing.Size(129, 15);
            this.labelFedTax.TabIndex = 14;
            this.labelFedTax.Text = "Federal Tax Withheld:";
            // 
            // labelCapitalGain
            // 
            this.labelCapitalGain.AutoSize = true;
            this.labelCapitalGain.BackColor = System.Drawing.Color.Transparent;
            this.labelCapitalGain.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCapitalGain.Location = new System.Drawing.Point(409, 51);
            this.labelCapitalGain.Name = "labelCapitalGain";
            this.labelCapitalGain.Size = new System.Drawing.Size(85, 15);
            this.labelCapitalGain.TabIndex = 15;
            this.labelCapitalGain.Text = "Capital Gains:";
            // 
            // labelRealEstate
            // 
            this.labelRealEstate.AutoSize = true;
            this.labelRealEstate.BackColor = System.Drawing.Color.Transparent;
            this.labelRealEstate.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRealEstate.Location = new System.Drawing.Point(409, 94);
            this.labelRealEstate.Name = "labelRealEstate";
            this.labelRealEstate.Size = new System.Drawing.Size(76, 15);
            this.labelRealEstate.TabIndex = 16;
            this.labelRealEstate.Text = "Real Estate:";
            // 
            // exemptionTB
            // 
            this.exemptionTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.exemptionTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exemptionTB.Location = new System.Drawing.Point(226, 132);
            this.exemptionTB.Name = "exemptionTB";
            this.exemptionTB.Size = new System.Drawing.Size(139, 20);
            this.exemptionTB.TabIndex = 21;
            // 
            // grossEarnTB
            // 
            this.grossEarnTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grossEarnTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grossEarnTB.Location = new System.Drawing.Point(226, 175);
            this.grossEarnTB.Name = "grossEarnTB";
            this.grossEarnTB.Size = new System.Drawing.Size(139, 20);
            this.grossEarnTB.TabIndex = 22;
            // 
            // fedTaxTB
            // 
            this.fedTaxTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fedTaxTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fedTaxTB.Location = new System.Drawing.Point(226, 218);
            this.fedTaxTB.Name = "fedTaxTB";
            this.fedTaxTB.Size = new System.Drawing.Size(139, 20);
            this.fedTaxTB.TabIndex = 23;
            // 
            // capitalGainTB
            // 
            this.capitalGainTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.capitalGainTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.capitalGainTB.Location = new System.Drawing.Point(409, 71);
            this.capitalGainTB.Name = "capitalGainTB";
            this.capitalGainTB.Size = new System.Drawing.Size(139, 20);
            this.capitalGainTB.TabIndex = 24;
            // 
            // realEstateTB
            // 
            this.realEstateTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.realEstateTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.realEstateTB.Location = new System.Drawing.Point(409, 114);
            this.realEstateTB.Name = "realEstateTB";
            this.realEstateTB.Size = new System.Drawing.Size(139, 20);
            this.realEstateTB.TabIndex = 25;
            // 
            // labelExcise
            // 
            this.labelExcise.AutoSize = true;
            this.labelExcise.BackColor = System.Drawing.Color.Transparent;
            this.labelExcise.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExcise.Location = new System.Drawing.Point(409, 137);
            this.labelExcise.Name = "labelExcise";
            this.labelExcise.Size = new System.Drawing.Size(69, 15);
            this.labelExcise.TabIndex = 26;
            this.labelExcise.Text = "Excise Tax:";
            // 
            // labelMedical
            // 
            this.labelMedical.AutoSize = true;
            this.labelMedical.BackColor = System.Drawing.Color.Transparent;
            this.labelMedical.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedical.Location = new System.Drawing.Point(409, 178);
            this.labelMedical.Name = "labelMedical";
            this.labelMedical.Size = new System.Drawing.Size(112, 15);
            this.labelMedical.TabIndex = 27;
            this.labelMedical.Text = "Medical Expenses:";
            // 
            // exciseTaxTB
            // 
            this.exciseTaxTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.exciseTaxTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exciseTaxTB.Location = new System.Drawing.Point(409, 155);
            this.exciseTaxTB.Name = "exciseTaxTB";
            this.exciseTaxTB.Size = new System.Drawing.Size(139, 20);
            this.exciseTaxTB.TabIndex = 28;
            // 
            // medicalExpenTB
            // 
            this.medicalExpenTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.medicalExpenTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.medicalExpenTB.Location = new System.Drawing.Point(409, 198);
            this.medicalExpenTB.Name = "medicalExpenTB";
            this.medicalExpenTB.Size = new System.Drawing.Size(139, 20);
            this.medicalExpenTB.TabIndex = 29;
            // 
            // nextBTN
            // 
            this.nextBTN.Location = new System.Drawing.Point(162, 260);
            this.nextBTN.Name = "nextBTN";
            this.nextBTN.Size = new System.Drawing.Size(75, 23);
            this.nextBTN.TabIndex = 30;
            this.nextBTN.Text = "&Next";
            this.nextBTN.UseVisualStyleBackColor = true;
            this.nextBTN.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // quitBTN
            // 
            this.quitBTN.Location = new System.Drawing.Point(353, 260);
            this.quitBTN.Name = "quitBTN";
            this.quitBTN.Size = new System.Drawing.Size(75, 23);
            this.quitBTN.TabIndex = 32;
            this.quitBTN.Text = "&Quit";
            this.quitBTN.UseVisualStyleBackColor = true;
            this.quitBTN.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // TaxPayerInfoInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(593, 321);
            this.ControlBox = false;
            this.Controls.Add(this.quitBTN);
            this.Controls.Add(this.nextBTN);
            this.Controls.Add(this.medicalExpenTB);
            this.Controls.Add(this.exciseTaxTB);
            this.Controls.Add(this.labelMedical);
            this.Controls.Add(this.labelExcise);
            this.Controls.Add(this.realEstateTB);
            this.Controls.Add(this.capitalGainTB);
            this.Controls.Add(this.fedTaxTB);
            this.Controls.Add(this.grossEarnTB);
            this.Controls.Add(this.exemptionTB);
            this.Controls.Add(this.labelRealEstate);
            this.Controls.Add(this.labelCapitalGain);
            this.Controls.Add(this.labelFedTax);
            this.Controls.Add(this.labelGrossEarn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ssnTB);
            this.Controls.Add(this.zipCodeTB);
            this.Controls.Add(this.stateTB);
            this.Controls.Add(this.cityTB);
            this.Controls.Add(this.addressTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.labelSSN);
            this.Controls.Add(this.labelZipCode);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelName);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Name = "TaxPayerInfoInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disturbo Tax 1.0";
            this.Load += new System.EventHandler(this.TaxPayerInfoInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelZipCode;
        private System.Windows.Forms.Label labelSSN;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.TextBox cityTB;
        private System.Windows.Forms.TextBox stateTB;
        private System.Windows.Forms.TextBox zipCodeTB;
        private System.Windows.Forms.TextBox ssnTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelGrossEarn;
        private System.Windows.Forms.Label labelFedTax;
        private System.Windows.Forms.Label labelCapitalGain;
        private System.Windows.Forms.Label labelRealEstate;
        private System.Windows.Forms.TextBox exemptionTB;
        private System.Windows.Forms.TextBox grossEarnTB;
        private System.Windows.Forms.TextBox fedTaxTB;
        private System.Windows.Forms.TextBox capitalGainTB;
        private System.Windows.Forms.TextBox realEstateTB;
        private System.Windows.Forms.Label labelExcise;
        private System.Windows.Forms.Label labelMedical;
        private System.Windows.Forms.TextBox exciseTaxTB;
        private System.Windows.Forms.TextBox medicalExpenTB;
        private System.Windows.Forms.Button nextBTN;
        private System.Windows.Forms.Button quitBTN;
    }
}


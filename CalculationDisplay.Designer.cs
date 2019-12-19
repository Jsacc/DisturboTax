/**
 * Programmer: James Sacchetti
 * Program: Distrubo Tax
 * Professor: Arland Richmond
 * Last Modified: 2/22/2017
***/

namespace Project_1_DisturboTax
{
    partial class CalculationDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculationDisplay));
            this.grossAdjustLB = new System.Windows.Forms.Label();
            this.calculatedTaxLB = new System.Windows.Forms.Label();
            this.w2WithheldLB = new System.Windows.Forms.Label();
            this.penaltyLB = new System.Windows.Forms.Label();
            this.taxOwedLB = new System.Windows.Forms.Label();
            this.refundLB = new System.Windows.Forms.Label();
            this.adjustedTB = new System.Windows.Forms.TextBox();
            this.calculatedTaxTB = new System.Windows.Forms.TextBox();
            this.penaltyTB = new System.Windows.Forms.TextBox();
            this.amountWithHeldTB = new System.Windows.Forms.TextBox();
            this.owedToFedTB = new System.Windows.Forms.TextBox();
            this.refundTB = new System.Windows.Forms.TextBox();
            this.nextBTNform2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grossAdjustLB
            // 
            this.grossAdjustLB.AutoSize = true;
            this.grossAdjustLB.BackColor = System.Drawing.Color.Transparent;
            this.grossAdjustLB.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.grossAdjustLB.Location = new System.Drawing.Point(89, 70);
            this.grossAdjustLB.Name = "grossAdjustLB";
            this.grossAdjustLB.Size = new System.Drawing.Size(93, 15);
            this.grossAdjustLB.TabIndex = 0;
            this.grossAdjustLB.Text = "Adjusted Gross";
            // 
            // calculatedTaxLB
            // 
            this.calculatedTaxLB.AutoSize = true;
            this.calculatedTaxLB.BackColor = System.Drawing.Color.Transparent;
            this.calculatedTaxLB.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.calculatedTaxLB.Location = new System.Drawing.Point(286, 125);
            this.calculatedTaxLB.Name = "calculatedTaxLB";
            this.calculatedTaxLB.Size = new System.Drawing.Size(92, 15);
            this.calculatedTaxLB.TabIndex = 1;
            this.calculatedTaxLB.Text = "Amount of Tax ";
            // 
            // w2WithheldLB
            // 
            this.w2WithheldLB.AutoSize = true;
            this.w2WithheldLB.BackColor = System.Drawing.Color.Transparent;
            this.w2WithheldLB.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.w2WithheldLB.Location = new System.Drawing.Point(286, 183);
            this.w2WithheldLB.Name = "w2WithheldLB";
            this.w2WithheldLB.Size = new System.Drawing.Size(196, 15);
            this.w2WithheldLB.TabIndex = 2;
            this.w2WithheldLB.Text = "Amount of Tax Withheld from W-2";
            // 
            // penaltyLB
            // 
            this.penaltyLB.AutoSize = true;
            this.penaltyLB.BackColor = System.Drawing.Color.Transparent;
            this.penaltyLB.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.penaltyLB.Location = new System.Drawing.Point(89, 125);
            this.penaltyLB.Name = "penaltyLB";
            this.penaltyLB.Size = new System.Drawing.Size(50, 15);
            this.penaltyLB.TabIndex = 3;
            this.penaltyLB.Text = "Penalty";
            // 
            // taxOwedLB
            // 
            this.taxOwedLB.AutoSize = true;
            this.taxOwedLB.BackColor = System.Drawing.Color.Transparent;
            this.taxOwedLB.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.taxOwedLB.Location = new System.Drawing.Point(286, 70);
            this.taxOwedLB.Name = "taxOwedLB";
            this.taxOwedLB.Size = new System.Drawing.Size(217, 15);
            this.taxOwedLB.TabIndex = 4;
            this.taxOwedLB.Text = "Tax owed to the Federal Government";
            // 
            // refundLB
            // 
            this.refundLB.AutoSize = true;
            this.refundLB.BackColor = System.Drawing.Color.Transparent;
            this.refundLB.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.refundLB.Location = new System.Drawing.Point(89, 183);
            this.refundLB.Name = "refundLB";
            this.refundLB.Size = new System.Drawing.Size(73, 15);
            this.refundLB.TabIndex = 5;
            this.refundLB.Text = "Refund Due";
            // 
            // adjustedTB
            // 
            this.adjustedTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.adjustedTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adjustedTB.Location = new System.Drawing.Point(92, 88);
            this.adjustedTB.Name = "adjustedTB";
            this.adjustedTB.ReadOnly = true;
            this.adjustedTB.Size = new System.Drawing.Size(100, 20);
            this.adjustedTB.TabIndex = 1;
            this.adjustedTB.TabStop = false;
            // 
            // calculatedTaxTB
            // 
            this.calculatedTaxTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.calculatedTaxTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.calculatedTaxTB.Location = new System.Drawing.Point(289, 145);
            this.calculatedTaxTB.Name = "calculatedTaxTB";
            this.calculatedTaxTB.ReadOnly = true;
            this.calculatedTaxTB.Size = new System.Drawing.Size(100, 20);
            this.calculatedTaxTB.TabIndex = 4;
            this.calculatedTaxTB.TabStop = false;
            // 
            // penaltyTB
            // 
            this.penaltyTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.penaltyTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.penaltyTB.Location = new System.Drawing.Point(92, 145);
            this.penaltyTB.Name = "penaltyTB";
            this.penaltyTB.ReadOnly = true;
            this.penaltyTB.Size = new System.Drawing.Size(100, 20);
            this.penaltyTB.TabIndex = 3;
            this.penaltyTB.TabStop = false;
            // 
            // amountWithHeldTB
            // 
            this.amountWithHeldTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.amountWithHeldTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amountWithHeldTB.Location = new System.Drawing.Point(289, 201);
            this.amountWithHeldTB.Name = "amountWithHeldTB";
            this.amountWithHeldTB.ReadOnly = true;
            this.amountWithHeldTB.Size = new System.Drawing.Size(100, 20);
            this.amountWithHeldTB.TabIndex = 6;
            this.amountWithHeldTB.TabStop = false;
            // 
            // owedToFedTB
            // 
            this.owedToFedTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.owedToFedTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.owedToFedTB.Location = new System.Drawing.Point(289, 88);
            this.owedToFedTB.Name = "owedToFedTB";
            this.owedToFedTB.ReadOnly = true;
            this.owedToFedTB.Size = new System.Drawing.Size(100, 20);
            this.owedToFedTB.TabIndex = 2;
            this.owedToFedTB.TabStop = false;
            // 
            // refundTB
            // 
            this.refundTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.refundTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.refundTB.Location = new System.Drawing.Point(92, 201);
            this.refundTB.Name = "refundTB";
            this.refundTB.ReadOnly = true;
            this.refundTB.Size = new System.Drawing.Size(100, 20);
            this.refundTB.TabIndex = 5;
            this.refundTB.TabStop = false;
            // 
            // nextBTNform2
            // 
            this.nextBTNform2.Location = new System.Drawing.Point(207, 244);
            this.nextBTNform2.Name = "nextBTNform2";
            this.nextBTNform2.Size = new System.Drawing.Size(75, 23);
            this.nextBTNform2.TabIndex = 7;
            this.nextBTNform2.Text = "&Next";
            this.nextBTNform2.UseVisualStyleBackColor = true;
            this.nextBTNform2.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // CalculationDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(510, 299);
            this.ControlBox = false;
            this.Controls.Add(this.nextBTNform2);
            this.Controls.Add(this.refundTB);
            this.Controls.Add(this.owedToFedTB);
            this.Controls.Add(this.amountWithHeldTB);
            this.Controls.Add(this.penaltyTB);
            this.Controls.Add(this.calculatedTaxTB);
            this.Controls.Add(this.adjustedTB);
            this.Controls.Add(this.refundLB);
            this.Controls.Add(this.taxOwedLB);
            this.Controls.Add(this.penaltyLB);
            this.Controls.Add(this.w2WithheldLB);
            this.Controls.Add(this.calculatedTaxLB);
            this.Controls.Add(this.grossAdjustLB);
            this.Name = "CalculationDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Results";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label grossAdjustLB;
        private System.Windows.Forms.Label calculatedTaxLB;
        private System.Windows.Forms.Label w2WithheldLB;
        private System.Windows.Forms.Label penaltyLB;
        private System.Windows.Forms.Label taxOwedLB;
        private System.Windows.Forms.Label refundLB;
        private System.Windows.Forms.TextBox adjustedTB;
        private System.Windows.Forms.TextBox calculatedTaxTB;
        private System.Windows.Forms.TextBox penaltyTB;
        private System.Windows.Forms.TextBox amountWithHeldTB;
        private System.Windows.Forms.TextBox owedToFedTB;
        private System.Windows.Forms.TextBox refundTB;
        private System.Windows.Forms.Button nextBTNform2;
    }
}
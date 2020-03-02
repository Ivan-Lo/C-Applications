namespace CPRG200LAB1IVAN
{
    partial class frmPower
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radIndustrial = new System.Windows.Forms.RadioButton();
            this.radCommercial = new System.Windows.Forms.RadioButton();
            this.radResidential = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCalculatedCharge = new System.Windows.Forms.Label();
            this.txtKwhUsed = new System.Windows.Forms.TextBox();
            this.lblKwh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPeak = new System.Windows.Forms.Label();
            this.lblOffPeak = new System.Windows.Forms.Label();
            this.txtPeak = new System.Windows.Forms.TextBox();
            this.txtOffPeak = new System.Windows.Forms.TextBox();
            this.lstList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblTotalCustomers = new System.Windows.Forms.Label();
            this.lblResidentialCharge = new System.Windows.Forms.Label();
            this.lblTotalCharge = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCustomerType = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCommercialCharge = new System.Windows.Forms.Label();
            this.lblIndustrialCharge = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radIndustrial);
            this.groupBox1.Controls.Add(this.radCommercial);
            this.groupBox1.Controls.Add(this.radResidential);
            this.groupBox1.Location = new System.Drawing.Point(24, 135);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Size = new System.Drawing.Size(319, 402);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Type:";
            // 
            // radIndustrial
            // 
            this.radIndustrial.AutoSize = true;
            this.radIndustrial.Location = new System.Drawing.Point(37, 281);
            this.radIndustrial.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.radIndustrial.Name = "radIndustrial";
            this.radIndustrial.Size = new System.Drawing.Size(131, 33);
            this.radIndustrial.TabIndex = 2;
            this.radIndustrial.TabStop = true;
            this.radIndustrial.Text = "Industrial";
            this.radIndustrial.UseVisualStyleBackColor = true;
            this.radIndustrial.CheckedChanged += new System.EventHandler(this.radIndustrial_CheckedChanged);
            // 
            // radCommercial
            // 
            this.radCommercial.AutoSize = true;
            this.radCommercial.Location = new System.Drawing.Point(37, 183);
            this.radCommercial.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.radCommercial.Name = "radCommercial";
            this.radCommercial.Size = new System.Drawing.Size(164, 33);
            this.radCommercial.TabIndex = 1;
            this.radCommercial.Text = "Commerical";
            this.radCommercial.UseVisualStyleBackColor = true;
            this.radCommercial.CheckedChanged += new System.EventHandler(this.radCommercial_CheckedChanged);
            // 
            // radResidential
            // 
            this.radResidential.AutoSize = true;
            this.radResidential.Checked = true;
            this.radResidential.Location = new System.Drawing.Point(37, 93);
            this.radResidential.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.radResidential.Name = "radResidential";
            this.radResidential.Size = new System.Drawing.Size(155, 33);
            this.radResidential.TabIndex = 0;
            this.radResidential.TabStop = true;
            this.radResidential.Text = "Residential";
            this.radResidential.UseVisualStyleBackColor = true;
            this.radResidential.CheckedChanged += new System.EventHandler(this.radResidential_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(24, 722);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(192, 63);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(24, 651);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(192, 63);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(24, 580);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(192, 63);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 722);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Calculated Charge:";
            // 
            // lblCalculatedCharge
            // 
            this.lblCalculatedCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCalculatedCharge.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculatedCharge.Location = new System.Drawing.Point(506, 694);
            this.lblCalculatedCharge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalculatedCharge.Name = "lblCalculatedCharge";
            this.lblCalculatedCharge.Size = new System.Drawing.Size(268, 74);
            this.lblCalculatedCharge.TabIndex = 13;
            this.lblCalculatedCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKwhUsed
            // 
            this.txtKwhUsed.Location = new System.Drawing.Point(493, 564);
            this.txtKwhUsed.Margin = new System.Windows.Forms.Padding(4);
            this.txtKwhUsed.Name = "txtKwhUsed";
            this.txtKwhUsed.Size = new System.Drawing.Size(91, 34);
            this.txtKwhUsed.TabIndex = 12;
            // 
            // lblKwh
            // 
            this.lblKwh.AutoSize = true;
            this.lblKwh.Location = new System.Drawing.Point(285, 567);
            this.lblKwh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKwh.Name = "lblKwh";
            this.lblKwh.Size = new System.Drawing.Size(129, 29);
            this.lblKwh.TabIndex = 11;
            this.lblKwh.Text = "kWh Used:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 54);
            this.label1.TabIndex = 10;
            this.label1.Text = "Power Bill";
            // 
            // lblPeak
            // 
            this.lblPeak.AutoSize = true;
            this.lblPeak.Location = new System.Drawing.Point(285, 569);
            this.lblPeak.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeak.Name = "lblPeak";
            this.lblPeak.Size = new System.Drawing.Size(276, 29);
            this.lblPeak.TabIndex = 19;
            this.lblPeak.Text = "kWh Used (Peak Hours):";
            this.lblPeak.Visible = false;
            // 
            // lblOffPeak
            // 
            this.lblOffPeak.AutoSize = true;
            this.lblOffPeak.Location = new System.Drawing.Point(285, 620);
            this.lblOffPeak.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOffPeak.Name = "lblOffPeak";
            this.lblOffPeak.Size = new System.Drawing.Size(315, 29);
            this.lblOffPeak.TabIndex = 20;
            this.lblOffPeak.Text = "kWh Used (Off-Peak Hours):";
            this.lblOffPeak.Visible = false;
            // 
            // txtPeak
            // 
            this.txtPeak.Location = new System.Drawing.Point(578, 566);
            this.txtPeak.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeak.Name = "txtPeak";
            this.txtPeak.Size = new System.Drawing.Size(108, 34);
            this.txtPeak.TabIndex = 12;
            this.txtPeak.Visible = false;
            // 
            // txtOffPeak
            // 
            this.txtOffPeak.Location = new System.Drawing.Point(611, 617);
            this.txtOffPeak.Margin = new System.Windows.Forms.Padding(4);
            this.txtOffPeak.Name = "txtOffPeak";
            this.txtOffPeak.Size = new System.Drawing.Size(100, 34);
            this.txtOffPeak.TabIndex = 12;
            this.txtOffPeak.Visible = false;
            // 
            // lstList
            // 
            this.lstList.FormattingEnabled = true;
            this.lstList.ItemHeight = 29;
            this.lstList.Location = new System.Drawing.Point(1169, 12);
            this.lstList.Name = "lstList";
            this.lstList.Size = new System.Drawing.Size(344, 497);
            this.lstList.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1164, 537);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "Total Customers:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1128, 586);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 29);
            this.label4.TabIndex = 24;
            this.label4.Text = "Residential Charges:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1164, 756);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 29);
            this.label5.TabIndex = 25;
            this.label5.Text = "Total Charges:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(24, 254);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 48);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(225, 254);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(131, 48);
            this.btnDisplay.TabIndex = 30;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblTotalCustomers
            // 
            this.lblTotalCustomers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCustomers.Location = new System.Drawing.Point(1375, 537);
            this.lblTotalCustomers.Name = "lblTotalCustomers";
            this.lblTotalCustomers.Size = new System.Drawing.Size(123, 35);
            this.lblTotalCustomers.TabIndex = 31;
            // 
            // lblResidentialCharge
            // 
            this.lblResidentialCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResidentialCharge.Location = new System.Drawing.Point(1375, 585);
            this.lblResidentialCharge.Name = "lblResidentialCharge";
            this.lblResidentialCharge.Size = new System.Drawing.Size(123, 35);
            this.lblResidentialCharge.TabIndex = 32;
            // 
            // lblTotalCharge
            // 
            this.lblTotalCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCharge.Location = new System.Drawing.Point(1375, 750);
            this.lblTotalCharge.Name = "lblTotalCharge";
            this.lblTotalCharge.Size = new System.Drawing.Size(123, 35);
            this.lblTotalCharge.TabIndex = 33;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCustomerType);
            this.groupBox2.Controls.Add(this.txtCustomerName);
            this.groupBox2.Controls.Add(this.txtAccountNo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnDisplay);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(611, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 398);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Customers";
            // 
            // txtCustomerType
            // 
            this.txtCustomerType.Location = new System.Drawing.Point(313, 159);
            this.txtCustomerType.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerType.Name = "txtCustomerType";
            this.txtCustomerType.Size = new System.Drawing.Size(100, 34);
            this.txtCustomerType.TabIndex = 29;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(225, 105);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 34);
            this.txtCustomerName.TabIndex = 28;
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Location = new System.Drawing.Point(204, 58);
            this.txtAccountNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(100, 34);
            this.txtAccountNo.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(353, 36);
            this.label8.TabIndex = 26;
            this.label8.Text = "Customer Type (\'R\',\'C\',\'I\'):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 29);
            this.label7.TabIndex = 25;
            this.label7.Text = "Customer Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 29);
            this.label6.TabIndex = 24;
            this.label6.Text = "Account No:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1128, 634);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(246, 29);
            this.label9.TabIndex = 35;
            this.label9.Text = "Commercial Charges:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1128, 685);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(213, 29);
            this.label10.TabIndex = 36;
            this.label10.Text = "Industrial Charges:";
            // 
            // lblCommercialCharge
            // 
            this.lblCommercialCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCommercialCharge.Location = new System.Drawing.Point(1375, 633);
            this.lblCommercialCharge.Name = "lblCommercialCharge";
            this.lblCommercialCharge.Size = new System.Drawing.Size(123, 35);
            this.lblCommercialCharge.TabIndex = 37;
            // 
            // lblIndustrialCharge
            // 
            this.lblIndustrialCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIndustrialCharge.Location = new System.Drawing.Point(1375, 684);
            this.lblIndustrialCharge.Name = "lblIndustrialCharge";
            this.lblIndustrialCharge.Size = new System.Drawing.Size(123, 35);
            this.lblIndustrialCharge.TabIndex = 38;
            // 
            // frmPower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1540, 823);
            this.Controls.Add(this.lblIndustrialCharge);
            this.Controls.Add(this.lblCommercialCharge);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblTotalCharge);
            this.Controls.Add(this.lblResidentialCharge);
            this.Controls.Add(this.lblTotalCustomers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstList);
            this.Controls.Add(this.txtOffPeak);
            this.Controls.Add(this.txtPeak);
            this.Controls.Add(this.lblOffPeak);
            this.Controls.Add(this.lblPeak);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCalculatedCharge);
            this.Controls.Add(this.txtKwhUsed);
            this.Controls.Add(this.lblKwh);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmPower";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Power Bill";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPower_FormClosing);
            this.Load += new System.EventHandler(this.frmPower_Load);
            
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radIndustrial;
        private System.Windows.Forms.RadioButton radCommercial;
        private System.Windows.Forms.RadioButton radResidential;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCalculatedCharge;
        private System.Windows.Forms.TextBox txtKwhUsed;
        private System.Windows.Forms.Label lblKwh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPeak;
        private System.Windows.Forms.Label lblOffPeak;
        private System.Windows.Forms.TextBox txtPeak;
        private System.Windows.Forms.TextBox txtOffPeak;
        private System.Windows.Forms.ListBox lstList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label lblTotalCustomers;
        private System.Windows.Forms.Label lblResidentialCharge;
        private System.Windows.Forms.Label lblTotalCharge;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCustomerType;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCommercialCharge;
        private System.Windows.Forms.Label lblIndustrialCharge;
    }
}


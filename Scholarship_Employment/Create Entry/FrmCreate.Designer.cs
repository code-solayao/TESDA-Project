namespace Scholarship_Employment
{
    partial class FrmCreate
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.rtxtAddress = new System.Windows.Forms.RichTextBox();
            this.cbxSex = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQualification = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTVI = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxScholarType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxGradYear = new System.Windows.Forms.ComboBox();
            this.cbxDistrict = new System.Windows.Forms.ComboBox();
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.cbxSector = new System.Windows.Forms.ComboBox();
            this.txtNameDisplay = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContactNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubmit.Location = new System.Drawing.Point(24, 680);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(132, 48);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(20, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sex: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(220, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date of Birth: ";
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.Font = new System.Drawing.Font("Arial", 12F);
            this.dtBirthDate.Location = new System.Drawing.Point(224, 150);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Size = new System.Drawing.Size(300, 26);
            this.dtBirthDate.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(20, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Address: ";
            // 
            // rtxtAddress
            // 
            this.rtxtAddress.Font = new System.Drawing.Font("Arial", 12F);
            this.rtxtAddress.Location = new System.Drawing.Point(24, 230);
            this.rtxtAddress.Name = "rtxtAddress";
            this.rtxtAddress.Size = new System.Drawing.Size(500, 100);
            this.rtxtAddress.TabIndex = 4;
            this.rtxtAddress.Text = "";
            // 
            // cbxSex
            // 
            this.cbxSex.Font = new System.Drawing.Font("Arial", 12F);
            this.cbxSex.FormattingEnabled = true;
            this.cbxSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbxSex.Location = new System.Drawing.Point(24, 150);
            this.cbxSex.Name = "cbxSex";
            this.cbxSex.Size = new System.Drawing.Size(150, 26);
            this.cbxSex.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(370, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Qualification Title: ";
            // 
            // txtQualification
            // 
            this.txtQualification.Font = new System.Drawing.Font("Arial", 12F);
            this.txtQualification.Location = new System.Drawing.Point(374, 390);
            this.txtQualification.Name = "txtQualification";
            this.txtQualification.Size = new System.Drawing.Size(300, 26);
            this.txtQualification.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(370, 520);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 21);
            this.label8.TabIndex = 20;
            this.label8.Text = "Name of TVI: ";
            // 
            // txtTVI
            // 
            this.txtTVI.Font = new System.Drawing.Font("Arial", 12F);
            this.txtTVI.Location = new System.Drawing.Point(374, 550);
            this.txtTVI.Name = "txtTVI";
            this.txtTVI.Size = new System.Drawing.Size(300, 26);
            this.txtTVI.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(20, 440);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 21);
            this.label9.TabIndex = 22;
            this.label9.Text = "District: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(370, 440);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 21);
            this.label10.TabIndex = 24;
            this.label10.Text = "City: ";
            // 
            // cbxScholarType
            // 
            this.cbxScholarType.Font = new System.Drawing.Font("Arial", 12F);
            this.cbxScholarType.FormattingEnabled = true;
            this.cbxScholarType.Items.AddRange(new object[] {
            "STEP",
            "TWSP",
            "PESFA",
            "TTSP",
            "UAQTEA",
            "TSUPER Iskolar"});
            this.cbxScholarType.Location = new System.Drawing.Point(24, 550);
            this.cbxScholarType.Name = "cbxScholarType";
            this.cbxScholarType.Size = new System.Drawing.Size(300, 26);
            this.cbxScholarType.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(20, 520);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 21);
            this.label11.TabIndex = 25;
            this.label11.Text = "Type of Scholarship: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(20, 600);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 21);
            this.label12.TabIndex = 27;
            this.label12.Text = "Year of Graduation";
            // 
            // cbxGradYear
            // 
            this.cbxGradYear.Font = new System.Drawing.Font("Arial", 12F);
            this.cbxGradYear.FormattingEnabled = true;
            this.cbxGradYear.Items.AddRange(new object[] {
            "2023",
            "2024"});
            this.cbxGradYear.Location = new System.Drawing.Point(24, 630);
            this.cbxGradYear.Name = "cbxGradYear";
            this.cbxGradYear.Size = new System.Drawing.Size(150, 26);
            this.cbxGradYear.TabIndex = 12;
            // 
            // cbxDistrict
            // 
            this.cbxDistrict.Font = new System.Drawing.Font("Arial", 12F);
            this.cbxDistrict.FormattingEnabled = true;
            this.cbxDistrict.Items.AddRange(new object[] {
            "CaMaNaVa",
            "Manila",
            "MuntiParLasTaPat",
            "PaMaMariSan",
            "Pasay-Makati",
            "Quezon City"});
            this.cbxDistrict.Location = new System.Drawing.Point(24, 470);
            this.cbxDistrict.Name = "cbxDistrict";
            this.cbxDistrict.Size = new System.Drawing.Size(300, 26);
            this.cbxDistrict.TabIndex = 8;
            this.cbxDistrict.SelectedIndexChanged += new System.EventHandler(this.cbxDistrict_SelectedIndexChanged);
            // 
            // cbxCity
            // 
            this.cbxCity.Font = new System.Drawing.Font("Arial", 12F);
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Items.AddRange(new object[] {
            "STEP",
            "PWSP",
            "PESFA",
            "TTSP"});
            this.cbxCity.Location = new System.Drawing.Point(374, 470);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(300, 26);
            this.cbxCity.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(20, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Sector: ";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label13);
            this.panel.Controls.Add(this.cbxSector);
            this.panel.Controls.Add(this.txtNameDisplay);
            this.panel.Controls.Add(this.txtEmail);
            this.panel.Controls.Add(this.txtContactNum);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.cbxCity);
            this.panel.Controls.Add(this.cbxDistrict);
            this.panel.Controls.Add(this.cbxGradYear);
            this.panel.Controls.Add(this.label12);
            this.panel.Controls.Add(this.cbxScholarType);
            this.panel.Controls.Add(this.label11);
            this.panel.Controls.Add(this.label10);
            this.panel.Controls.Add(this.label9);
            this.panel.Controls.Add(this.label8);
            this.panel.Controls.Add(this.txtTVI);
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.txtQualification);
            this.panel.Controls.Add(this.cbxSex);
            this.panel.Controls.Add(this.rtxtAddress);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.dtBirthDate);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.btnSubmit);
            this.panel.Location = new System.Drawing.Point(30, 30);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(905, 755);
            this.panel.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(330, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(208, 25);
            this.label13.TabIndex = 38;
            this.label13.Text = "Create an entry data for";
            // 
            // cbxSector
            // 
            this.cbxSector.Font = new System.Drawing.Font("Arial", 12F);
            this.cbxSector.FormattingEnabled = true;
            this.cbxSector.Items.AddRange(new object[] {
            "Agriculture",
            "ALT",
            "Construction",
            "Electrical and Electronics",
            "Garments",
            "Health",
            "HVAC/R",
            "ICT",
            "Marine",
            "Metals and Engineering",
            "Others",
            "Processed Foods and Beverages",
            "SCDOS",
            "Tourism",
            "TVET",
            "Visual Arts",
            "Wholesale"});
            this.cbxSector.Location = new System.Drawing.Point(24, 390);
            this.cbxSector.Name = "cbxSector";
            this.cbxSector.Size = new System.Drawing.Size(300, 26);
            this.cbxSector.TabIndex = 6;
            // 
            // txtNameDisplay
            // 
            this.txtNameDisplay.Enabled = false;
            this.txtNameDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameDisplay.Location = new System.Drawing.Point(24, 50);
            this.txtNameDisplay.Name = "txtNameDisplay";
            this.txtNameDisplay.Size = new System.Drawing.Size(850, 43);
            this.txtNameDisplay.TabIndex = 36;
            this.txtNameDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 12F);
            this.txtEmail.Location = new System.Drawing.Point(574, 230);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 26);
            this.txtEmail.TabIndex = 5;
            // 
            // txtContactNum
            // 
            this.txtContactNum.Font = new System.Drawing.Font("Arial", 12F);
            this.txtContactNum.Location = new System.Drawing.Point(574, 150);
            this.txtContactNum.Name = "txtContactNum";
            this.txtContactNum.Size = new System.Drawing.Size(300, 26);
            this.txtContactNum.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(570, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "E-mail Address: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(570, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 21);
            this.label6.TabIndex = 34;
            this.label6.Text = "Contact Number: ";
            // 
            // FrmCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 811);
            this.Controls.Add(this.panel);
            this.Name = "FrmCreate";
            this.Text = "Create Record Data";
            this.Load += new System.EventHandler(this.FrmCreate_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtBirthDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtxtAddress;
        private System.Windows.Forms.ComboBox cbxSex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQualification;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTVI;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxScholarType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxGradYear;
        private System.Windows.Forms.ComboBox cbxDistrict;
        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContactNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNameDisplay;
        private System.Windows.Forms.ComboBox cbxSector;
        private System.Windows.Forms.Label label13;
    }
}
namespace Scholarship_Employment
{
    partial class FrmUpdate
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pageDetails = new System.Windows.Forms.TabPage();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.cbxDistrict = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSuffix = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMiddleInitial = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.cbxGradYear = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxScholarType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTVI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQualification = new System.Windows.Forms.TextBox();
            this.cbxSex = new System.Windows.Forms.ComboBox();
            this.rtxtAddress = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pageVerification = new System.Windows.Forms.TabPage();
            this.pnlVerification = new System.Windows.Forms.Panel();
            this.grpNotInterested = new System.Windows.Forms.GroupBox();
            this.rtbRsnNotInterested = new System.Windows.Forms.RichTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.grpNoResponse = new System.Windows.Forms.GroupBox();
            this.dtDateFollowup = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.grpResponded = new System.Windows.Forms.GroupBox();
            this.rtbRsnResponded = new System.Windows.Forms.RichTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.rbtnNo = new System.Windows.Forms.RadioButton();
            this.rbtnYes = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.dtDateVerify = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.cbxStatusVerify = new System.Windows.Forms.ComboBox();
            this.cbxMeansVerify = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pageEmployment = new System.Windows.Forms.TabPage();
            this.pnlEmployment = new System.Windows.Forms.Panel();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCompanyEmp = new System.Windows.Forms.TextBox();
            this.grpEmploymentStatus = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.dtDateHired = new System.Windows.Forms.DateTimePicker();
            this.rbtnSubmitDocs = new System.Windows.Forms.RadioButton();
            this.label27 = new System.Windows.Forms.Label();
            this.rbtnHired = new System.Windows.Forms.RadioButton();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rbtnForInterview = new System.Windows.Forms.RadioButton();
            this.rbtnNotHired = new System.Windows.Forms.RadioButton();
            this.cbxReason = new System.Windows.Forms.ComboBox();
            this.tabControl.SuspendLayout();
            this.pageDetails.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.pageVerification.SuspendLayout();
            this.pnlVerification.SuspendLayout();
            this.grpNotInterested.SuspendLayout();
            this.grpNoResponse.SuspendLayout();
            this.grpResponded.SuspendLayout();
            this.pageEmployment.SuspendLayout();
            this.pnlEmployment.SuspendLayout();
            this.grpEmploymentStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pageDetails);
            this.tabControl.Controls.Add(this.pageVerification);
            this.tabControl.Controls.Add(this.pageEmployment);
            this.tabControl.Location = new System.Drawing.Point(10, 10);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1120, 540);
            this.tabControl.TabIndex = 0;
            // 
            // pageDetails
            // 
            this.pageDetails.Controls.Add(this.pnlDetails);
            this.pageDetails.Location = new System.Drawing.Point(4, 22);
            this.pageDetails.Name = "pageDetails";
            this.pageDetails.Padding = new System.Windows.Forms.Padding(3);
            this.pageDetails.Size = new System.Drawing.Size(1112, 514);
            this.pageDetails.TabIndex = 0;
            this.pageDetails.Text = "Details";
            this.pageDetails.UseVisualStyleBackColor = true;
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDetails.Controls.Add(this.cbxCity);
            this.pnlDetails.Controls.Add(this.cbxDistrict);
            this.pnlDetails.Controls.Add(this.label13);
            this.pnlDetails.Controls.Add(this.txtSuffix);
            this.pnlDetails.Controls.Add(this.label6);
            this.pnlDetails.Controls.Add(this.txtMiddleInitial);
            this.pnlDetails.Controls.Add(this.txtFirstname);
            this.pnlDetails.Controls.Add(this.label2);
            this.pnlDetails.Controls.Add(this.label1);
            this.pnlDetails.Controls.Add(this.txtLastname);
            this.pnlDetails.Controls.Add(this.cbxGradYear);
            this.pnlDetails.Controls.Add(this.label12);
            this.pnlDetails.Controls.Add(this.cbxScholarType);
            this.pnlDetails.Controls.Add(this.label11);
            this.pnlDetails.Controls.Add(this.label10);
            this.pnlDetails.Controls.Add(this.label9);
            this.pnlDetails.Controls.Add(this.label8);
            this.pnlDetails.Controls.Add(this.txtTVI);
            this.pnlDetails.Controls.Add(this.label7);
            this.pnlDetails.Controls.Add(this.txtQualification);
            this.pnlDetails.Controls.Add(this.cbxSex);
            this.pnlDetails.Controls.Add(this.rtxtAddress);
            this.pnlDetails.Controls.Add(this.label5);
            this.pnlDetails.Controls.Add(this.dtBirthDate);
            this.pnlDetails.Controls.Add(this.label4);
            this.pnlDetails.Controls.Add(this.label3);
            this.pnlDetails.Location = new System.Drawing.Point(6, 6);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(1100, 500);
            this.pnlDetails.TabIndex = 40;
            // 
            // cbxCity
            // 
            this.cbxCity.Enabled = false;
            this.cbxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Items.AddRange(new object[] {
            "STEP",
            "PWSP",
            "PESFA",
            "TTSP"});
            this.cbxCity.Location = new System.Drawing.Point(24, 447);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(300, 28);
            this.cbxCity.TabIndex = 40;
            // 
            // cbxDistrict
            // 
            this.cbxDistrict.Enabled = false;
            this.cbxDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDistrict.FormattingEnabled = true;
            this.cbxDistrict.Items.AddRange(new object[] {
            "CMNV",
            "MLA",
            "MPLTP",
            "PMMS",
            "PASMAK",
            "QC"});
            this.cbxDistrict.Location = new System.Drawing.Point(724, 367);
            this.cbxDistrict.Name = "cbxDistrict";
            this.cbxDistrict.Size = new System.Drawing.Size(300, 28);
            this.cbxDistrict.TabIndex = 39;
            this.cbxDistrict.SelectedIndexChanged += new System.EventHandler(this.cbxDistrict_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(920, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 20);
            this.label13.TabIndex = 38;
            this.label13.Text = "Suffix: ";
            // 
            // txtSuffix
            // 
            this.txtSuffix.Enabled = false;
            this.txtSuffix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuffix.Location = new System.Drawing.Point(924, 47);
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Size = new System.Drawing.Size(150, 26);
            this.txtSuffix.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(720, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Middle initial: ";
            // 
            // txtMiddleInitial
            // 
            this.txtMiddleInitial.Enabled = false;
            this.txtMiddleInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleInitial.Location = new System.Drawing.Point(724, 47);
            this.txtMiddleInitial.Name = "txtMiddleInitial";
            this.txtMiddleInitial.Size = new System.Drawing.Size(150, 26);
            this.txtMiddleInitial.TabIndex = 3;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Enabled = false;
            this.txtFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.Location = new System.Drawing.Point(374, 47);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(300, 26);
            this.txtFirstname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Last name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "First name: ";
            // 
            // txtLastname
            // 
            this.txtLastname.Enabled = false;
            this.txtLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Location = new System.Drawing.Point(24, 47);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(300, 26);
            this.txtLastname.TabIndex = 1;
            // 
            // cbxGradYear
            // 
            this.cbxGradYear.Enabled = false;
            this.cbxGradYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGradYear.FormattingEnabled = true;
            this.cbxGradYear.Items.AddRange(new object[] {
            "2023",
            "2024"});
            this.cbxGradYear.Location = new System.Drawing.Point(724, 447);
            this.cbxGradYear.Name = "cbxGradYear";
            this.cbxGradYear.Size = new System.Drawing.Size(150, 28);
            this.cbxGradYear.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(720, 417);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Year of Graduation";
            // 
            // cbxScholarType
            // 
            this.cbxScholarType.Enabled = false;
            this.cbxScholarType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxScholarType.FormattingEnabled = true;
            this.cbxScholarType.Items.AddRange(new object[] {
            "STEP",
            "PWSP",
            "PESFA",
            "TTSP"});
            this.cbxScholarType.Location = new System.Drawing.Point(374, 447);
            this.cbxScholarType.Name = "cbxScholarType";
            this.cbxScholarType.Size = new System.Drawing.Size(300, 28);
            this.cbxScholarType.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(370, 417);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Type of Scholarship: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 417);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "City: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(720, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "District: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(370, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Name of TVI (School): ";
            // 
            // txtTVI
            // 
            this.txtTVI.Enabled = false;
            this.txtTVI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTVI.Location = new System.Drawing.Point(374, 367);
            this.txtTVI.Name = "txtTVI";
            this.txtTVI.Size = new System.Drawing.Size(300, 26);
            this.txtTVI.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Qualification (Course): ";
            // 
            // txtQualification
            // 
            this.txtQualification.Enabled = false;
            this.txtQualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQualification.Location = new System.Drawing.Point(24, 367);
            this.txtQualification.Name = "txtQualification";
            this.txtQualification.Size = new System.Drawing.Size(300, 26);
            this.txtQualification.TabIndex = 8;
            // 
            // cbxSex
            // 
            this.cbxSex.Enabled = false;
            this.cbxSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSex.FormattingEnabled = true;
            this.cbxSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbxSex.Location = new System.Drawing.Point(24, 127);
            this.cbxSex.Name = "cbxSex";
            this.cbxSex.Size = new System.Drawing.Size(150, 28);
            this.cbxSex.TabIndex = 5;
            // 
            // rtxtAddress
            // 
            this.rtxtAddress.Enabled = false;
            this.rtxtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtAddress.Location = new System.Drawing.Point(24, 207);
            this.rtxtAddress.Name = "rtxtAddress";
            this.rtxtAddress.Size = new System.Drawing.Size(500, 100);
            this.rtxtAddress.TabIndex = 7;
            this.rtxtAddress.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Address: ";
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.Enabled = false;
            this.dtBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBirthDate.Location = new System.Drawing.Point(224, 127);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Size = new System.Drawing.Size(300, 26);
            this.dtBirthDate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date of Birth: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sex: ";
            // 
            // pageVerification
            // 
            this.pageVerification.Controls.Add(this.pnlVerification);
            this.pageVerification.Location = new System.Drawing.Point(4, 22);
            this.pageVerification.Name = "pageVerification";
            this.pageVerification.Padding = new System.Windows.Forms.Padding(3);
            this.pageVerification.Size = new System.Drawing.Size(1112, 514);
            this.pageVerification.TabIndex = 1;
            this.pageVerification.Text = "Verification";
            this.pageVerification.UseVisualStyleBackColor = true;
            // 
            // pnlVerification
            // 
            this.pnlVerification.BackColor = System.Drawing.SystemColors.Control;
            this.pnlVerification.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlVerification.Controls.Add(this.grpNotInterested);
            this.pnlVerification.Controls.Add(this.grpNoResponse);
            this.pnlVerification.Controls.Add(this.grpResponded);
            this.pnlVerification.Controls.Add(this.dtDateVerify);
            this.pnlVerification.Controls.Add(this.label14);
            this.pnlVerification.Controls.Add(this.cbxStatusVerify);
            this.pnlVerification.Controls.Add(this.cbxMeansVerify);
            this.pnlVerification.Controls.Add(this.label16);
            this.pnlVerification.Controls.Add(this.label17);
            this.pnlVerification.Location = new System.Drawing.Point(6, 7);
            this.pnlVerification.Name = "pnlVerification";
            this.pnlVerification.Size = new System.Drawing.Size(1100, 500);
            this.pnlVerification.TabIndex = 41;
            // 
            // grpNotInterested
            // 
            this.grpNotInterested.Controls.Add(this.rtbRsnNotInterested);
            this.grpNotInterested.Controls.Add(this.label23);
            this.grpNotInterested.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNotInterested.Location = new System.Drawing.Point(348, 70);
            this.grpNotInterested.Name = "grpNotInterested";
            this.grpNotInterested.Size = new System.Drawing.Size(720, 450);
            this.grpNotInterested.TabIndex = 62;
            this.grpNotInterested.TabStop = false;
            this.grpNotInterested.Text = "Not Interested";
            this.grpNotInterested.Visible = false;
            // 
            // rtbRsnNotInterested
            // 
            this.rtbRsnNotInterested.Font = new System.Drawing.Font("Arial", 12F);
            this.rtbRsnNotInterested.Location = new System.Drawing.Point(54, 80);
            this.rtbRsnNotInterested.Name = "rtbRsnNotInterested";
            this.rtbRsnNotInterested.Size = new System.Drawing.Size(580, 170);
            this.rtbRsnNotInterested.TabIndex = 38;
            this.rtbRsnNotInterested.Text = "";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(50, 50);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(71, 21);
            this.label23.TabIndex = 0;
            this.label23.Text = "Reason: ";
            // 
            // grpNoResponse
            // 
            this.grpNoResponse.Controls.Add(this.dtDateFollowup);
            this.grpNoResponse.Controls.Add(this.label22);
            this.grpNoResponse.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNoResponse.Location = new System.Drawing.Point(354, 43);
            this.grpNoResponse.Name = "grpNoResponse";
            this.grpNoResponse.Size = new System.Drawing.Size(720, 450);
            this.grpNoResponse.TabIndex = 61;
            this.grpNoResponse.TabStop = false;
            this.grpNoResponse.Text = "No Response (For Follow-up)";
            this.grpNoResponse.Visible = false;
            // 
            // dtDateFollowup
            // 
            this.dtDateFollowup.Font = new System.Drawing.Font("Arial", 12F);
            this.dtDateFollowup.Location = new System.Drawing.Point(54, 80);
            this.dtDateFollowup.Name = "dtDateFollowup";
            this.dtDateFollowup.Size = new System.Drawing.Size(300, 26);
            this.dtDateFollowup.TabIndex = 59;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(50, 50);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(179, 21);
            this.label22.TabIndex = 0;
            this.label22.Text = "Set Date for Follow-up:";
            // 
            // grpResponded
            // 
            this.grpResponded.Controls.Add(this.rtbRsnResponded);
            this.grpResponded.Controls.Add(this.label19);
            this.grpResponded.Controls.Add(this.txtCompanyName);
            this.grpResponded.Controls.Add(this.label18);
            this.grpResponded.Controls.Add(this.rbtnNo);
            this.grpResponded.Controls.Add(this.rbtnYes);
            this.grpResponded.Controls.Add(this.label15);
            this.grpResponded.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpResponded.Location = new System.Drawing.Point(360, 20);
            this.grpResponded.Name = "grpResponded";
            this.grpResponded.Size = new System.Drawing.Size(720, 450);
            this.grpResponded.TabIndex = 60;
            this.grpResponded.TabStop = false;
            this.grpResponded.Text = "Responded";
            this.grpResponded.Visible = false;
            // 
            // rtbRsnResponded
            // 
            this.rtbRsnResponded.Enabled = false;
            this.rtbRsnResponded.Font = new System.Drawing.Font("Arial", 12F);
            this.rtbRsnResponded.Location = new System.Drawing.Point(124, 260);
            this.rtbRsnResponded.Name = "rtbRsnResponded";
            this.rtbRsnResponded.Size = new System.Drawing.Size(580, 170);
            this.rtbRsnResponded.TabIndex = 38;
            this.rtbRsnResponded.Text = "";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(120, 230);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 21);
            this.label19.TabIndex = 37;
            this.label19.Text = "Reason: ";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Enabled = false;
            this.txtCompanyName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtCompanyName.Location = new System.Drawing.Point(124, 150);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(400, 26);
            this.txtCompanyName.TabIndex = 35;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(120, 120);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(134, 21);
            this.label18.TabIndex = 36;
            this.label18.Text = "Company Name: ";
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNo.Location = new System.Drawing.Point(90, 200);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(52, 25);
            this.rbtnNo.TabIndex = 2;
            this.rbtnNo.TabStop = true;
            this.rbtnNo.Text = "NO";
            this.rbtnNo.UseVisualStyleBackColor = true;
            // 
            // rbtnYes
            // 
            this.rbtnYes.AutoSize = true;
            this.rbtnYes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnYes.Location = new System.Drawing.Point(90, 90);
            this.rbtnYes.Name = "rbtnYes";
            this.rbtnYes.Size = new System.Drawing.Size(54, 25);
            this.rbtnYes.TabIndex = 1;
            this.rbtnYes.TabStop = true;
            this.rbtnYes.Text = "YES";
            this.rbtnYes.UseVisualStyleBackColor = true;
            this.rbtnYes.CheckedChanged += new System.EventHandler(this.rbtnYes_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(50, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 21);
            this.label15.TabIndex = 0;
            this.label15.Text = "Referral Status";
            // 
            // dtDateVerify
            // 
            this.dtDateVerify.Font = new System.Drawing.Font("Arial", 12F);
            this.dtDateVerify.Location = new System.Drawing.Point(24, 130);
            this.dtDateVerify.Name = "dtDateVerify";
            this.dtDateVerify.Size = new System.Drawing.Size(300, 26);
            this.dtDateVerify.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(20, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(167, 21);
            this.label14.TabIndex = 59;
            this.label14.Text = "Date of Verification: ";
            // 
            // cbxStatusVerify
            // 
            this.cbxStatusVerify.Font = new System.Drawing.Font("Arial", 12F);
            this.cbxStatusVerify.FormattingEnabled = true;
            this.cbxStatusVerify.Items.AddRange(new object[] {
            "Responded",
            "No Response (For Follow-up)",
            "Not Interested (Please Provide Reason)",
            "Not Applicable"});
            this.cbxStatusVerify.Location = new System.Drawing.Point(24, 210);
            this.cbxStatusVerify.Name = "cbxStatusVerify";
            this.cbxStatusVerify.Size = new System.Drawing.Size(300, 26);
            this.cbxStatusVerify.TabIndex = 3;
            this.cbxStatusVerify.SelectedIndexChanged += new System.EventHandler(this.cbxStatusVerify_SelectedIndexChanged);
            // 
            // cbxMeansVerify
            // 
            this.cbxMeansVerify.Font = new System.Drawing.Font("Arial", 12F);
            this.cbxMeansVerify.FormattingEnabled = true;
            this.cbxMeansVerify.Items.AddRange(new object[] {
            "For Verification",
            "Phone-called",
            "E-mailed",
            "SMS"});
            this.cbxMeansVerify.Location = new System.Drawing.Point(24, 50);
            this.cbxMeansVerify.Name = "cbxMeansVerify";
            this.cbxMeansVerify.Size = new System.Drawing.Size(300, 26);
            this.cbxMeansVerify.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(20, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(177, 21);
            this.label16.TabIndex = 35;
            this.label16.Text = "Means of Verification:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(20, 180);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(178, 21);
            this.label17.TabIndex = 33;
            this.label17.Text = "Status of Verification: ";
            // 
            // pageEmployment
            // 
            this.pageEmployment.Controls.Add(this.pnlEmployment);
            this.pageEmployment.Location = new System.Drawing.Point(4, 22);
            this.pageEmployment.Name = "pageEmployment";
            this.pageEmployment.Padding = new System.Windows.Forms.Padding(3);
            this.pageEmployment.Size = new System.Drawing.Size(1112, 514);
            this.pageEmployment.TabIndex = 2;
            this.pageEmployment.Text = "Employment";
            this.pageEmployment.UseVisualStyleBackColor = true;
            // 
            // pnlEmployment
            // 
            this.pnlEmployment.BackColor = System.Drawing.SystemColors.Control;
            this.pnlEmployment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlEmployment.Controls.Add(this.txtJobTitle);
            this.pnlEmployment.Controls.Add(this.rtbAddress);
            this.pnlEmployment.Controls.Add(this.label20);
            this.pnlEmployment.Controls.Add(this.txtCompanyEmp);
            this.pnlEmployment.Controls.Add(this.grpEmploymentStatus);
            this.pnlEmployment.Controls.Add(this.label28);
            this.pnlEmployment.Controls.Add(this.label29);
            this.pnlEmployment.Location = new System.Drawing.Point(6, 7);
            this.pnlEmployment.Name = "pnlEmployment";
            this.pnlEmployment.Size = new System.Drawing.Size(1100, 500);
            this.pnlEmployment.TabIndex = 42;
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobTitle.Location = new System.Drawing.Point(24, 290);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(300, 26);
            this.txtJobTitle.TabIndex = 62;
            // 
            // rtbAddress
            // 
            this.rtbAddress.Enabled = false;
            this.rtbAddress.Font = new System.Drawing.Font("Arial", 12F);
            this.rtbAddress.Location = new System.Drawing.Point(24, 130);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(500, 100);
            this.rtbAddress.TabIndex = 38;
            this.rtbAddress.Text = "";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(20, 100);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 21);
            this.label20.TabIndex = 61;
            this.label20.Text = "Address: ";
            // 
            // txtCompanyEmp
            // 
            this.txtCompanyEmp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyEmp.Location = new System.Drawing.Point(24, 50);
            this.txtCompanyEmp.Name = "txtCompanyEmp";
            this.txtCompanyEmp.Size = new System.Drawing.Size(300, 26);
            this.txtCompanyEmp.TabIndex = 39;
            // 
            // grpEmploymentStatus
            // 
            this.grpEmploymentStatus.Controls.Add(this.cbxReason);
            this.grpEmploymentStatus.Controls.Add(this.rbtnNotHired);
            this.grpEmploymentStatus.Controls.Add(this.rbtnForInterview);
            this.grpEmploymentStatus.Controls.Add(this.label24);
            this.grpEmploymentStatus.Controls.Add(this.dtDateHired);
            this.grpEmploymentStatus.Controls.Add(this.rbtnSubmitDocs);
            this.grpEmploymentStatus.Controls.Add(this.label27);
            this.grpEmploymentStatus.Controls.Add(this.rbtnHired);
            this.grpEmploymentStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEmploymentStatus.Location = new System.Drawing.Point(547, 20);
            this.grpEmploymentStatus.Name = "grpEmploymentStatus";
            this.grpEmploymentStatus.Size = new System.Drawing.Size(533, 450);
            this.grpEmploymentStatus.TabIndex = 60;
            this.grpEmploymentStatus.TabStop = false;
            this.grpEmploymentStatus.Text = "Employment Status";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(70, 270);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(71, 21);
            this.label24.TabIndex = 37;
            this.label24.Text = "Reason: ";
            // 
            // dtDateHired
            // 
            this.dtDateHired.Enabled = false;
            this.dtDateHired.Font = new System.Drawing.Font("Arial", 12F);
            this.dtDateHired.Location = new System.Drawing.Point(74, 100);
            this.dtDateHired.Name = "dtDateHired";
            this.dtDateHired.Size = new System.Drawing.Size(300, 26);
            this.dtDateHired.TabIndex = 2;
            // 
            // rbtnSubmitDocs
            // 
            this.rbtnSubmitDocs.AutoSize = true;
            this.rbtnSubmitDocs.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSubmitDocs.Location = new System.Drawing.Point(40, 140);
            this.rbtnSubmitDocs.Name = "rbtnSubmitDocs";
            this.rbtnSubmitDocs.Size = new System.Drawing.Size(192, 25);
            this.rbtnSubmitDocs.TabIndex = 2;
            this.rbtnSubmitDocs.TabStop = true;
            this.rbtnSubmitDocs.Text = "Submitted Documents";
            this.rbtnSubmitDocs.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(70, 70);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(97, 21);
            this.label27.TabIndex = 59;
            this.label27.Text = "Date Hired: ";
            // 
            // rbtnHired
            // 
            this.rbtnHired.AutoSize = true;
            this.rbtnHired.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnHired.Location = new System.Drawing.Point(40, 40);
            this.rbtnHired.Name = "rbtnHired";
            this.rbtnHired.Size = new System.Drawing.Size(69, 25);
            this.rbtnHired.TabIndex = 1;
            this.rbtnHired.TabStop = true;
            this.rbtnHired.Text = "Hired";
            this.rbtnHired.UseVisualStyleBackColor = true;
            this.rbtnHired.CheckedChanged += new System.EventHandler(this.rbtnHired_CheckedChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label28.Location = new System.Drawing.Point(20, 20);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(157, 21);
            this.label28.TabIndex = 35;
            this.label28.Text = "Name of Company:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label29.Location = new System.Drawing.Point(20, 260);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(83, 21);
            this.label29.TabIndex = 33;
            this.label29.Text = "Job Title: ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(1135, 38);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1136, 74);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rbtnForInterview
            // 
            this.rbtnForInterview.AutoSize = true;
            this.rbtnForInterview.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnForInterview.Location = new System.Drawing.Point(40, 190);
            this.rbtnForInterview.Name = "rbtnForInterview";
            this.rbtnForInterview.Size = new System.Drawing.Size(125, 25);
            this.rbtnForInterview.TabIndex = 60;
            this.rbtnForInterview.TabStop = true;
            this.rbtnForInterview.Text = "For Interview";
            this.rbtnForInterview.UseVisualStyleBackColor = true;
            // 
            // rbtnNotHired
            // 
            this.rbtnNotHired.AutoSize = true;
            this.rbtnNotHired.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNotHired.Location = new System.Drawing.Point(40, 240);
            this.rbtnNotHired.Name = "rbtnNotHired";
            this.rbtnNotHired.Size = new System.Drawing.Size(231, 25);
            this.rbtnNotHired.TabIndex = 61;
            this.rbtnNotHired.TabStop = true;
            this.rbtnNotHired.Text = "Not Hired (Indicate Reason)";
            this.rbtnNotHired.UseVisualStyleBackColor = true;
            // 
            // cbxReason
            // 
            this.cbxReason.Enabled = false;
            this.cbxReason.Font = new System.Drawing.Font("Arial", 12F);
            this.cbxReason.FormattingEnabled = true;
            this.cbxReason.Items.AddRange(new object[] {
            "Not Hired"});
            this.cbxReason.Location = new System.Drawing.Point(74, 300);
            this.cbxReason.Name = "cbxReason";
            this.cbxReason.Size = new System.Drawing.Size(300, 26);
            this.cbxReason.TabIndex = 62;
            // 
            // FrmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 561);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnUpdate);
            this.Name = "FrmUpdate";
            this.Text = "Update Information";
            this.Load += new System.EventHandler(this.FrmUpdate_Load);
            this.tabControl.ResumeLayout(false);
            this.pageDetails.ResumeLayout(false);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.pageVerification.ResumeLayout(false);
            this.pnlVerification.ResumeLayout(false);
            this.pnlVerification.PerformLayout();
            this.grpNotInterested.ResumeLayout(false);
            this.grpNotInterested.PerformLayout();
            this.grpNoResponse.ResumeLayout(false);
            this.grpNoResponse.PerformLayout();
            this.grpResponded.ResumeLayout(false);
            this.grpResponded.PerformLayout();
            this.pageEmployment.ResumeLayout(false);
            this.pnlEmployment.ResumeLayout(false);
            this.pnlEmployment.PerformLayout();
            this.grpEmploymentStatus.ResumeLayout(false);
            this.grpEmploymentStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pageDetails;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSuffix;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMiddleInitial;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.ComboBox cbxGradYear;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxScholarType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTVI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQualification;
        private System.Windows.Forms.ComboBox cbxSex;
        private System.Windows.Forms.RichTextBox rtxtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtBirthDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TabPage pageVerification;
        private System.Windows.Forms.ComboBox cbxDistrict;
        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.Panel pnlVerification;
        private System.Windows.Forms.ComboBox cbxStatusVerify;
        private System.Windows.Forms.ComboBox cbxMeansVerify;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabPage pageEmployment;
        private System.Windows.Forms.DateTimePicker dtDateVerify;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox grpResponded;
        private System.Windows.Forms.RadioButton rbtnNo;
        private System.Windows.Forms.RadioButton rbtnYes;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RichTextBox rtbRsnResponded;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox grpNoResponse;
        private System.Windows.Forms.DateTimePicker dtDateFollowup;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox grpNotInterested;
        private System.Windows.Forms.RichTextBox rtbRsnNotInterested;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel pnlEmployment;
        private System.Windows.Forms.TextBox txtCompanyEmp;
        private System.Windows.Forms.GroupBox grpEmploymentStatus;
        private System.Windows.Forms.RichTextBox rtbAddress;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DateTimePicker dtDateHired;
        private System.Windows.Forms.RadioButton rbtnSubmitDocs;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.RadioButton rbtnHired;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.RadioButton rbtnForInterview;
        private System.Windows.Forms.ComboBox cbxReason;
        private System.Windows.Forms.RadioButton rbtnNotHired;
    }
}
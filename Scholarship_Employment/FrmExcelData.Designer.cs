namespace Scholarship_Employment
{
    partial class FrmExcelData
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
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "1"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnLoadExcelData = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView = new System.Windows.Forms.ListView();
            this.colDistrict = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTVI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQualification = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSector = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFirstname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMiddleInitial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSuffix = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFullname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colScholarType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTrainStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAssessResult = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmpTrain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOccupation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmployer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmployType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAllocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVerifyStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colReferStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colJobTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateEmploy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmployStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReadData = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView.Location = new System.Drawing.Point(19, 17);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1080, 494);
            this.dataGridView.TabIndex = 0;
            // 
            // btnLoadExcelData
            // 
            this.btnLoadExcelData.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLoadExcelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadExcelData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLoadExcelData.Location = new System.Drawing.Point(19, 528);
            this.btnLoadExcelData.Name = "btnLoadExcelData";
            this.btnLoadExcelData.Size = new System.Drawing.Size(123, 36);
            this.btnLoadExcelData.TabIndex = 1;
            this.btnLoadExcelData.Text = "Load Excel";
            this.btnLoadExcelData.UseVisualStyleBackColor = false;
            this.btnLoadExcelData.Click += new System.EventHandler(this.btnLoadExcelData_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1127, 604);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblFilePath);
            this.tabPage1.Controls.Add(this.dataGridView);
            this.tabPage1.Controls.Add(this.btnLoadExcelData);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1119, 578);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilePath.Location = new System.Drawing.Point(148, 536);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(71, 20);
            this.lblFilePath.TabIndex = 2;
            this.lblFilePath.Text = "File Path";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView);
            this.tabPage2.Controls.Add(this.btnReadData);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1119, 578);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDistrict,
            this.colCity,
            this.colTVI,
            this.colQualification,
            this.colSector,
            this.colLastname,
            this.colFirstname,
            this.colMiddleInitial,
            this.colSuffix,
            this.colFullname,
            this.colScholarType,
            this.colTrainStatus,
            this.colAssessResult,
            this.colEmpTrain,
            this.colOccupation,
            this.colEmployer,
            this.colEmployType,
            this.colAllocation,
            this.colVerifyStatus,
            this.colDate,
            this.colReferStatus,
            this.colCompany,
            this.colAddress,
            this.colJobTitle,
            this.colDateEmploy,
            this.colEmployStatus});
            this.listView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem12});
            this.listView.Location = new System.Drawing.Point(16, 16);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1086, 437);
            this.listView.TabIndex = 5;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // colDistrict
            // 
            this.colDistrict.Text = "District";
            this.colDistrict.Width = 100;
            // 
            // colCity
            // 
            this.colCity.Text = "City";
            this.colCity.Width = 100;
            // 
            // colTVI
            // 
            this.colTVI.Text = "Name of TVI";
            this.colTVI.Width = 150;
            // 
            // colQualification
            // 
            this.colQualification.Text = "Qualification Title";
            this.colQualification.Width = 200;
            // 
            // colSector
            // 
            this.colSector.Text = "Sector";
            this.colSector.Width = 100;
            // 
            // colLastname
            // 
            this.colLastname.Text = "Last name";
            this.colLastname.Width = 150;
            // 
            // colFirstname
            // 
            this.colFirstname.Text = "First name";
            this.colFirstname.Width = 150;
            // 
            // colMiddleInitial
            // 
            this.colMiddleInitial.Text = "Middle Initial";
            this.colMiddleInitial.Width = 150;
            // 
            // colSuffix
            // 
            this.colSuffix.Text = "Suffix";
            this.colSuffix.Width = 100;
            // 
            // colFullname
            // 
            this.colFullname.Text = "Full name";
            this.colFullname.Width = 200;
            // 
            // colScholarType
            // 
            this.colScholarType.Text = "Scholarship Type";
            this.colScholarType.Width = 150;
            // 
            // colTrainStatus
            // 
            this.colTrainStatus.Text = "Training Status";
            this.colTrainStatus.Width = 200;
            // 
            // colAssessResult
            // 
            this.colAssessResult.Text = "Assessment Result";
            this.colAssessResult.Width = 200;
            // 
            // colEmpTrain
            // 
            this.colEmpTrain.Text = "Employment Before Training";
            this.colEmpTrain.Width = 250;
            // 
            // colOccupation
            // 
            this.colOccupation.Text = "Occupation";
            this.colOccupation.Width = 150;
            // 
            // colEmployer
            // 
            this.colEmployer.Text = "Name of Employer";
            this.colEmployer.Width = 200;
            // 
            // colEmployType
            // 
            this.colEmployType.Text = "Employment Type";
            this.colEmployType.Width = 200;
            // 
            // colAllocation
            // 
            this.colAllocation.Text = "Allocation";
            this.colAllocation.Width = 150;
            // 
            // colVerifyStatus
            // 
            this.colVerifyStatus.Text = "Verification Status";
            this.colVerifyStatus.Width = 200;
            // 
            // colDate
            // 
            this.colDate.Text = "Date";
            this.colDate.Width = 100;
            // 
            // colReferStatus
            // 
            this.colReferStatus.Text = "Referral Status";
            this.colReferStatus.Width = 150;
            // 
            // colCompany
            // 
            this.colCompany.Text = "Name of Company";
            this.colCompany.Width = 200;
            // 
            // colAddress
            // 
            this.colAddress.Text = "Address (City)";
            this.colAddress.Width = 200;
            // 
            // colJobTitle
            // 
            this.colJobTitle.Text = "Job Title";
            this.colJobTitle.Width = 150;
            // 
            // colDateEmploy
            // 
            this.colDateEmploy.Text = "Date of Employment";
            this.colDateEmploy.Width = 200;
            // 
            // colEmployStatus
            // 
            this.colEmployStatus.Text = "Status of Employment";
            this.colEmployStatus.Width = 150;
            // 
            // btnReadData
            // 
            this.btnReadData.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnReadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReadData.Location = new System.Drawing.Point(6, 536);
            this.btnReadData.Name = "btnReadData";
            this.btnReadData.Size = new System.Drawing.Size(123, 36);
            this.btnReadData.TabIndex = 2;
            this.btnReadData.Text = "Read Imported Data";
            this.btnReadData.UseVisualStyleBackColor = false;
            this.btnReadData.Click += new System.EventHandler(this.btnReadData_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ColumnHeader1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ColumnHeader2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ColumnHeader3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ColumnHeader4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ColumnHeader5";
            this.Column5.Name = "Column5";
            // 
            // FrmExcelData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 628);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmExcelData";
            this.Text = "FrmExcelData";
            this.Load += new System.EventHandler(this.FrmExcelData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnLoadExcelData;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnReadData;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader colDistrict;
        private System.Windows.Forms.ColumnHeader colCity;
        private System.Windows.Forms.ColumnHeader colTVI;
        private System.Windows.Forms.ColumnHeader colQualification;
        private System.Windows.Forms.ColumnHeader colSector;
        private System.Windows.Forms.ColumnHeader colLastname;
        private System.Windows.Forms.ColumnHeader colFirstname;
        private System.Windows.Forms.ColumnHeader colMiddleInitial;
        private System.Windows.Forms.ColumnHeader colSuffix;
        private System.Windows.Forms.ColumnHeader colFullname;
        private System.Windows.Forms.ColumnHeader colScholarType;
        private System.Windows.Forms.ColumnHeader colTrainStatus;
        private System.Windows.Forms.ColumnHeader colAssessResult;
        private System.Windows.Forms.ColumnHeader colEmpTrain;
        private System.Windows.Forms.ColumnHeader colOccupation;
        private System.Windows.Forms.ColumnHeader colEmployer;
        private System.Windows.Forms.ColumnHeader colEmployType;
        private System.Windows.Forms.ColumnHeader colAllocation;
        private System.Windows.Forms.ColumnHeader colVerifyStatus;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colReferStatus;
        private System.Windows.Forms.ColumnHeader colCompany;
        private System.Windows.Forms.ColumnHeader colAddress;
        private System.Windows.Forms.ColumnHeader colJobTitle;
        private System.Windows.Forms.ColumnHeader colDateEmploy;
        private System.Windows.Forms.ColumnHeader colEmployStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
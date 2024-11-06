namespace Scholarship_Employment
{
    partial class FrmRecords
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "1", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Last name", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "First name", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Middle name", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Sr.", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Unemployed"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "2024"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Qualification NC I")}, -1);
            this.listView = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFirstname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMiddleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colExtnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmpStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGradYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQualification = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClearAllRecords = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbxSearchBy = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colLastname,
            this.colFirstname,
            this.colMiddleName,
            this.colExtnName,
            this.colEmpStatus,
            this.colGradYear,
            this.colQualification});
            this.listView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listView.Location = new System.Drawing.Point(12, 72);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1052, 539);
            this.listView.TabIndex = 4;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.ItemActivate += new System.EventHandler(this.listView_ItemActivate);
            // 
            // colId
            // 
            this.colId.Text = "No.";
            this.colId.Width = 50;
            // 
            // colLastname
            // 
            this.colLastname.Text = "Last name";
            this.colLastname.Width = 100;
            // 
            // colFirstname
            // 
            this.colFirstname.Text = "First name";
            this.colFirstname.Width = 150;
            // 
            // colMiddleName
            // 
            this.colMiddleName.Text = "Middle Name";
            this.colMiddleName.Width = 140;
            // 
            // colExtnName
            // 
            this.colExtnName.Text = "Ext.";
            this.colExtnName.Width = 75;
            // 
            // colEmpStatus
            // 
            this.colEmpStatus.Text = "Status of Employment";
            this.colEmpStatus.Width = 200;
            // 
            // colGradYear
            // 
            this.colGradYear.Text = "Year of Graduation";
            this.colGradYear.Width = 165;
            // 
            // colQualification
            // 
            this.colQualification.Text = "Qualification Title";
            this.colQualification.Width = 167;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(1070, 72);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(75, 23);
            this.btnDetails.TabIndex = 5;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1070, 101);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(1070, 130);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRefresh.Location = new System.Drawing.Point(1070, 251);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClearAllRecords
            // 
            this.btnClearAllRecords.BackColor = System.Drawing.Color.Tomato;
            this.btnClearAllRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAllRecords.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClearAllRecords.Location = new System.Drawing.Point(1070, 166);
            this.btnClearAllRecords.Name = "btnClearAllRecords";
            this.btnClearAllRecords.Size = new System.Drawing.Size(75, 50);
            this.btnClearAllRecords.TabIndex = 8;
            this.btnClearAllRecords.Text = "Clear All Records";
            this.btnClearAllRecords.UseVisualStyleBackColor = false;
            this.btnClearAllRecords.Click += new System.EventHandler(this.btnClearAllRecords_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(74, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(367, 26);
            this.txtSearch.TabIndex = 1;
            // 
            // cbxSearchBy
            // 
            this.cbxSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSearchBy.FormattingEnabled = true;
            this.cbxSearchBy.Items.AddRange(new object[] {
            "Record number",
            "Last name",
            "First name",
            "Middle name",
            "Extension name",
            "Status of Employment",
            "Year of Graduation",
            "Qualification Title"});
            this.cbxSearchBy.Location = new System.Drawing.Point(480, 17);
            this.cbxSearchBy.Name = "cbxSearchBy";
            this.cbxSearchBy.Size = new System.Drawing.Size(261, 26);
            this.cbxSearchBy.TabIndex = 2;
            this.cbxSearchBy.Text = "Search by";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.Location = new System.Drawing.Point(747, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(447, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "By";
            // 
            // FrmRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 623);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbxSearchBy);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClearAllRecords);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.listView);
            this.Name = "FrmRecords";
            this.Text = "Records Table";
            this.Load += new System.EventHandler(this.FrmRecords_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader colLastname;
        private System.Windows.Forms.ColumnHeader colFirstname;
        private System.Windows.Forms.ColumnHeader colMiddleName;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ColumnHeader colExtnName;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClearAllRecords;
        private System.Windows.Forms.ColumnHeader colEmpStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbxSearchBy;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader colGradYear;
        private System.Windows.Forms.ColumnHeader colQualification;
    }
}
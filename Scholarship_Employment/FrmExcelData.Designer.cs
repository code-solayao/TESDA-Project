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
            this.dgvImport = new System.Windows.Forms.DataGridView();
            this.btnLoadExcelData = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pgImport = new System.Windows.Forms.TabPage();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.pgExport = new System.Windows.Forms.TabPage();
            this.dgvExport = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblLoading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.pgImport.SuspendLayout();
            this.pgExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvImport
            // 
            this.dgvImport.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImport.Location = new System.Drawing.Point(20, 20);
            this.dgvImport.Name = "dgvImport";
            this.dgvImport.Size = new System.Drawing.Size(1355, 575);
            this.dgvImport.TabIndex = 0;
            // 
            // btnLoadExcelData
            // 
            this.btnLoadExcelData.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLoadExcelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadExcelData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLoadExcelData.Location = new System.Drawing.Point(19, 613);
            this.btnLoadExcelData.Name = "btnLoadExcelData";
            this.btnLoadExcelData.Size = new System.Drawing.Size(123, 36);
            this.btnLoadExcelData.TabIndex = 1;
            this.btnLoadExcelData.Text = "Load Excel";
            this.btnLoadExcelData.UseVisualStyleBackColor = false;
            this.btnLoadExcelData.Click += new System.EventHandler(this.btnLoadExcelData_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pgImport);
            this.tabControl1.Controls.Add(this.pgExport);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1405, 737);
            this.tabControl1.TabIndex = 3;
            // 
            // pgImport
            // 
            this.pgImport.Controls.Add(this.lblLoading);
            this.pgImport.Controls.Add(this.btnSubmit);
            this.pgImport.Controls.Add(this.lblFilePath);
            this.pgImport.Controls.Add(this.dgvImport);
            this.pgImport.Controls.Add(this.btnLoadExcelData);
            this.pgImport.Location = new System.Drawing.Point(4, 26);
            this.pgImport.Name = "pgImport";
            this.pgImport.Padding = new System.Windows.Forms.Padding(3);
            this.pgImport.Size = new System.Drawing.Size(1397, 707);
            this.pgImport.TabIndex = 0;
            this.pgImport.Text = "Import";
            this.pgImport.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(19, 655);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(200, 36);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit to Database";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilePath.Location = new System.Drawing.Point(148, 621);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(71, 20);
            this.lblFilePath.TabIndex = 2;
            this.lblFilePath.Text = "File Path";
            // 
            // pgExport
            // 
            this.pgExport.Controls.Add(this.dgvExport);
            this.pgExport.Controls.Add(this.btnExport);
            this.pgExport.Location = new System.Drawing.Point(4, 26);
            this.pgExport.Name = "pgExport";
            this.pgExport.Padding = new System.Windows.Forms.Padding(3);
            this.pgExport.Size = new System.Drawing.Size(1397, 707);
            this.pgExport.TabIndex = 1;
            this.pgExport.Text = "Export";
            this.pgExport.UseVisualStyleBackColor = true;
            // 
            // dgvExport
            // 
            this.dgvExport.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExport.Location = new System.Drawing.Point(20, 20);
            this.dgvExport.Name = "dgvExport";
            this.dgvExport.Size = new System.Drawing.Size(1355, 575);
            this.dgvExport.TabIndex = 3;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExport.Location = new System.Drawing.Point(20, 623);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(211, 36);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export as Excel File";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.Location = new System.Drawing.Point(225, 663);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(78, 20);
            this.lblLoading.TabIndex = 4;
            this.lblLoading.Text = "Loading...";
            // 
            // FrmExcelData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 761);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmExcelData";
            this.Text = "Data Import/Export (Excel File)";
            this.Load += new System.EventHandler(this.FrmExcelData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.pgImport.ResumeLayout(false);
            this.pgImport.PerformLayout();
            this.pgExport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvImport;
        private System.Windows.Forms.Button btnLoadExcelData;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pgImport;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.TabPage pgExport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dgvExport;
        private System.Windows.Forms.Label lblLoading;
    }
}
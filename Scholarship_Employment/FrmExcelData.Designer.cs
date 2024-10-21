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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnLoadExcelData = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(695, 426);
            this.dataGridView.TabIndex = 0;
            // 
            // btnLoadExcelData
            // 
            this.btnLoadExcelData.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLoadExcelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadExcelData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLoadExcelData.Location = new System.Drawing.Point(12, 444);
            this.btnLoadExcelData.Name = "btnLoadExcelData";
            this.btnLoadExcelData.Size = new System.Drawing.Size(123, 36);
            this.btnLoadExcelData.TabIndex = 1;
            this.btnLoadExcelData.Text = "Load Excel";
            this.btnLoadExcelData.UseVisualStyleBackColor = false;
            this.btnLoadExcelData.Click += new System.EventHandler(this.btnLoadExcelData_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilePath.Location = new System.Drawing.Point(12, 486);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(695, 26);
            this.txtFilePath.TabIndex = 2;
            // 
            // FrmExcelData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 525);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnLoadExcelData);
            this.Controls.Add(this.dataGridView);
            this.Name = "FrmExcelData";
            this.Text = "FrmExcelData";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnLoadExcelData;
        private System.Windows.Forms.TextBox txtFilePath;
    }
}
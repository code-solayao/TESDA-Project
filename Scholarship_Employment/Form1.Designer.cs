namespace Scholarship_Employment
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Dashboard");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Create Data Entry");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Data Entries");
            this.treeView = new System.Windows.Forms.TreeView();
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView.Location = new System.Drawing.Point(12, 12);
            this.treeView.Name = "treeView";
            treeNode1.Name = "ndDashboard";
            treeNode1.Text = "Dashboard";
            treeNode2.Name = "ndCreateEntry";
            treeNode2.Text = "Create Data Entry";
            treeNode3.Name = "ndDataEntries";
            treeNode3.Text = "Data Entries";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeView.Size = new System.Drawing.Size(250, 837);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel.Location = new System.Drawing.Point(278, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(844, 837);
            this.panel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 861);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.treeView);
            this.Name = "Form1";
            this.Text = "Scholarship Employment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Panel panel;
    }
}


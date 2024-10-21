using System;
using System.Windows.Forms;

namespace Scholarship_Employment
{
    public partial class Form1 : Form
    {
        public static Form1 Instance { get; private set; }

        public Form1()
        {
            InitializeComponent();

            Instance = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Form childForm = null;

            if (e.Node.Name.Equals(treeView.Nodes[0].Name))
            {
                MessageBox.Show("Wala pang dashboard sa ngayon...");
            }
            else if (e.Node.Name.Equals(treeView.Nodes[1].Name))
            {
                childForm = new Form2();
            }
            else if (e.Node.Name.Equals(treeView.Nodes[2].Name))
            {
                childForm = new FrmRecords();
            }
            else if (e.Node.Name.Equals(treeView.Nodes[3].Name))
            {
                childForm = new FrmExcelData();
            }

            if (childForm == null) return;

            childForm.MdiParent = this;
            //childForm.Text = childForm.Text + " - " + childFormNumber++;
            childForm.Show();
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
             
        }
    }
}

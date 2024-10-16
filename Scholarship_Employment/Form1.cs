using MySqlConnector;
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
            Form childForm = new Form();

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
                childForm = new Form4();
            }

            childForm.MdiParent = this;
            //childForm.Text = childForm.Text + " - " + childFormNumber++;
            childForm.Show();
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
             
        }
    }
}

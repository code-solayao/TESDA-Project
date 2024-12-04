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
            TreeViewFunction(e);
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
             
        }

        private void TreeViewFunction(TreeNodeMouseClickEventArgs e)
        {
            Form childForm = null;
            string selectedNode = e.Node.Name;
            TreeNodeCollection Nodes = treeView.Nodes;

            if (selectedNode.Equals(Nodes[0].Name))
            {
                MessageBox.Show("Wala pang dashboard sa ngayon...");
            }
            else if (selectedNode.Equals(Nodes[1].Name))
            {
                childForm = new FrmFullName();
            }
            else if (selectedNode.Equals(Nodes[2].Name))
            {
                childForm = new FrmRecords();
            }
            else if (selectedNode.Equals(Nodes[3].Name))
            {
                childForm = new FrmExcelData();
            }
            else childForm = new Form();

            if (childForm == null) return;

            childForm.Show();
        }
    }
}

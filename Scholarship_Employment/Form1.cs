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
            InitialiseTreeNodes();
        }

        private void treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeViewFunction(e);
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
             
        }

        private void InitialiseTreeNodes()
        {
            // treeView.Nodes.Add(RootNode("Dashboard", "ndDashboard"));
            treeView.Nodes.Add(RootNode("Create Entry", "ndCreateEntry"));
            treeView.Nodes.Add(RootNode("Data Records", "ndDataRecords"));
            // treeView.Nodes.Add(RootNode("Data Import/Export (Excel File)", "ndExcelData"));

            TreeNode RootNode(string text, string name)
            {
                TreeNode node = new TreeNode(text);
                node.Name = name;

                return node;
            }
        }

        private void TreeViewFunction(TreeNodeMouseClickEventArgs e)
        {
            Form childForm = null;

            if (e.Node.Name.Equals(treeView.Nodes[0].Name))
            {
                childForm = new FrmFullName();
                // MessageBox.Show("Wala pang dashboard sa ngayon...");
            }
            else if (e.Node.Name.Equals(treeView.Nodes[1].Name))
            {
                childForm = new FrmRecords();
            }
            else childForm = new Form();

            if (childForm == null) return;

            childForm.Show();
        }
    }
}

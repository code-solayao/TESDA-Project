using MySqlConnector;
using System;
using System.Windows.Forms;

namespace Scholarship_Employment
{
    public partial class Form1 : Form
    {
        Form2 _frmDataEntry;
        Form4 _frmEntryList;

        public Form1()
        {
            InitializeComponent();

            _frmDataEntry = new Form2();
            _frmEntryList = new Form4();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name.Equals(treeView.Nodes[0].Name))
            {
                MessageBox.Show("Wala pang dashboard sa ngayon...");
            }
            else if (e.Node.Name.Equals(treeView.Nodes[1].Name))
            {
                _frmDataEntry.ShowDialog();
            }
            else if (e.Node.Name.Equals(treeView.Nodes[2].Name))
            {
                _frmEntryList.ShowDialog();
            }
        }
    }
}

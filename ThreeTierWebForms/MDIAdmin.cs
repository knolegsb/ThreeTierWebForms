using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeTierWebForms
{
    public partial class MDIAdmin : Form
    {
        public MDIAdmin()
        {
            InitializeComponent();
        }

        private void viewEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewEmployee viewEmployee = new ThreeTierWebForms.ViewEmployee();
            viewEmployee.MdiParent = this;
            viewEmployee.Show();
        }
    }
}

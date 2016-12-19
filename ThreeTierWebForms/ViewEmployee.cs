using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;
using BLL;

namespace ThreeTierWebForms
{
    public partial class ViewEmployee : Form
    {
        public Operations op = new Operations();
        public RegisterInfo info = new RegisterInfo();

        public ViewEmployee()
        {
            InitializeComponent();
        }

        private void ViewEmployee_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = op.ViewEmployees(info);
            dgvEmployees.DataSource = dt;
            dgvEmployees.Columns[0].Visible = false;
            dgvEmployees.Columns[7].Visible = false;
            dgvEmployees.Columns[8].Visible = false;
        }
    }
}

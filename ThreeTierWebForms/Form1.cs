using BEL;
using BLL;
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
    public partial class Form1 : Form
    {
        public RegisterInfo info = new RegisterInfo();
        public Operations op = new Operations();

        string gender;

        public Form1()
        {
            InitializeComponent();
        }

        private void tbRegistration_Click(object sender, EventArgs e)
        {
            info.Name = tbName.Text;
            if(rbMale.Checked == true)
            {
                gender = "Male";
            }
            if(rbFemale.Checked == true)
            {
                gender = "Female";
            }

            info.Gender = gender;

            info.DOB = Convert.ToDateTime(dtpDOB.Value.ToShortDateString());
            info.Address = tbAddress.Text;
            info.Education = cbEducation.Text;
            info.Usename = tbUsername.Text;
            info.Password = tbPassword.Text;

            //int rows = op
            int rows = op.InsertEmp(info);
            if (rows > 0)
            {
                MessageBox.Show("Data Saved Successfully");
            }
        }
    }
}

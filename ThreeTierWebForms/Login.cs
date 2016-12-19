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
    public partial class Login : Form
    {
        public RegisterInfo info = new RegisterInfo();
        public Operations op = new Operations();
        public string userType;

        DataTable dt = new DataTable();

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            info.Usename = tbUsername.Text;
            info.Password = tbPassword.Text;

            dt = op.Login(info);

            if(dt.Rows.Count > 0)
            {
                userType = dt.Rows[0][8].ToString();
                if (userType == "Admin")
                {
                    this.Hide();
                    MDIAdmin mda = new MDIAdmin();
                    mda.Show();
                }
                else
                {
                    this.Hide();
                    MDIEmployee mde = new MDIEmployee();
                    mde.Show();
                }                
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }
    }
}

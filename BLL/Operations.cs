using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BEL;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class Operations
    {
        public DbConnection db = new DbConnection();
        public RegisterInfo info = new RegisterInfo();

        public int InsertEmp(RegisterInfo info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO EmpRegister VALUES ('" + info.Name + "','" + info.Gender + "', '" + info.DOB + "', '" + info.Address + "', '" + info.Education + "', '" + info.Usename + "', '" + info.Password + "', 'U')";
            return db.ExeNonQuery(cmd);
        }

        public DataTable ViewEmployees(RegisterInfo info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM EmpRegister WHERE UserType = 'U'";
            return db.ExeReader(cmd);
        }

        public DataTable Login(RegisterInfo info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM EmpRegister WHERE Username = '" + info.Usename + "' and Password = '" + info.Password + "'";
            return db.ExeReader(cmd);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Document_Management
{
    class Database
    {
        SqlConnection con = new SqlConnection(@"Data Source=ACER-PC;Initial Catalog=USER;Integrated Security=True");

        public bool Execute(string cmd)
        {
            con.Open();
            Boolean check = false;
            try
            {
                SqlCommand sqlcmd = new SqlCommand(cmd, con);
                sqlcmd.ExecuteNonQuery();
                check = true;
            }
            catch (Exception)
            {
                check = false;
            }
            con.Close();
            return check;
        }

        public DataTable Read(string cmd)
        {
            con.Open();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand sqlcmd = new SqlCommand(cmd, con);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlcmd);
                adapter.Fill(dt);
            }
            catch (Exception)
            {
                dt = null;
            }
            con.Close();
            return dt;
        }
    }
}

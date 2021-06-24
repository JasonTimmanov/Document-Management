using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Document_Management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Database database = new Database();

        private string getID(string name, string password)
        {
            string id = "";
            DataTable dt = database.Read("SELECT * FROM tbl_User WHERE User_Name ='" + name + "' AND User_Password = '" + password + "'");
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                    id = dr["User_ID"].ToString();
            }
            return id;
        }

        public static string ID_USER = "";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ID_USER = getID(txbName.Text, txbPassword.Text);
            if (ID_USER != "")
            {
                MessageBox.Show("Đăng nhập thành công.");
                Welcome welcome = new Welcome();
                welcome.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

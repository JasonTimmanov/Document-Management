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
    public partial class User_Info : Form
    {
        public User_Info()
        {
            InitializeComponent();
        }

        Database database = new Database();

        private void btnChangeName_Click(object sender, EventArgs e)
        {
            Change_Name changename = new Change_Name();
            changename.Show();
            this.Hide();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            Change_Password changepassword = new Change_Password();
            changepassword.Show();
            this.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            this.Hide();
        }

        private void User_Info_Load(object sender, EventArgs e)
        {
            string Name = "", Perm = "";
            DataTable dt = database.Read("SELECT * FROM tbl_user WHERE user_ID ='" + Login.ID_USER + "'");
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Name = dr["user_name"].ToString();
                    Perm = dr["user_perm"].ToString();
                }
            }
            txbName.Text = Name;
            txbPerm.Text = Perm;
        }
    }
}

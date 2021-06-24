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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        Database database = new Database();

        private void btnUserMng_Click(object sender, EventArgs e)
        {
            string Perm = "";
            DataTable dt = database.Read("SELECT * FROM tbl_User WHERE User_ID ='" + Login.ID_USER + "'");
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                    Perm = dr["User_Perm"].ToString();
            }
            if (Perm.ToString().Equals("Admin"))
            {
                User_Management usermng = new User_Management();
                usermng.Show();
                this.Hide();
            }         
            else
                MessageBox.Show("Chỉ có admin mới có quyền truy cập vào đây.");
        }

        private void btnDocMng_Click(object sender, EventArgs e)
        {
            Doc_Management docmng = new Doc_Management();
            docmng.Show();
            this.Hide();
        }

        private void btnDocSearch_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
            this.Hide();
        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            User_Info userinfo = new User_Info();
            userinfo.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            string Perm = "";
            DataTable dt = database.Read("SELECT * FROM tbl_User WHERE User_ID ='" + Login.ID_USER + "'");
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                    Perm = dr["User_Perm"].ToString();
            }
            if (Perm.ToString().Equals("Nhân viên"))
                MessageBox.Show("Chỉ có admin hoặc trưởng phòng mới có quyền truy cập vào đây.");
            else
            {
                Verify verify = new Verify();
                verify.Show();
                this.Hide();
            }
        }
    }
}

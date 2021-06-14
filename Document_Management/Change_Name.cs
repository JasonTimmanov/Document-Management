using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Document_Management
{
    public partial class Change_Name : Form
    {
        public Change_Name()
        {
            InitializeComponent();
        }

        Database database = new Database();

        private void btnChange_Click(object sender, EventArgs e)
        {
            string name = "";
            DataTable dt = database.Read("SELECT * FROM tbl_user WHERE user_ID = '" + Login.ID_USER + "' AND user_password = '" + txbPassword.Text + "'");
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                    name = dr["user_name"].ToString();
            }
            if (name != "")
            {
                database.Read("UPDATE tbl_user SET user_name ='" + txbName.Text + "' WHERE user_id = '" + Login.ID_USER + "'");
                MessageBox.Show("Đổi tên thành công.");
                User_Info userinfo = new User_Info();
                userinfo.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Sai mật khẩu, vui lòng thử lại.");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            User_Info userinfo = new User_Info();
            userinfo.Show();
            this.Hide();
        }
    }
}

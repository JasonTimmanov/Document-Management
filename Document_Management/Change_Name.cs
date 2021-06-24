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
            DataTable dt = database.Read("SELECT * FROM tbl_User WHERE User_ID = '" + Login.ID_USER + "' AND User_Password = '" + txbPassword.Text + "'");
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                    name = dr["User_Name"].ToString();
            }
            if (name != "")
            {
                database.Read("UPDATE tbl_User SET User_Name ='" + txbName.Text + "' WHERE User_ID = '" + Login.ID_USER + "'");
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

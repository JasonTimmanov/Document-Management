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
    public partial class User_Management : Form
    {
        public User_Management()
        {
            InitializeComponent();
        }

        Database database = new Database();

        public static int ID = 1;

        private void Loaddata()
        {
            DataTable dt = database.Read("SELECT * FROM tbl_user");
            if (dt != null)
                dataGridView1.DataSource = dt;
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            dataGridView1.Columns[0].HeaderText = "ID người dùng";
            dataGridView1.Columns[1].HeaderText = "Tên người dùng";
            dataGridView1.Columns[2].HeaderText = "Mật khẩu";
            dataGridView1.Columns[3].HeaderText = "Vai trò";
            for (int i = 0; i < 4; i++)
                dataGridView1.Columns[i].Width = 125;
        }

        private void Adddata()
        {
            if (database.Execute("INSERT INTO tbl_user VALUES ('" + txbID.Text + "','" + txbName.Text + "','" + txbPassword.Text + "',N'" + cbbPerm.Text + "')"))
            {
                MessageBox.Show("Thêm người dùng thành công.");
                Loaddata();
            }
            else
                MessageBox.Show("Thêm người dùng thất bại.");
        }

        private void Clearform()
        {
            txbID.Text = "";
            txbName.Text = "";
            txbPassword.Text = "";
            cbbPerm.Text = "Nhân viên";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbID.Text == "" || txbName.Text == "" || cbbPerm.Text == "")
                MessageBox.Show("Vui lòng nhập đầy đủ ID, tên, và vai trò.");
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    if (Convert.ToInt32(txbID.Text.ToString()) == Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("Người dùng với ID này đã tồn tại.");
                        return;
                    }
                    else
                    {
                        if (txbPassword.Text == "")
                        {
                            DialogResult dialog = MessageBox.Show("Password nếu không nhập gì cả sẽ được đặt mặc định là 0000. Bạn có chắc muốn tiếp tục?", "Xác nhận", MessageBoxButtons.YesNo);
                            if (dialog == DialogResult.Yes)
                            {
                                txbPassword.Text = "0000";
                                Adddata();
                                Clearform();
                                return;
                            }
                            else
                                return;
                        }
                        else
                        {
                            Adddata();
                            Clearform();
                            return;
                        }
                    }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ID == 1)
            {
                MessageBox.Show("Không thể xóa người dùng này.");
                return;
            }
            else
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (ID == Convert.ToInt32(Login.ID_USER))
                    {
                        MessageBox.Show("Không thể xóa chính bản thân người dùng, vui lòng chọn ID của người dùng khác cần xóa.");
                        return;
                    }
                    else
                    {
                        DialogResult dialog = MessageBox.Show("Bạn có chắc muốn xóa người dùng có ID " + txbID.Text + "?", "Xác nhận", MessageBoxButtons.YesNo);
                        if (dialog == DialogResult.Yes)
                        {
                            if (database.Execute("DELETE tbl_user WHERE user_id = '" + txbID.Text + "'"))
                            {
                                MessageBox.Show("Xóa người dùng thành công.");
                                Loaddata();
                                Clearform();
                                return;
                            }
                        }
                        else return;
                    }
                }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txbID.Text != "" && txbName.Text != "" && txbPassword.Text != "" && cbbPerm.Text != "")
            {
                DialogResult dialog = MessageBox.Show("Bạn có chắc muốn sửa thông tin của người dùng có ID " + txbID.Text + "?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    if (database.Execute("UPDATE tbl_user SET user_name = '" + txbName.Text + "', user_password = '" + txbPassword.Text + "', user_perm = N'" + cbbPerm.Text + "' WHERE user_id = '" + txbID.Text + "'"))
                    {
                        MessageBox.Show("Sửa người dùng thành công.");
                        Loaddata();
                        Clearform();
                        return;
                    }
                }
                else return;
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần sửa.");
        }

        private void User_Management_Load(object sender, EventArgs e)
        {
            Clearform();
            Loaddata();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txbID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            ID = Convert.ToInt32(txbID.Text);
            txbName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txbPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbbPerm.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            Hide();
        }
    }
}

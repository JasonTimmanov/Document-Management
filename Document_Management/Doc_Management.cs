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
    public partial class Doc_Management : Form
    {
        public Doc_Management()
        {
            InitializeComponent();
        }

        Database database = new Database();

        private void LoadData()
        {
            DataTable dt = database.Read("SELECT * FROM tbl_Document");
            if (dt != null)
                dataGridView1.DataSource = dt;
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            dataGridView1.Columns[0].HeaderText = "Số công văn";
            dataGridView1.Columns[1].HeaderText = "Loại công văn";
            dataGridView1.Columns[2].HeaderText = "Tên công văn";
            dataGridView1.Columns[3].HeaderText = "Ngày công văn";
            dataGridView1.Columns[4].HeaderText = "Ngày đến";
            dataGridView1.Columns[5].HeaderText = "Nơi đến";
            dataGridView1.Columns[6].HeaderText = "Người ký nhận";
            dataGridView1.Columns[7].HeaderText = "Đã phê duyệt";
            for (int i = 0; i < 8; i++)
                dataGridView1.Columns[i].Width = 110;
        }

        private void ClearData()
        {
            txbNumber.Text = "";
            txbType.Text = "";
            dtpArrivalDate.Text = "";
            dtpDocDate.Text = "";
            txbPlace.Text = "";
            txbSign.Text = "";
            rtbDocName.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbNumber.Text == "" || txbType.Text == "" || rtbDocName.Text == "" || txbPlace.Text == "" || txbSign.Text == "")
                MessageBox.Show("Vui lòng nhập đầy đủ các thông tin cần thiết.");
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    if (txbNumber.Text.Equals(dataGridView1.Rows[i].Cells[0].Value))
                    {
                        MessageBox.Show("Số công văn này đã tồn tại, không thể thêm vào.");
                        return;
                    }
                    else
                    {
                        if (database.Execute("INSERT INTO tbl_Document VALUES (N'" + txbNumber.Text + "',N'" + txbType.Text + "',N'" + rtbDocName.Text + "','" + dtpDocDate.Value.Date + "','" + dtpArrivalDate.Value.Date + "',N'" + txbPlace.Text + "',N'" + txbSign.Text + "','" + false + "')"))
                        {
                            MessageBox.Show("Thêm công văn thành công.");
                            LoadData();
                            ClearData();
                            return;
                        }
                        else
                            MessageBox.Show("Thêm công văn thất bại.");
                    }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
                MessageBox.Show("Không có công văn nào trong dữ liệu");
            else if (txbNumber.Text == "")
                MessageBox.Show("Vui lòng nhập số công văn của công văn cần xóa.");
            else
            {
                DialogResult dialog = MessageBox.Show("Bạn có chắc muốn xóa công văn có số công văn là " + txbNumber.Text + "?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    if (database.Execute("DELETE tbl_Document WHERE So_Cong_Van = '" + txbNumber.Text + "'"))
                    {
                        MessageBox.Show("Xóa công văn thành công.");
                        LoadData();
                        ClearData();
                        return;
                    }
                }
                else return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txbNumber.Text == "")
                MessageBox.Show("Vui lòng nhập số công văn của công văn cần sửa.");
            else
            {
                if (txbType.Text == "" || rtbDocName.Text == "" || txbPlace.Text == "" || txbSign.Text == "")
                    MessageBox.Show("Vui lòng nhập đầy đủ các thông tin.");
                else
                {
                    DialogResult dialog = MessageBox.Show("Bạn có chắc muốn sửa công văn có số công văn là " + txbNumber.Text + "?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        if (database.Execute("UPDATE tbl_Document SET Loai_Cong_Van = N'" + txbType.Text + "',Ten_Cong_Van = N'" + rtbDocName.Text + "',Ngay_Cong_Van = '" + dtpDocDate.Value.Date + "',Ngay_Den = '" + dtpArrivalDate.Value.Date + "',Noi_Den = N'" + txbPlace.Text + "',Nguoi_Ky_Nhan = N'" + txbSign.Text + "' WHERE So_Cong_Van = '" + txbNumber.Text + "'"))
                        {
                            MessageBox.Show("Sửa công văn thành công.");
                            LoadData();
                            ClearData();
                            return;
                        }
                    }
                    else return;
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            this.Hide();
        }

        private void Doc_Management_Load(object sender, EventArgs e)
        {
            ClearData();
            LoadData();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txbNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txbType.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            rtbDocName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtpDocDate.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtpArrivalDate.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txbPlace.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txbSign.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
            Hide();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            string Perm = "";
            DataTable dt = database.Read("SELECT * FROM tbl_user WHERE user_ID ='" + Login.ID_USER + "'");
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                    Perm = dr["user_perm"].ToString();
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

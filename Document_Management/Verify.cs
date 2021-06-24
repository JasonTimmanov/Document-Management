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
    public partial class Verify : Form
    {
        public Verify()
        {
            InitializeComponent();
        }

        Database database = new Database();

        private void LoadData()
        {
            DataTable dt = database.Read("SELECT * FROM tbl_Document");
            if (dt != null)
                dataGridView1.DataSource = dt;
            dataGridView1.ClearSelection();
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

        private void Verify_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void rdbShowAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbShowAll.Checked == true)
            {
                LoadData();
            }
        }

        private void rdbShowUnchecked_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbShowUnchecked.Checked == true)
            {
                DataTable dt = database.Read("SELECT * FROM tbl_Document WHERE Legit_Status = '" + false + "'");
                if (dt != null)
                    dataGridView1.DataSource = dt;
                dataGridView1.ClearSelection();
                dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            }
        }

        private void rdbShowChecked_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbShowChecked.Checked == true)
            {
                DataTable dt = database.Read("SELECT * FROM tbl_Document WHERE Legit_Status = '" + true + "'");
                if (dt != null)
                    dataGridView1.DataSource = dt;
                dataGridView1.ClearSelection();
                dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            }
        }

        private void btnReturnWelcome_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            this.Hide();
        }

        private void btnReturnMng_Click(object sender, EventArgs e)
        {
            Doc_Management docmng = new Doc_Management();
            docmng.Show();
            this.Hide();
        }

        private void ClearData()
        {
            txbNumber.Text = "";
            cbLegit.Checked = false;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thay đổi trạng thái của công văn này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (!cbLegit.Checked)
                {
                    if (database.Execute("UPDATE tbl_Document SET Legit_Status = '" + true + "' WHERE Doc_Number = N'" + txbNumber.Text + "'"))
                    {
                        MessageBox.Show("Thay đổi trạng thái công văn thành công.");
                        LoadData();
                        ClearData();
                    }
                }
                else
                {
                    if (database.Execute("UPDATE tbl_Document SET Legit_Status = '" + false + "' WHERE Doc_Number = N'" + txbNumber.Text + "'"))
                    {
                        MessageBox.Show("Thay đổi trạng thái công văn thành công.");
                        LoadData();
                        ClearData();
                    }
                }
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txbNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbLegit.Checked = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString());
        }
    }
}

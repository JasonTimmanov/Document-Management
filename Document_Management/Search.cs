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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        Database database = new Database();

        private void Loaddata()
        {
            DataTable dt = database.Read("SELECT * FROM tbl_Document");
            if (dt != null)
                dataGridView1.DataSource = dt;
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

        private void btnReload_Click(object sender, EventArgs e)
        {
            Clear_Select();
            Loaddata();
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void btnReturnWelcome_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            Hide();
        }

        private void btnReturnMng_Click(object sender, EventArgs e)
        {
            Doc_Management docmng = new Doc_Management();
            docmng.Show();
            Hide();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            Loaddata();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void Clear_Select()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
                row.Selected = false;
            txbNumber.Text = "";
            txbType.Text = "";
            rtbDocName.Text = "";
            txbPlace.Text = "";
            txbSign.Text = "";
            dtpDocDate.Value = DateTime.Today;
            dtpArrivalDate.Value = DateTime.Today;
            cbLegit.Checked = false;
            cbbDocMonth.Text = DateTime.Today.Month.ToString();
            nudDocYear.Value = DateTime.Today.Year;
            cbbArrivalMonth.Text = DateTime.Today.Month.ToString();
            nudArrivalYear.Value = DateTime.Today.Year;
        }

        private void txbNumber_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = database.Read("SELECT * FROM tbl_Document WHERE Doc_Number LIKE N'" + txbNumber.Text + "%'");
            if (dt != null)
                dataGridView1.DataSource = dt;
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void txbType_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = database.Read("SELECT * FROM tbl_Document WHERE Doc_Type LIKE N'" + txbType.Text + "%'");
            if (dt != null)
                dataGridView1.DataSource = dt;
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void rtbDocName_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = database.Read("SELECT * FROM tbl_Document WHERE Doc_Name LIKE N'" + rtbDocName.Text + "%'");
            if (dt != null)
                dataGridView1.DataSource = dt;
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void dtpDocDate_ValueChanged(object sender, EventArgs e)
        {
            DataTable dt = database.Read("SELECT * FROM tbl_Document WHERE Doc_Date = '" + dtpDocDate.Value.Date + "'");
            if (dt != null)
                dataGridView1.DataSource = dt;
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void dtpArrivalDate_ValueChanged(object sender, EventArgs e)
        {
            DataTable dt = database.Read("SELECT * FROM tbl_Document WHERE Arrival_Date = '" + dtpArrivalDate.Value.Date + "'");
            if (dt != null)
                dataGridView1.DataSource = dt;
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void txbPlace_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = database.Read("SELECT * FROM tbl_Document WHERE Arrival_Place LIKE N'" + txbPlace.Text + "%'");
            if (dt != null)
                dataGridView1.DataSource = dt;
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void txbSign_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = database.Read("SELECT * FROM tbl_Document WHERE Sign_Name LIKE N'" + txbSign.Text + "%'");
            if (dt != null)
                dataGridView1.DataSource = dt;
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void cbLegit_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = database.Read("SELECT * FROM tbl_Document WHERE Legit_Status = '" + cbLegit.Checked + "'");
            if (dt != null)
                dataGridView1.DataSource = dt;
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void cbbDocMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = database.Read("SELECT * FROM tbl_Document WHERE Month(Doc_Date) = '" + cbbDocMonth.Text + "'");
            if (dt != null)
                dataGridView1.DataSource = dt;
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void nudDocYear_ValueChanged(object sender, EventArgs e)
        {
            DataTable dt = database.Read("SELECT * FROM tbl_Document WHERE Year(Doc_Date) = '" + nudDocYear.Value + "'");
            if (dt != null)
                dataGridView1.DataSource = dt;
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void cbbArrivalMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = database.Read("SELECT * FROM tbl_Document WHERE Month(Arrival_Date) = '" + cbbArrivalMonth.Text + "'");
            if (dt != null)
                dataGridView1.DataSource = dt;
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void nudArrivalYear_ValueChanged(object sender, EventArgs e)
        {
            DataTable dt = database.Read("SELECT * FROM tbl_Document WHERE Year(Arrival_Date) = '" + nudArrivalYear.Value + "'");
            if (dt != null)
                dataGridView1.DataSource = dt;
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }
    }
}

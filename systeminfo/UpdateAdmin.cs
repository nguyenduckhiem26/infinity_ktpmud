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
using System.Configuration;

namespace systeminfo
{
    public partial class UpdateAdmin : Form
    {
        public UpdateAdmin()
        {
            InitializeComponent();
        }
        CLSconnect cls = new CLSconnect();
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateAdmin_Load(object sender, EventArgs e)
        {
            dwgAdmin.DataSource = cls.LoadDataAdmin();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMANV.Text = "";
            TXTMK.Text = "";
            TXTTK.Text = "";
        }

        
        public bool KTThongTin()
        {
            if (txtMANV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Mã NV", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMANV.Focus();
                return false;
            }
            if (TXTMK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Mật Khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TXTMK.Focus();
                return false;
            }
            if (TXTTK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Tài Khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TXTTK.Focus();
                return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (KTThongTin())
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "add-admin";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MANV", SqlDbType.Decimal).Value = txtMANV.Text;
                    cmd.Parameters.Add("@TAIKHOAN", SqlDbType.NVarChar).Value = TXTTK.Text;
                    cmd.Parameters.Add("@MATKHAU", SqlDbType.NVarChar).Value = TXTMK.Text;
                    
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dwgAdmin.DataSource = cls.LoadDataAdmin(); ;
                    txtMANV.Text = "";
                    TXTMK.Text = "";
                    TXTTK.Text = "";
                    MessageBox.Show("Đã thêm mới quyền admin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dwgAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dwgAdmin.Rows[e.RowIndex];
            txtMANV.Text = Convert.ToString(row.Cells["MaNv"].Value);
            TXTTK.Text = Convert.ToString(row.Cells["TaiKhoan"].Value);
            TXTMK.Text = Convert.ToString(row.Cells["MatKhau"].Value);
            
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            if (txtMANV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã NV cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMANV.Focus();
            }
            else if (KTThongTin())
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "change_bang_admin";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MANV", SqlDbType.Int).Value = Convert.ToInt32(txtMANV.Text);
                    cmd.Parameters.Add("@TAIKHOAN", SqlDbType.NVarChar).Value = TXTTK.Text;
                    cmd.Parameters.Add("@MATKHAU", SqlDbType.NVarChar).Value = TXTMK.Text;
                   

                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dwgAdmin.DataSource = cls.LoadDataAdmin();
                    txtMANV.Text = "";
                    TXTMK.Text = "";
                    TXTTK.Text = "";
                    MessageBox.Show("Đã sửa ADMIN thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMANV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã NV", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMANV.Focus();
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "delete_bang_admin";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MANV", SqlDbType.Int).Value = Convert.ToInt32(txtMANV.Text);

                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dwgAdmin.DataSource = cls.LoadDataAdmin();
                    txtMANV.Text = "";
                    TXTMK.Text = "";
                    TXTTK.Text = "";
                    MessageBox.Show("Đã xóa quyền ADMIN thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            selectForm SE = new selectForm();
            SE.Show();
            this.Hide();
        }
    }
}

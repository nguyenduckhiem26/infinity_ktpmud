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

    public partial class UpdateRAMMAD : Form
    {
        public UpdateRAMMAD()
        {
            InitializeComponent();
            MaximizeBox = false;
        }
        CLSconnect cls = new CLSconnect();
        private void label4_Click(object sender, EventArgs e)
        {

        }
        public bool KTThongTin()
        {
            if (txtBrand.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Brand", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBrand.Focus();
                return false;
            }
            if (txtModel.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Model", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtModel.Focus();
                return false;
            }
            if (txtRamInterface.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Interface", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRamInterface.Focus();
                return false;
            }
            if (txtSpeed.Text == "")
            {
                MessageBox.Show("Vui lòng nhập speed", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSpeed.Focus();
                return false;
            }
            if (txtCapacity.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Capacity", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCapacity.Focus();
                return false;
            }
            if (txtLink.Text == "")
            {
                MessageBox.Show("Vui lòng nhập link", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLink.Focus();
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

                    cmd.CommandText = "add_Ram";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@BRAND", SqlDbType.NVarChar).Value = txtBrand.Text;
                    cmd.Parameters.Add("@MODEL", SqlDbType.NVarChar).Value = txtModel.Text;
                    cmd.Parameters.Add("@RAMINTERFACE", SqlDbType.NVarChar).Value = txtRamInterface.Text;
                    cmd.Parameters.Add("@SPEED", SqlDbType.NVarChar).Value = txtSpeed.Text;
                    cmd.Parameters.Add("@CAPACITY", SqlDbType.NVarChar).Value = txtCapacity.Text;
                    cmd.Parameters.Add("@LINK", SqlDbType.NVarChar).Value = txtLink.Text;

                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dwgRam.DataSource = cls.LoadDataram(); ;
                    txtBrand.Text = "";
                    txtModel.Text = "";
                    txtRamInterface.Text = "";
                    txtSpeed.Text = "";
                    txtCapacity.Text = "";
                    txtLink.Text = "";
                    MessageBox.Show("Đã thêm mới mẫu RAM", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UpdateRAMMAD_Load(object sender, EventArgs e)
        {
            dwgRam.DataSource = cls.LoadDataram();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBrand.Text = "";
            txtModel.Text = "";
            txtRamInterface.Text = "";
            txtSpeed.Text = "";
            txtCapacity.Text = "";
            txtLink.Text = "";
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            if (txtModel.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Model RAM cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtModel.Focus();
            }
            else if (KTThongTin())
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "change_ram";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@BRAND", SqlDbType.NVarChar).Value = txtBrand.Text;
                    cmd.Parameters.Add("@MODEL", SqlDbType.NVarChar).Value = txtModel.Text;
                    cmd.Parameters.Add("@RAMINTERFACE", SqlDbType.NVarChar).Value = txtRamInterface.Text;
                    
                    cmd.Parameters.Add("@SPEED", SqlDbType.NVarChar).Value = txtSpeed.Text;
                    cmd.Parameters.Add("@CAPACITY", SqlDbType.NVarChar).Value = txtCapacity.Text;
                    cmd.Parameters.Add("@LINK", SqlDbType.NVarChar).Value = txtLink.Text;


                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dwgRam.DataSource = cls.LoadDataram();
                    txtBrand.Text = "";
                    txtModel.Text = "";
                    txtRamInterface.Text = "";
                    txtSpeed.Text = "";
                    txtCapacity.Text = "";
                    txtLink.Text = "";
                    MessageBox.Show("Đã sửa mẫu RAM thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtModel.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã NV", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtModel.Focus();
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "DELETE_RAM";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MODEL", SqlDbType.NVarChar).Value = txtModel.Text;

                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dwgRam.DataSource = cls.LoadDataram();
                    txtBrand.Text = "";
                    txtModel.Text = "";
                    txtRamInterface.Text = "";
                    txtSpeed.Text = "";
                    txtCapacity.Text = "";
                    txtLink.Text = "";
                    MessageBox.Show("Đã xóa mẫu ram thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dwgRam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dwgRam.Rows[e.RowIndex];
            txtBrand.Text = Convert.ToString(row.Cells["Brand"].Value);
            txtModel.Text = Convert.ToString(row.Cells["Model"].Value);
            txtRamInterface.Text = Convert.ToString(row.Cells["RAMInterface"].Value);
            txtSpeed.Text = Convert.ToString(row.Cells["Speed"].Value);
            txtCapacity.Text = Convert.ToString(row.Cells["Capacity"].Value);
            txtLink.Text = Convert.ToString(row.Cells["Link"].Value);
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            selectForm SE = new selectForm();
            SE.Show();
            this.Hide();
        }
    }
}

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
    public partial class UpdateLAPAD : Form
    {
        public UpdateLAPAD()
        {
            InitializeComponent();
        }
        CLSconnect cls = new CLSconnect();
        private void label2_Click(object sender, EventArgs e)
        {

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

                    cmd.CommandText = "add_LAPTOP";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@BRAND", SqlDbType.Decimal).Value = txtlaptopbrand.Text;
                    cmd.Parameters.Add("@MODEL", SqlDbType.NVarChar).Value = txtmodel.Text;
                    cmd.Parameters.Add("@SLOT", SqlDbType.NVarChar).Value = txtssdslot.Text;
                    cmd.Parameters.Add("@SSDINTERFACE", SqlDbType.Decimal).Value = txtssdinterface.Text;
                    cmd.Parameters.Add("@SSDFORMFACTOR", SqlDbType.NVarChar).Value = txtssdFormFactor.Text;
                    cmd.Parameters.Add("@RAMSLOT", SqlDbType.NVarChar).Value = txtRAMslot.Text;
                    cmd.Parameters.Add("@RAMINTERFACE", SqlDbType.Decimal).Value = txtRAMInterface.Text;
                    cmd.Parameters.Add("@RAMSPEEDSUPPORT", SqlDbType.NVarChar).Value = txtRAMSpeedSupport.Text;
                    cmd.Parameters.Add("@RAMCAPACITYPERSLOT", SqlDbType.NVarChar).Value = txtRamCapacityPerSlot.Text;

                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dwgLAPTOP.DataSource = cls.LoadDataLaptop(); ;
                    txtlaptopbrand.Text = "";
                    txtmodel.Text = "";
                    txtssdslot.Text = "";
                    txtssdinterface.Text = "";
                    txtssdFormFactor.Text = "";
                    txtRAMslot.Text = "";
                    txtRAMInterface.Text = "";
                    txtRAMSpeedSupport.Text = "";
                    txtRamCapacityPerSlot.Text = "";
                    MessageBox.Show("Đã thêm mới mẫu laptop thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UpdateLAPAD_Load(object sender, EventArgs e)
        {
            dwgLAPTOP.DataSource = cls.LoadDataLaptop();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtlaptopbrand.Text = "";
            txtmodel.Text = "";
            txtssdslot.Text = "";
            txtssdinterface.Text = "";
            txtssdFormFactor.Text = "";
            txtRAMslot.Text = "";
            txtRAMInterface.Text = "";
            txtRAMSpeedSupport.Text = "";
            txtRamCapacityPerSlot.Text = "";
        }
        public bool KTThongTin()
        {
            if (txtmodel.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Mã model", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmodel.Focus();
                return false;
            }
            if (txtlaptopbrand.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Brand", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtlaptopbrand.Focus();
                return false;
            }
            if (txtssdslot.Text == "")
            {
                MessageBox.Show("Vui lòng nhập SSD Slot ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtssdslot.Focus();
                return false;
            }
            if (txtssdinterface.Text == "")
            {
                MessageBox.Show("Vui lòng nhập SSD interface", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtssdinterface.Focus();
                return false;
            }
            if (txtssdFormFactor.Text == "")
            {
                MessageBox.Show("Vui lòng nhập SSD Form Factor", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtssdFormFactor.Focus();
                return false;
            }
            if (txtRAMslot.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Ram Slot", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRAMslot.Focus();
                return false;
            }
            if (txtRAMInterface.Text == "")
            {
                MessageBox.Show("Vui lòng nhập RAM Interface", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRAMInterface.Focus();
                return false;
            }
            if (txtRAMSpeedSupport.Text == "")
            {
                MessageBox.Show("Vui lòng nhập RAM Speed Support", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRAMSpeedSupport.Focus();
                return false;
            }
            if (txtRamCapacityPerSlot.Text == "")
            {
                MessageBox.Show("Vui lòng nhập RAM Capacity Per Slot", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRamCapacityPerSlot.Focus();
                return false;
            }
            return true;
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            if (txtmodel.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin mã laptop cần sửa lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmodel.Focus();
            }
            else if (KTThongTin())
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "change_LAPTOP";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@BRAND", SqlDbType.Int).Value = txtlaptopbrand.Text;
                    cmd.Parameters.Add("@MODEL", SqlDbType.NVarChar).Value = txtmodel.Text;
                    cmd.Parameters.Add("@SSDSLOT", SqlDbType.NVarChar).Value = txtssdslot.Text;

                    cmd.Parameters.Add("@SSDINTERFACE", SqlDbType.Int).Value = txtssdinterface.Text;
                    cmd.Parameters.Add("@SSDFORMFACTOR", SqlDbType.NVarChar).Value = txtssdFormFactor.Text;
                    cmd.Parameters.Add("@RAMSLOT", SqlDbType.NVarChar).Value = txtRAMslot.Text;

                    cmd.Parameters.Add("@RAMINTERFACE", SqlDbType.Int).Value = txtRAMInterface.Text;
                    cmd.Parameters.Add("@RAMSPEEDSUPPORT", SqlDbType.NVarChar).Value = txtRAMSpeedSupport.Text;
                    cmd.Parameters.Add("@RAMCAPACITYPERSLOT", SqlDbType.NVarChar).Value = txtRamCapacityPerSlot.Text;


                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dwgLAPTOP.DataSource = cls.LoadDataLaptop();
                    txtlaptopbrand.Text = "";
                    txtmodel.Text = "";
                    txtssdslot.Text = "";
                    txtssdinterface.Text = "";
                    txtssdFormFactor.Text = "";
                    txtRAMslot.Text = "";
                    txtRAMInterface.Text = "";
                    txtRAMSpeedSupport.Text = "";
                    txtRamCapacityPerSlot.Text = "";
                    MessageBox.Show("Đã sửa thông tin laptop thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            row = dwgLAPTOP.Rows[e.RowIndex];
            txtlaptopbrand.Text = Convert.ToString(row.Cells["[Laptop Brand]"].Value);
            txtmodel.Text = Convert.ToString(row.Cells["[Laptop Models]"].Value);
            txtssdslot.Text = Convert.ToString(row.Cells["[SSD slots]"].Value);
            txtssdinterface.Text = Convert.ToString(row.Cells["[SSD interface]"].Value);
            txtssdFormFactor.Text = Convert.ToString(row.Cells["[SSD form factor]"].Value);
            txtRAMslot.Text = Convert.ToString(row.Cells["[RAM slots]"].Value);
            txtRAMInterface.Text = Convert.ToString(row.Cells["[RAM interface]"].Value);
            txtRAMSpeedSupport.Text = Convert.ToString(row.Cells["[RAM speed support]"].Value);
            txtRamCapacityPerSlot.Text = Convert.ToString(row.Cells["[RAM capacity per slot]"].Value);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtmodel.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã laptop", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmodel.Focus();
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "DELETE_LAPTOP";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@LAPTOPMODEL", SqlDbType.NVarChar).Value = txtmodel.Text;

                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dwgLAPTOP.DataSource = cls.LoadDataLaptop();
                    txtlaptopbrand.Text = "";
                    txtmodel.Text = "";
                    txtssdslot.Text = "";
                    txtssdinterface.Text = "";
                    txtssdFormFactor.Text = "";
                    txtRAMslot.Text = "";
                    txtRAMInterface.Text = "";
                    txtRAMSpeedSupport.Text = "";
                    txtRamCapacityPerSlot.Text = "";
                    MessageBox.Show("Đã xóa mẫu laptop thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

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
    public partial class UpdateSSDAD : Form
    {
        public UpdateSSDAD()
        {
            InitializeComponent();
        }
        CLSconnect cls = new CLSconnect();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public bool KTThongTin()
        {
            if (txtmodel.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Mã model", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmodel.Focus();
                return false;
            }
            if (txtbrand.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Brand", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbrand.Focus();
                return false;
            }
            if (txtinterface.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Interface ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtinterface.Focus();
                return false;
            }
            if (txtformfactor.Text == "")
            {
                MessageBox.Show("Vui lòng nhập SSD Form Factor", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtformfactor.Focus();
                return false;
            }
            if (txtcontroller.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Controller", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtcontroller.Focus();
                return false;
            }
            if (txtDRAM.Text == "")
            {
                MessageBox.Show("Vui lòng nhập DRAM", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDRAM.Focus();
                return false;
            }
            if (txtNANDBrand.Text == "")
            {
                MessageBox.Show("Vui lòng nhập NAND Brand", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNANDBrand.Focus();
                return false;
            }
            if (txtType.Text == "")
            {
                MessageBox.Show("Vui lòng nhập NAND Type", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtType.Focus();
                return false;
            }
            if (txtCategories.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Categories", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCategories.Focus();
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

                    cmd.CommandText = "add_SSD";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@BRAND", SqlDbType.Decimal).Value = txtbrand.Text;
                    cmd.Parameters.Add("@MODEL", SqlDbType.NVarChar).Value = txtmodel.Text;
                    cmd.Parameters.Add("@INTERFACE", SqlDbType.NVarChar).Value = txtinterface.Text;
                    cmd.Parameters.Add("@SSDFORMFACTOR", SqlDbType.Decimal).Value = txtformfactor.Text;
                    cmd.Parameters.Add("@CONTROLLER", SqlDbType.NVarChar).Value = txtcontroller.Text;
                    cmd.Parameters.Add("DRAM", SqlDbType.NVarChar).Value = txtDRAM.Text;
                    cmd.Parameters.Add("@NANDBRAND", SqlDbType.Decimal).Value = txtNANDBrand.Text;
                    cmd.Parameters.Add("@NANDTYPE", SqlDbType.NVarChar).Value = txtType.Text;
                    cmd.Parameters.Add("@CATEGORIES", SqlDbType.NVarChar).Value = txtCategories.Text;

                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dwgSSD.DataSource = cls.LoadDataSSD(); ;
                    txtbrand.Text = "";
                    txtmodel.Text = "";
                    txtinterface.Text = "";
                    txtformfactor.Text = "";
                    txtcontroller.Text = "";
                    txtDRAM.Text = "";
                    txtNANDBrand.Text = "";
                    txtType.Text = "";
                    txtCategories.Text = "";
                    MessageBox.Show("Đã thêm mới mẫu SSD thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dwgSSD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dwgSSD.Rows[e.RowIndex];
            txtbrand.Text = Convert.ToString(row.Cells["Brand"].Value);
            txtmodel.Text = Convert.ToString(row.Cells["Model"].Value);
            txtinterface.Text = Convert.ToString(row.Cells["Interface"].Value);
            txtformfactor.Text = Convert.ToString(row.Cells["SSDFormFactor"].Value);
            txtcontroller.Text = Convert.ToString(row.Cells["Controller"].Value);
            txtDRAM.Text = Convert.ToString(row.Cells["DRAM"].Value);
            txtNANDBrand.Text = Convert.ToString(row.Cells["NANDBrand"].Value);
            txtType.Text = Convert.ToString(row.Cells["NANDType"].Value);
            txtCategories.Text = Convert.ToString(row.Cells["Categories"].Value);
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            if (txtmodel.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin mã SSD cần sửa lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmodel.Focus();
            }
            else if (KTThongTin())
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "change_SSD";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@BRAND", SqlDbType.Int).Value =txtbrand.Text;
                    cmd.Parameters.Add("@MODEL", SqlDbType.NVarChar).Value = txtmodel.Text;
                    cmd.Parameters.Add("@INTERFACE", SqlDbType.NVarChar).Value = txtinterface.Text;

                    cmd.Parameters.Add("@SSDFORMFACTOR", SqlDbType.Int).Value = txtformfactor.Text;
                    cmd.Parameters.Add("@CONTROLLER", SqlDbType.NVarChar).Value = txtcontroller.Text;
                    cmd.Parameters.Add("@DRAM", SqlDbType.NVarChar).Value = txtDRAM.Text;

                    cmd.Parameters.Add("@NANDBRAND", SqlDbType.Int).Value = txtNANDBrand.Text;
                    cmd.Parameters.Add("@NANDTYPE", SqlDbType.NVarChar).Value = txtType.Text;
                    cmd.Parameters.Add("@CATEGORIES", SqlDbType.NVarChar).Value =   txtCategories.Text;


                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dwgSSD.DataSource = cls.LoadDataLaptop();
                    txtbrand.Text = "";
                    txtmodel.Text = "";
                    txtinterface.Text = "";
                    txtformfactor.Text = "";
                    txtcontroller.Text = "";
                    txtDRAM.Text = "";
                    txtNANDBrand.Text = "";
                    txtType.Text = "";
                    txtCategories.Text = "";
                    MessageBox.Show("Đã sửa thông tin SSD thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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

                    cmd.CommandText = "DELETE_SSD";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MODEL", SqlDbType.NVarChar).Value = txtmodel.Text;

                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dwgSSD.DataSource = cls.LoadDataSSD();
                    txtbrand.Text = "";
                    txtmodel.Text = "";
                    txtinterface.Text = "";
                    txtformfactor.Text = "";
                    txtcontroller.Text = "";
                    txtDRAM.Text = "";
                    txtNANDBrand.Text = "";
                    txtType.Text = "";
                    txtCategories.Text = "";
                    MessageBox.Show("Đã xóa mẫu SSD thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UpdateSSDAD_Load(object sender, EventArgs e)
        {
            dwgSSD.DataSource = cls.LoadDataSSD();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            selectForm SE = new selectForm();
            SE.Show();
            this.Hide();
        }
    }
}

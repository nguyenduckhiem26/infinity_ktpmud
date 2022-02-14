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

namespace systeminfo
{
    public partial class SSDUpdate : Form
    {
        
        
        

      
        public SSDUpdate()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        CLSconnect cls = new CLSconnect();

        private void btluh_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            mainForm F = new mainForm();
            F.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = HardwareInfo.GetHDDSerialNo();
        }

        private void searchbox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void SSDUpdate_Load(object sender, EventArgs e)
        {
            dgwSSD.DataSource = cls.LoadDataSSD();
        }

        private void SSDUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm F1 = new mainForm();
            F1.Show();
        }
        DataTable dt;
        private void SSDtimkiem_Click(object sender, EventArgs e)
        {
            if(searchbox.Text.Trim()=="")
                {
                MessageBox.Show("vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }   
            else
            {
                dt = new DataTable();
                dt = cls.Timkiemssd(searchbox.Text.Trim());
                if(dt.Rows.Count > 0)
                {
                    dgwSSD.DataSource = dt;
                }
                else
                {
                    MessageBox.Show(searchbox.Text + "không có trong dữ liệu","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SSDUpdate_Load(null, null);
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

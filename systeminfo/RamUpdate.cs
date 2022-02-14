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
    
    public partial class RamUpdate : Form
    {
        public RamUpdate()
        {
            InitializeComponent();
            MaximizeBox = false;
        }
        CLSconnect cls = new CLSconnect();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm F = new mainForm();
            F.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = HardwareInfo.GetPhysicalMemoryinfor() + HardwareInfo.GetPhysicalMemory() + "GB";
        }

        private void RamUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm F1 = new mainForm();
            F1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void RamUpdate_Load(object sender, EventArgs e)
        {
            dgwRAM.DataSource = cls.LoadDataram();
        }
        DataTable dt;
        private void RAMtimkiem_Click(object sender, EventArgs e)
        {
            if (searchbox.Text.Trim() == "")
            {
                MessageBox.Show("vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                dt = new DataTable();
                dt = cls.timKiemRam(searchbox.Text.Trim());
                if (dt.Rows.Count > 0)
                {
                    dgwRAM.DataSource = dt;
                }
                else
                {
                    MessageBox.Show(searchbox.Text + "không có trong dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    RamUpdate_Load(null, null);
                }
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            selectForm SE = new selectForm();
            SE.Show();
            this.Hide();
        }
    }
}

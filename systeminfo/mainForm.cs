using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace systeminfo
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            MaximizeBox = false;
        }
        //private const int WM_SYSCOMMAND = 274; private const int SC_MAXIMIZE = 61488;

        //[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]

        //public static extern int SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        //[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        //public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);       
        private  void btnGetsystemInfo_Click(object sender, EventArgs e)
        {
            labelCPU.Text = HardwareInfo.GetProcessorId();

            label2.Text = HardwareInfo.GetHDDSerialNo();
            label3.Text = HardwareInfo.GetPhysicalMemoryinfor() + HardwareInfo.GetPhysicalMemory() + "GB" ;
        }

     

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SSDUpdate s = new SSDUpdate();
            s.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("bạn có muốn thoát chương trình?","Thông báo",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Application.Exit();
                Dispose();
            }    
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/LaptopUpdateHelper");
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btnRam_Click(object sender, EventArgs e)
        {
            RamUpdate r = new RamUpdate();
            
            
            this.Visible = false;
            r.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/groups/hoididapluon");
            this.WindowState = FormWindowState.Minimized;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Process.Start("C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Administrative Tools\\System Information");
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FistForm SE = new FistForm();
            SE.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace systeminfo
{
    public partial class selectForm : Form
    {
        public selectForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateAdmin ad = new UpdateAdmin();
            ad.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateRAMMAD UPR = new UpdateRAMMAD();
            UPR.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateLAPAD LAPAD = new UpdateLAPAD();
            LAPAD.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateSSDAD SSDAD = new UpdateSSDAD();
            SSDAD.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoginForm SE = new LoginForm();
            SE.Show();
            this.Hide();
        }
    }
}

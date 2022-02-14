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
    public partial class LoginForm : Form
    {
        public static string UserName = "";
        public LoginForm()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                password.PasswordChar = (char)0;
            }
            else
            {
                password.PasswordChar = '*';
            }
        }

        private void signin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "login";
                cmd.Parameters.AddWithValue("@UserName", username.Text);
                cmd.Parameters.AddWithValue("@Password", password.Text);
                cmd.Connection = conn;
                UserName = username.Text;
                object kq = cmd.ExecuteScalar();
                int code = Convert.ToInt32(kq);
                
                if (code == 1)
                {
                    MessageBox.Show("Chào mừng Admin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    selectForm F1 = new selectForm();
                    F1.Show();
                    this.Hide();

                }
                else if (code == 2)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    password.Text = "";
                    username.Text = "";
                    username.Focus();
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    password.Text = "";
                    username.Text = "";
                    username.Focus();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();

        }

        private void username_MouseClick(object sender, MouseEventArgs e)
        {
            username.SelectAll();
        }

        private void password_MouseClick(object sender, MouseEventArgs e)
        {
            password.SelectAll();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FistForm SE = new FistForm();
            SE.Show();
            this.Hide();
        }
    }
}

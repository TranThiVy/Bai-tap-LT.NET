using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9th100
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            btnLogin.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string username = txtTendn.Text;

            // Kiểm tra nếu tên đăng nhập có khoảng trắng
            if (username.Contains(" "))
            {
                MessageBox.Show("Tên đăng nhập không được chứa khoảng trắng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTendn.Text = username.Replace(" ", "");  // Loại bỏ khoảng trắng
            }

            // Bật nút Đăng nhập nếu có nội dung
            if (!string.IsNullOrWhiteSpace(username))
            {
                btnLogin.Enabled = true;  // Bật nút Đăng nhập
            }
            else
            {
                btnLogin.Enabled = false;  // Vô hiệu hóa nút Đăng nhập khi TextBox trống
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';  // Hiển thị mật khẩu
            }
            else
            {
                txtPassword.PasswordChar = '*';  // Ẩn mật khẩu
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtTendn.Text;
            string password = txtPassword.Text;

            // Kiểm tra tên đăng nhập và mật khẩu
            if (username == "admin" && password == "12345")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

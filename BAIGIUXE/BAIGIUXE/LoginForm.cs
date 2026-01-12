using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BAIGIUXE
{
    public partial class LoginForm : Form
    {
        string chuoiKetNoi = @"Data Source=CAMNU;Initial Catalog=QuanLyGiuXe;Integrated Security=True";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(chuoiKetNoi);
                conn.Open();
                string sql = "SELECT QuyenHan FROM TaiKhoan WHERE TenDangNhap = @User AND MatKhau = @Pass";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@User", txtUser.Text);
                cmd.Parameters.AddWithValue("@Pass", txtPass.Text);
                object ketQua = cmd.ExecuteScalar();

                conn.Close();

                if (ketQua == null)
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                }
                else
                {
                    string quyen = ketQua.ToString();
                    MessageBox.Show("Đăng nhập thành công! Quyền: " + quyen);

                    this.Hide();

                    if (quyen == "Admin")
                    {
                        AdminForm f = new AdminForm();
                        f.ShowDialog();
                    }
                    else
                    {
                        Form1 f = new Form1();
                        f.ShowDialog();
                    }
                    this.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }
    }
}
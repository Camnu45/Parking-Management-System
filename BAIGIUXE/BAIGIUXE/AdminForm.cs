using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BAIGIUXE
{
    public partial class AdminForm : Form
    {
        string chuoiKetNoi = @"Data Source=CAMNU;Initial Catalog=QuanLyGiuXe;Integrated Security=True";
        SqlConnection conn = null;

        public AdminForm()
        {
            InitializeComponent();
            conn = new SqlConnection(chuoiKetNoi);
            this.Load += AdminForm_Load;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Value = DateTime.Today;
            dtpDenNgay.Value = DateTime.Now;  
            cboQuyen.Items.Clear();
            cboQuyen.Items.Add("Admin");
            cboQuyen.Items.Add("NhanVien");
            cboQuyen.SelectedIndex = 1; 

            LoadDanhSachNhanVien(); 

            btnThongKe.Click += BtnThongKe_Click;
            btnThemNV.Click += BtnThemNV_Click;
            btnSuaNV.Click += BtnSuaNV_Click;
            btnXoaNV.Click += BtnXoaNV_Click;
            dgvNhanVien.CellClick += DgvNhanVien_CellClick;
        }

        private void BtnThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string sql = "SELECT * FROM LuotGui WHERE TrangThai = 'DaTra' AND ThoiGianRa BETWEEN @Tu AND @Den";
                SqlCommand cmd = new SqlCommand(sql, conn);

                DateTime tuNgay = dtpTuNgay.Value.Date;
                DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddSeconds(-1);

                cmd.Parameters.AddWithValue("@Tu", tuNgay);
                cmd.Parameters.AddWithValue("@Den", denNgay);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();

                long countXeMay = 0;
                long countOto = 0;
                decimal tienXeMay = 0;
                decimal tienOto = 0;

                foreach (DataRow row in dt.Rows)
                {
                    string loai = row["LoaiXe"].ToString();
                    decimal tien = decimal.Parse(row["GiaTien"].ToString());

                    if (loai == "XeMay")
                    {
                        countXeMay++;
                        tienXeMay += tien;
                    }
                    else if (loai == "OTo")
                    {
                        countOto++;
                        tienOto += tien;
                    }
                }

                lblSoLuotXeMay.Text = $"{countXeMay} lượt";
                lblDoanhThuXeMay.Text = $"{tienXeMay:N0} VNĐ";

                lblSoLuotOto.Text = $"{countOto} lượt";
                lblDoanhThuOto.Text = $"{tienOto:N0} VNĐ";

                decimal tongCong = tienXeMay + tienOto;
                lblTongTien.Text = $"TỔNG DOANH THU: {tongCong:N0} VNĐ";
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Lỗi thống kê: " + ex.Message);
            }
        }

        private void LoadDanhSachNhanVien()
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TenDangNhap, MatKhau, QuyenHan FROM TaiKhoan", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvNhanVien.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải danh sách: " + ex.Message); }
        }

        private void BtnThemNV_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPass.Text == "") { MessageBox.Show("Vui lòng nhập đủ thông tin!"); return; }
            if (KiemTraTrung(txtUser.Text)) { MessageBox.Show("Tên đăng nhập này đã có rồi!"); return; }

            string sql = "INSERT INTO TaiKhoan (TenDangNhap, MatKhau, QuyenHan) VALUES (@User, @Pass, @Quyen)";
            ChayLenhSQL(sql, "Thêm nhân viên thành công!");
        }

        private void BtnSuaNV_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "") { MessageBox.Show("Chọn nhân viên cần sửa!"); return; }

            string sql = "UPDATE TaiKhoan SET MatKhau = @Pass, QuyenHan = @Quyen WHERE TenDangNhap = @User";
            ChayLenhSQL(sql, "Cập nhật thành công!");
        }

        private void BtnXoaNV_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "") { MessageBox.Show("Chọn nhân viên cần xóa!"); return; }
            if (txtUser.Text.ToLower() == "admin") { MessageBox.Show("Không thể xóa tài khoản Admin gốc!"); return; }

            if (MessageBox.Show("Bạn chắc chắn muốn xóa tài khoản: " + txtUser.Text + "?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string sql = "DELETE FROM TaiKhoan WHERE TenDangNhap = @User";
                ChayLenhSQL(sql, "Đã xóa nhân viên!");
            }
        }

        private void DgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                txtUser.Text = row.Cells["TenDangNhap"].Value.ToString();
                txtPass.Text = row.Cells["MatKhau"].Value.ToString();
                cboQuyen.Text = row.Cells["QuyenHan"].Value.ToString();
                txtUser.ReadOnly = true;
            }
        }

        private void ChayLenhSQL(string sql, string thongBao)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@User", txtUser.Text);
                cmd.Parameters.AddWithValue("@Pass", txtPass.Text);
                cmd.Parameters.AddWithValue("@Quyen", cboQuyen.Text);

                cmd.ExecuteNonQuery();
                conn.Close();

                LoadDanhSachNhanVien();
                MessageBox.Show(thongBao);

                txtUser.Text = ""; txtUser.ReadOnly = false;
                txtPass.Text = "";
                cboQuyen.SelectedIndex = 1;
            }
            catch (Exception ex) { conn.Close(); MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private bool KiemTraTrung(string user)
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @User", conn);
            cmd.Parameters.AddWithValue("@User", user);
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            return count > 0;
        }
    }
}
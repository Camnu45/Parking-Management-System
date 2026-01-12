using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BAIGIUXE
{
    public partial class Form1 : Form
    {
        string chuoiKetNoi = @"Data Source=CAMNU;Initial Catalog=QuanLyGiuXe;Integrated Security=True";
        SqlConnection conn = null;
        string duongDanAnhTam = "";

        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection(chuoiKetNoi);
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TaiDanhSachXe();
            btnChonAnh.Click += BtnChonAnh_Click;
            btnXeVao.Click += BtnXeVao_Click;
            btnXeRa.Click += BtnXeRa_Click;
            dgvXe.CellClick += DgvXe_CellClick;
        }

        private decimal TinhTienGui(DateTime vao, DateTime ra, string loaiXe)
        {
            bool quaDem = (vao.Hour < 22 && ra.Date > vao.Date);
            double soGio = (ra - vao).TotalHours;

            if (loaiXe == "OTo")
            {
                if (quaDem) return 100000;     
                if (soGio < 2) return 30000;   
                return 50000;     
            }
            else
            {
                if (quaDem) return 50000;  
                if (soGio < 2) return 5000; 
                return 10000;
            }
        }

        private void TaiDanhSachXe()
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LuotGui WHERE TrangThai = 'DangGui' ORDER BY ThoiGianVao DESC", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvXe.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void BtnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Ảnh xe|*.jpg;*.jpeg;*.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picXe.Image = Image.FromFile(open.FileName);
                duongDanAnhTam = open.FileName;
            }
        }

        private void BtnXeVao_Click(object sender, EventArgs e)
        {
            if (txtBienSo.Text == "") { MessageBox.Show("Chưa nhập biển số!"); return; }
            if (duongDanAnhTam == "") { MessageBox.Show("Chưa có ảnh!"); return; }

            try
            {
                string loaiXe = rdoOTo.Checked ? "OTo" : "XeMay";
                string folderLuu = Path.Combine(Application.StartupPath, "AnhLuuTru");
                if (!Directory.Exists(folderLuu)) Directory.CreateDirectory(folderLuu);
                string tenFileMoi = DateTime.Now.Ticks.ToString() + Path.GetExtension(duongDanAnhTam);
                string duongDanCuoiCung = Path.Combine(folderLuu, tenFileMoi);
                File.Copy(duongDanAnhTam, duongDanCuoiCung);

                if (conn.State == ConnectionState.Closed) conn.Open();
                string sql = "INSERT INTO LuotGui (BienSo, LoaiXe, ThoiGianVao, HinhAnh, TrangThai) VALUES (@BienSo, @Loai, GETDATE(), @Hinh, 'DangGui')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@BienSo", txtBienSo.Text);
                cmd.Parameters.AddWithValue("@Loai", loaiXe);
                cmd.Parameters.AddWithValue("@Hinh", duongDanCuoiCung);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show($"Đã nhận {loaiXe}: {txtBienSo.Text}");
                TaiDanhSachXe();

                txtBienSo.Text = "";
                picXe.Image = null;
                duongDanAnhTam = "";
                rdoXeMay.Checked = true;
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void BtnXeRa_Click(object sender, EventArgs e)
        {
            if (txtBienSo.Text == "") { MessageBox.Show("Nhập biển số!"); return; }

            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string sqlTim = "SELECT * FROM LuotGui WHERE BienSo = @BienSo AND TrangThai = 'DangGui'";
                SqlCommand cmdTim = new SqlCommand(sqlTim, conn);
                cmdTim.Parameters.AddWithValue("@BienSo", txtBienSo.Text);

                DataTable dt = new DataTable();
                new SqlDataAdapter(cmdTim).Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    string duongDanAnh = dt.Rows[0]["HinhAnh"].ToString();
                    int maLuot = int.Parse(dt.Rows[0]["MaLuot"].ToString());
                    DateTime gioVao = DateTime.Parse(dt.Rows[0]["ThoiGianVao"].ToString());
                    string loaiXe = dt.Rows[0]["LoaiXe"].ToString();
                    DateTime gioRa = DateTime.Now;

                    decimal tienThu = TinhTienGui(gioVao, gioRa, loaiXe);
                    if (File.Exists(duongDanAnh)) picXe.Image = Image.FromFile(duongDanAnh);

                    string thongBao = $"Tìm thấy {loaiXe}!\n" +
                                      $"- Vào: {gioVao:HH:mm}\n- Ra: {gioRa:HH:mm}\n" +
                                      $"- TIỀN PHẢI THU: {tienThu:N0} VNĐ\n\n" +
                                      $"Xác nhận thu tiền?";

                    if (MessageBox.Show(thongBao, "Thanh Toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string sqlUpdate = "UPDATE LuotGui SET ThoiGianRa = GETDATE(), TrangThai = 'DaTra', GiaTien = @Tien WHERE MaLuot = @ID";
                        SqlCommand cmdUp = new SqlCommand(sqlUpdate, conn);
                        cmdUp.Parameters.AddWithValue("@Tien", tienThu);
                        cmdUp.Parameters.AddWithValue("@ID", maLuot);
                        cmdUp.ExecuteNonQuery();

                        MessageBox.Show("Đã thu tiền xong!");
                        TaiDanhSachXe();
                        txtBienSo.Text = "";
                        picXe.Image = null;
                    }
                }
                else
                {
                    MessageBox.Show("Không thấy xe này!");
                    picXe.Image = null;
                }
                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void DgvXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) txtBienSo.Text = dgvXe.Rows[e.RowIndex].Cells["BienSo"].Value.ToString();
        }
    }
}
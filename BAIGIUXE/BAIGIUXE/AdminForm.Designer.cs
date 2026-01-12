namespace BAIGIUXE
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSoLuotXeMay = new System.Windows.Forms.Label();
            this.lblDoanhThuXeMay = new System.Windows.Forms.Label();
            this.lblDoanhThuOto = new System.Windows.Forms.Label();
            this.lblSoLuotOto = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.cboQuyen = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1500, 805);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnThongKe);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dtpDenNgay);
            this.tabPage1.Controls.Add(this.dtpTuNgay);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage1.Size = new System.Drawing.Size(1492, 763);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thống Kê Doanh Thu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.dgvNhanVien);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage2.Size = new System.Drawing.Size(1492, 763);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản Lý Nhân Viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Location = new System.Drawing.Point(198, 40);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(450, 36);
            this.dtpTuNgay.TabIndex = 0;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Location = new System.Drawing.Point(870, 40);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(434, 36);
            this.dtpDenNgay.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ Ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(695, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến Ngày";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(1330, 28);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(131, 65);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "GO";
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTongTien);
            this.groupBox1.Controls.Add(this.lblSoLuotOto);
            this.groupBox1.Controls.Add(this.lblDoanhThuOto);
            this.groupBox1.Controls.Add(this.lblDoanhThuXeMay);
            this.groupBox1.Controls.Add(this.lblSoLuotXeMay);
            this.groupBox1.Location = new System.Drawing.Point(25, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1458, 455);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tổng Kết";
            // 
            // lblSoLuotXeMay
            // 
            this.lblSoLuotXeMay.AutoSize = true;
            this.lblSoLuotXeMay.Location = new System.Drawing.Point(371, 88);
            this.lblSoLuotXeMay.Name = "lblSoLuotXeMay";
            this.lblSoLuotXeMay.Size = new System.Drawing.Size(0, 29);
            this.lblSoLuotXeMay.TabIndex = 0;
            // 
            // lblDoanhThuXeMay
            // 
            this.lblDoanhThuXeMay.AutoSize = true;
            this.lblDoanhThuXeMay.Location = new System.Drawing.Point(888, 88);
            this.lblDoanhThuXeMay.Name = "lblDoanhThuXeMay";
            this.lblDoanhThuXeMay.Size = new System.Drawing.Size(180, 29);
            this.lblDoanhThuXeMay.TabIndex = 1;
            this.lblDoanhThuXeMay.Text = "💰 Doanh Thu:";
            // 
            // lblDoanhThuOto
            // 
            this.lblDoanhThuOto.AutoSize = true;
            this.lblDoanhThuOto.Location = new System.Drawing.Point(888, 246);
            this.lblDoanhThuOto.Name = "lblDoanhThuOto";
            this.lblDoanhThuOto.Size = new System.Drawing.Size(180, 29);
            this.lblDoanhThuOto.TabIndex = 2;
            this.lblDoanhThuOto.Text = "💰 Doanh Thu:";
            // 
            // lblSoLuotOto
            // 
            this.lblSoLuotOto.AutoSize = true;
            this.lblSoLuotOto.Location = new System.Drawing.Point(371, 246);
            this.lblSoLuotOto.Name = "lblSoLuotOto";
            this.lblSoLuotOto.Size = new System.Drawing.Size(0, 29);
            this.lblSoLuotOto.TabIndex = 3;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(513, 345);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(282, 29);
            this.lblTongTien.TabIndex = 4;
            this.lblTongTien.Text = "🏆 TỔNG DOANH THU:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Danh sách tài khoản";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(856, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 801);
            this.panel1.TabIndex = 1;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(38, 77);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(784, 678);
            this.dgvNhanVien.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSuaNV);
            this.groupBox2.Controls.Add(this.btnXoaNV);
            this.groupBox2.Controls.Add(this.btnThemNV);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cboQuyen);
            this.groupBox2.Controls.Add(this.txtPass);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtUser);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(927, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(521, 704);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tài khoản";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên đăng nhập :";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(47, 106);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(453, 36);
            this.txtUser.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = "Mật khẩu";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(47, 215);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(453, 36);
            this.txtPass.TabIndex = 3;
            // 
            // cboQuyen
            // 
            this.cboQuyen.FormattingEnabled = true;
            this.cboQuyen.Items.AddRange(new object[] {
            "Admin",
            "Nhân VIên"});
            this.cboQuyen.Location = new System.Drawing.Point(47, 351);
            this.cboQuyen.Name = "cboQuyen";
            this.cboQuyen.Size = new System.Drawing.Size(453, 37);
            this.cboQuyen.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 29);
            this.label9.TabIndex = 5;
            this.label9.Text = "Chức vụ :";
            // 
            // btnThemNV
            // 
            this.btnThemNV.Location = new System.Drawing.Point(47, 462);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(137, 56);
            this.btnThemNV.TabIndex = 6;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = true;
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Location = new System.Drawing.Point(203, 580);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(137, 56);
            this.btnXoaNV.TabIndex = 7;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.UseVisualStyleBackColor = true;
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.Location = new System.Drawing.Point(363, 462);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(137, 56);
            this.btnSuaNV.TabIndex = 8;
            this.btnSuaNV.Text = "Sửa";
            this.btnSuaNV.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "🛑 Xe Máy:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "🚗 Ô Tô:";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 805);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblSoLuotOto;
        private System.Windows.Forms.Label lblDoanhThuOto;
        private System.Windows.Forms.Label lblDoanhThuXeMay;
        private System.Windows.Forms.Label lblSoLuotXeMay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboQuyen;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
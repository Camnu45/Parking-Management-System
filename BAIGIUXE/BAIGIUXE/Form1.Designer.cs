namespace BAIGIUXE
{
    partial class Form1
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
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.picXe = new System.Windows.Forms.PictureBox();
            this.btnXeVao = new System.Windows.Forms.Button();
            this.btnXeRa = new System.Windows.Forms.Button();
            this.dgvXe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoXeMay = new System.Windows.Forms.RadioButton();
            this.rdoOTo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBienSo
            // 
            this.txtBienSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBienSo.Location = new System.Drawing.Point(194, 135);
            this.txtBienSo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(284, 36);
            this.txtBienSo.TabIndex = 0;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonAnh.Location = new System.Drawing.Point(766, 303);
            this.btnChonAnh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(130, 54);
            this.btnChonAnh.TabIndex = 1;
            this.btnChonAnh.Text = "Chọn Ảnh Xe";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            // 
            // picXe
            // 
            this.picXe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picXe.Location = new System.Drawing.Point(672, 21);
            this.picXe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picXe.Name = "picXe";
            this.picXe.Size = new System.Drawing.Size(315, 267);
            this.picXe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picXe.TabIndex = 2;
            this.picXe.TabStop = false;
            // 
            // btnXeVao
            // 
            this.btnXeVao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXeVao.Location = new System.Drawing.Point(77, 259);
            this.btnXeVao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXeVao.Name = "btnXeVao";
            this.btnXeVao.Size = new System.Drawing.Size(130, 54);
            this.btnXeVao.TabIndex = 3;
            this.btnXeVao.Text = "Xe Vào";
            this.btnXeVao.UseVisualStyleBackColor = true;
            // 
            // btnXeRa
            // 
            this.btnXeRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXeRa.Location = new System.Drawing.Point(455, 259);
            this.btnXeRa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXeRa.Name = "btnXeRa";
            this.btnXeRa.Size = new System.Drawing.Size(130, 54);
            this.btnXeRa.TabIndex = 4;
            this.btnXeRa.Text = "Xe Ra";
            this.btnXeRa.UseVisualStyleBackColor = true;
            // 
            // dgvXe
            // 
            this.dgvXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXe.Location = new System.Drawing.Point(3, 377);
            this.dgvXe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvXe.Name = "dgvXe";
            this.dgvXe.RowHeadersWidth = 51;
            this.dgvXe.RowTemplate.Height = 24;
            this.dgvXe.Size = new System.Drawing.Size(994, 188);
            this.dgvXe.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "BIỂN SỐ XE";
            // 
            // rdoXeMay
            // 
            this.rdoXeMay.AutoSize = true;
            this.rdoXeMay.Location = new System.Drawing.Point(194, 200);
            this.rdoXeMay.Name = "rdoXeMay";
            this.rdoXeMay.Size = new System.Drawing.Size(86, 24);
            this.rdoXeMay.TabIndex = 7;
            this.rdoXeMay.TabStop = true;
            this.rdoXeMay.Text = "Xe Máy";
            this.rdoXeMay.UseVisualStyleBackColor = true;
            // 
            // rdoOTo
            // 
            this.rdoOTo.AutoSize = true;
            this.rdoOTo.Location = new System.Drawing.Point(411, 200);
            this.rdoOTo.Name = "rdoOTo";
            this.rdoOTo.Size = new System.Drawing.Size(67, 24);
            this.rdoOTo.TabIndex = 8;
            this.rdoOTo.TabStop = true;
            this.rdoOTo.Text = "Ô Tô";
            this.rdoOTo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 563);
            this.Controls.Add(this.rdoOTo);
            this.Controls.Add(this.rdoXeMay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvXe);
            this.Controls.Add(this.btnXeRa);
            this.Controls.Add(this.btnXeVao);
            this.Controls.Add(this.picXe);
            this.Controls.Add(this.btnChonAnh);
            this.Controls.Add(this.txtBienSo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaiGiuXe";
            ((System.ComponentModel.ISupportInitialize)(this.picXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBienSo;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.PictureBox picXe;
        private System.Windows.Forms.Button btnXeVao;
        private System.Windows.Forms.Button btnXeRa;
        private System.Windows.Forms.DataGridView dgvXe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoXeMay;
        private System.Windows.Forms.RadioButton rdoOTo;
    }
}


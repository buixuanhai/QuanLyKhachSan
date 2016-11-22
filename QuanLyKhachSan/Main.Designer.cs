namespace QuanLyKhachSan
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
            this.danhMucPhongButton = new System.Windows.Forms.Button();
            this.btnPhieuThuePhong = new System.Windows.Forms.Button();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.btnHoaDonThanhToan = new System.Windows.Forms.Button();
            this.btnLapBaoCaoThang = new System.Windows.Forms.Button();
            this.btnThayDoiQuyDinh = new System.Windows.Forms.Button();
            this.danhSachPhongButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // danhMucPhongButton
            // 
            this.danhMucPhongButton.Location = new System.Drawing.Point(49, 45);
            this.danhMucPhongButton.Name = "danhMucPhongButton";
            this.danhMucPhongButton.Size = new System.Drawing.Size(144, 23);
            this.danhMucPhongButton.TabIndex = 0;
            this.danhMucPhongButton.Text = "Loại phòng";
            this.danhMucPhongButton.UseVisualStyleBackColor = true;
            this.danhMucPhongButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPhieuThuePhong
            // 
            this.btnPhieuThuePhong.Location = new System.Drawing.Point(49, 86);
            this.btnPhieuThuePhong.Name = "btnPhieuThuePhong";
            this.btnPhieuThuePhong.Size = new System.Drawing.Size(144, 23);
            this.btnPhieuThuePhong.TabIndex = 1;
            this.btnPhieuThuePhong.Text = "Phiếu Thuê Phòng";
            this.btnPhieuThuePhong.UseVisualStyleBackColor = true;
            this.btnPhieuThuePhong.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(49, 197);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(144, 23);
            this.btnTraCuu.TabIndex = 2;
            this.btnTraCuu.Text = "Tra Cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            // 
            // btnHoaDonThanhToan
            // 
            this.btnHoaDonThanhToan.Location = new System.Drawing.Point(49, 127);
            this.btnHoaDonThanhToan.Name = "btnHoaDonThanhToan";
            this.btnHoaDonThanhToan.Size = new System.Drawing.Size(144, 23);
            this.btnHoaDonThanhToan.TabIndex = 3;
            this.btnHoaDonThanhToan.Text = "Hóa Đơn Thanh Toán";
            this.btnHoaDonThanhToan.UseVisualStyleBackColor = true;
            this.btnHoaDonThanhToan.Click += new System.EventHandler(this.btnLapHoaDon_Click);
            // 
            // btnLapBaoCaoThang
            // 
            this.btnLapBaoCaoThang.Location = new System.Drawing.Point(49, 168);
            this.btnLapBaoCaoThang.Name = "btnLapBaoCaoThang";
            this.btnLapBaoCaoThang.Size = new System.Drawing.Size(144, 23);
            this.btnLapBaoCaoThang.TabIndex = 4;
            this.btnLapBaoCaoThang.Text = "Lập Báo Cáo Tháng";
            this.btnLapBaoCaoThang.UseVisualStyleBackColor = true;
            // 
            // btnThayDoiQuyDinh
            // 
            this.btnThayDoiQuyDinh.Location = new System.Drawing.Point(49, 226);
            this.btnThayDoiQuyDinh.Name = "btnThayDoiQuyDinh";
            this.btnThayDoiQuyDinh.Size = new System.Drawing.Size(144, 23);
            this.btnThayDoiQuyDinh.TabIndex = 5;
            this.btnThayDoiQuyDinh.Text = "Thay Đổi Quy Định";
            this.btnThayDoiQuyDinh.UseVisualStyleBackColor = true;
            // 
            // danhSachPhongButton
            // 
            this.danhSachPhongButton.Location = new System.Drawing.Point(49, 13);
            this.danhSachPhongButton.Name = "danhSachPhongButton";
            this.danhSachPhongButton.Size = new System.Drawing.Size(144, 23);
            this.danhSachPhongButton.TabIndex = 6;
            this.danhSachPhongButton.Text = "Danh sách phòng";
            this.danhSachPhongButton.UseVisualStyleBackColor = true;
            this.danhSachPhongButton.Click += new System.EventHandler(this.danhSachPhongButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 261);
            this.Controls.Add(this.danhSachPhongButton);
            this.Controls.Add(this.btnThayDoiQuyDinh);
            this.Controls.Add(this.btnLapBaoCaoThang);
            this.Controls.Add(this.btnHoaDonThanhToan);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.btnPhieuThuePhong);
            this.Controls.Add(this.danhMucPhongButton);
            this.Name = "Form1";
            this.Text = "Quản Lý Khách Sạn";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button danhMucPhongButton;
        private System.Windows.Forms.Button btnPhieuThuePhong;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Button btnHoaDonThanhToan;
        private System.Windows.Forms.Button btnLapBaoCaoThang;
        private System.Windows.Forms.Button btnThayDoiQuyDinh;
        private System.Windows.Forms.Button danhSachPhongButton;
    }
}


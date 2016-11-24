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
            this.loaiPhongButton = new System.Windows.Forms.Button();
            this.phieuThuePhongButton = new System.Windows.Forms.Button();
            this.traCuuButton = new System.Windows.Forms.Button();
            this.hoaDonThanhToanButton = new System.Windows.Forms.Button();
            this.baoCaoDoanhThuButton = new System.Windows.Forms.Button();
            this.thayDoiQuyDinhButton = new System.Windows.Forms.Button();
            this.danhSachPhongButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loaiPhongButton
            // 
            this.loaiPhongButton.Location = new System.Drawing.Point(49, 57);
            this.loaiPhongButton.Name = "loaiPhongButton";
            this.loaiPhongButton.Size = new System.Drawing.Size(144, 23);
            this.loaiPhongButton.TabIndex = 0;
            this.loaiPhongButton.Text = "Loại phòng";
            this.loaiPhongButton.UseVisualStyleBackColor = true;
            this.loaiPhongButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // phieuThuePhongButton
            // 
            this.phieuThuePhongButton.Location = new System.Drawing.Point(49, 98);
            this.phieuThuePhongButton.Name = "phieuThuePhongButton";
            this.phieuThuePhongButton.Size = new System.Drawing.Size(144, 23);
            this.phieuThuePhongButton.TabIndex = 1;
            this.phieuThuePhongButton.Text = "Phiếu Thuê Phòng";
            this.phieuThuePhongButton.UseVisualStyleBackColor = true;
            this.phieuThuePhongButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // traCuuButton
            // 
            this.traCuuButton.Location = new System.Drawing.Point(49, 216);
            this.traCuuButton.Name = "traCuuButton";
            this.traCuuButton.Size = new System.Drawing.Size(144, 23);
            this.traCuuButton.TabIndex = 2;
            this.traCuuButton.Text = "Tra Cứu";
            this.traCuuButton.UseVisualStyleBackColor = true;
            this.traCuuButton.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // hoaDonThanhToanButton
            // 
            this.hoaDonThanhToanButton.Location = new System.Drawing.Point(49, 139);
            this.hoaDonThanhToanButton.Name = "hoaDonThanhToanButton";
            this.hoaDonThanhToanButton.Size = new System.Drawing.Size(144, 23);
            this.hoaDonThanhToanButton.TabIndex = 3;
            this.hoaDonThanhToanButton.Text = "Hóa Đơn Thanh Toán";
            this.hoaDonThanhToanButton.UseVisualStyleBackColor = true;
            this.hoaDonThanhToanButton.Click += new System.EventHandler(this.btnLapHoaDon_Click);
            // 
            // baoCaoDoanhThuButton
            // 
            this.baoCaoDoanhThuButton.Location = new System.Drawing.Point(49, 178);
            this.baoCaoDoanhThuButton.Name = "baoCaoDoanhThuButton";
            this.baoCaoDoanhThuButton.Size = new System.Drawing.Size(144, 23);
            this.baoCaoDoanhThuButton.TabIndex = 4;
            this.baoCaoDoanhThuButton.Text = "Báo Cáo Doanh Thu";
            this.baoCaoDoanhThuButton.UseVisualStyleBackColor = true;
            this.baoCaoDoanhThuButton.Click += new System.EventHandler(this.btnLapBaoCaoThang_Click);
            // 
            // thayDoiQuyDinhButton
            // 
            this.thayDoiQuyDinhButton.Location = new System.Drawing.Point(49, 255);
            this.thayDoiQuyDinhButton.Name = "thayDoiQuyDinhButton";
            this.thayDoiQuyDinhButton.Size = new System.Drawing.Size(144, 23);
            this.thayDoiQuyDinhButton.TabIndex = 5;
            this.thayDoiQuyDinhButton.Text = "Thay Đổi Quy Định";
            this.thayDoiQuyDinhButton.UseVisualStyleBackColor = true;
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
            this.ClientSize = new System.Drawing.Size(623, 307);
            this.Controls.Add(this.danhSachPhongButton);
            this.Controls.Add(this.thayDoiQuyDinhButton);
            this.Controls.Add(this.baoCaoDoanhThuButton);
            this.Controls.Add(this.hoaDonThanhToanButton);
            this.Controls.Add(this.traCuuButton);
            this.Controls.Add(this.phieuThuePhongButton);
            this.Controls.Add(this.loaiPhongButton);
            this.Name = "Form1";
            this.Text = "Quản Lý Khách Sạn";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loaiPhongButton;
        private System.Windows.Forms.Button phieuThuePhongButton;
        private System.Windows.Forms.Button traCuuButton;
        private System.Windows.Forms.Button hoaDonThanhToanButton;
        private System.Windows.Forms.Button baoCaoDoanhThuButton;
        private System.Windows.Forms.Button thayDoiQuyDinhButton;
        private System.Windows.Forms.Button danhSachPhongButton;
    }
}


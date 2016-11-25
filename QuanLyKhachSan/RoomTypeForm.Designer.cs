namespace QuanLyKhachSan
{
    partial class RoomTypeForm
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
            this.themButton = new System.Windows.Forms.Button();
            this.xoaButton = new System.Windows.Forms.Button();
            this.suaButton = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.Label();
            this.loaiPhongTextBox = new System.Windows.Forms.TextBox();
            this.donGianTextBox = new System.Windows.Forms.TextBox();
            this.txtPhong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ghiChuTextBox = new System.Windows.Forms.TextBox();
            this.luuButton = new System.Windows.Forms.Button();
            this.loaiPhongGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.loaiPhongGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // themButton
            // 
            this.themButton.Location = new System.Drawing.Point(130, 172);
            this.themButton.Name = "themButton";
            this.themButton.Size = new System.Drawing.Size(75, 23);
            this.themButton.TabIndex = 4;
            this.themButton.Text = "Thêm";
            this.themButton.UseVisualStyleBackColor = true;
            this.themButton.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // xoaButton
            // 
            this.xoaButton.Location = new System.Drawing.Point(597, 172);
            this.xoaButton.Name = "xoaButton";
            this.xoaButton.Size = new System.Drawing.Size(75, 23);
            this.xoaButton.TabIndex = 5;
            this.xoaButton.Text = "Xóa";
            this.xoaButton.UseVisualStyleBackColor = true;
            // 
            // suaButton
            // 
            this.suaButton.Location = new System.Drawing.Point(435, 172);
            this.suaButton.Name = "suaButton";
            this.suaButton.Size = new System.Drawing.Size(75, 23);
            this.suaButton.TabIndex = 6;
            this.suaButton.Text = "Sửa";
            this.suaButton.UseVisualStyleBackColor = true;
            this.suaButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.AutoSize = true;
            this.txtGhiChu.Location = new System.Drawing.Point(29, 105);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(45, 13);
            this.txtGhiChu.TabIndex = 9;
            this.txtGhiChu.Text = "Ghi Chú";
            this.txtGhiChu.Click += new System.EventHandler(this.label4_Click);
            // 
            // loaiPhongTextBox
            // 
            this.loaiPhongTextBox.Location = new System.Drawing.Point(130, 18);
            this.loaiPhongTextBox.Name = "loaiPhongTextBox";
            this.loaiPhongTextBox.Size = new System.Drawing.Size(201, 20);
            this.loaiPhongTextBox.TabIndex = 10;
            // 
            // donGianTextBox
            // 
            this.donGianTextBox.Location = new System.Drawing.Point(130, 44);
            this.donGianTextBox.Name = "donGianTextBox";
            this.donGianTextBox.Size = new System.Drawing.Size(201, 20);
            this.donGianTextBox.TabIndex = 11;
            // 
            // txtPhong
            // 
            this.txtPhong.AutoSize = true;
            this.txtPhong.Location = new System.Drawing.Point(28, 21);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(60, 13);
            this.txtPhong.TabIndex = 12;
            this.txtPhong.Text = "Loại phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Đơn giá";
            // 
            // ghiChuTextBox
            // 
            this.ghiChuTextBox.Location = new System.Drawing.Point(130, 71);
            this.ghiChuTextBox.Multiline = true;
            this.ghiChuTextBox.Name = "ghiChuTextBox";
            this.ghiChuTextBox.Size = new System.Drawing.Size(201, 95);
            this.ghiChuTextBox.TabIndex = 14;
            // 
            // luuButton
            // 
            this.luuButton.Location = new System.Drawing.Point(516, 172);
            this.luuButton.Name = "luuButton";
            this.luuButton.Size = new System.Drawing.Size(75, 23);
            this.luuButton.TabIndex = 15;
            this.luuButton.Text = "Lưu";
            this.luuButton.UseVisualStyleBackColor = true;
            // 
            // loaiPhongGridView
            // 
            this.loaiPhongGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loaiPhongGridView.Location = new System.Drawing.Point(362, 18);
            this.loaiPhongGridView.Name = "loaiPhongGridView";
            this.loaiPhongGridView.Size = new System.Drawing.Size(359, 148);
            this.loaiPhongGridView.TabIndex = 16;
            // 
            // LoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 217);
            this.Controls.Add(this.loaiPhongGridView);
            this.Controls.Add(this.luuButton);
            this.Controls.Add(this.ghiChuTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPhong);
            this.Controls.Add(this.donGianTextBox);
            this.Controls.Add(this.loaiPhongTextBox);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.suaButton);
            this.Controls.Add(this.xoaButton);
            this.Controls.Add(this.themButton);
            this.Name = "LoaiPhong";
            this.Text = "Loại phòng";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loaiPhongGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button themButton;
        private System.Windows.Forms.Button xoaButton;
        private System.Windows.Forms.Button suaButton;
        private System.Windows.Forms.Label txtGhiChu;
        private System.Windows.Forms.TextBox loaiPhongTextBox;
        private System.Windows.Forms.TextBox donGianTextBox;
        private System.Windows.Forms.Label txtPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ghiChuTextBox;
        private System.Windows.Forms.Button luuButton;
        private System.Windows.Forms.DataGridView loaiPhongGridView;
    }
}
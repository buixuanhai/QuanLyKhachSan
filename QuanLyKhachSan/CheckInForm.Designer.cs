namespace QuanLyKhachSan
{
    partial class CheckInForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CMNDTextBox = new System.Windows.Forms.TextBox();
            this.loaiKhachComboBox = new System.Windows.Forms.ComboBox();
            this.phieuThuePhongGridView = new System.Windows.Forms.DataGridView();
            this.themButton = new System.Windows.Forms.Button();
            this.xoaButton = new System.Windows.Forms.Button();
            this.suaButton = new System.Windows.Forms.Button();
            this.luuButton = new System.Windows.Forms.Button();
            this.khachHangTextBox = new System.Windows.Forms.TextBox();
            this.phongComboBox = new System.Windows.Forms.ComboBox();
            this.thanhToanButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.phieuThuePhongGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phòng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loại khách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CMND";
            // 
            // CMNDTextBox
            // 
            this.CMNDTextBox.Location = new System.Drawing.Point(101, 140);
            this.CMNDTextBox.Name = "CMNDTextBox";
            this.CMNDTextBox.Size = new System.Drawing.Size(198, 20);
            this.CMNDTextBox.TabIndex = 3;
            // 
            // loaiKhachComboBox
            // 
            this.loaiKhachComboBox.FormattingEnabled = true;
            this.loaiKhachComboBox.Items.AddRange(new object[] {
            "Nội địa",
            "Nước ngoài"});
            this.loaiKhachComboBox.Location = new System.Drawing.Point(101, 104);
            this.loaiKhachComboBox.Name = "loaiKhachComboBox";
            this.loaiKhachComboBox.Size = new System.Drawing.Size(198, 21);
            this.loaiKhachComboBox.TabIndex = 2;
            this.loaiKhachComboBox.SelectedIndexChanged += new System.EventHandler(this.loaiKhachcomboBox_SelectedIndexChanged);
            // 
            // phieuThuePhongGridView
            // 
            this.phieuThuePhongGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phieuThuePhongGridView.Location = new System.Drawing.Point(316, 27);
            this.phieuThuePhongGridView.Name = "phieuThuePhongGridView";
            this.phieuThuePhongGridView.Size = new System.Drawing.Size(598, 208);
            this.phieuThuePhongGridView.TabIndex = 5;
            // 
            // themButton
            // 
            this.themButton.Location = new System.Drawing.Point(101, 178);
            this.themButton.Name = "themButton";
            this.themButton.Size = new System.Drawing.Size(121, 23);
            this.themButton.TabIndex = 4;
            this.themButton.Text = "Thêm";
            this.themButton.UseVisualStyleBackColor = true;
            this.themButton.Click += new System.EventHandler(this.themButton_Click);
            // 
            // xoaButton
            // 
            this.xoaButton.Location = new System.Drawing.Point(454, 250);
            this.xoaButton.Name = "xoaButton";
            this.xoaButton.Size = new System.Drawing.Size(75, 23);
            this.xoaButton.TabIndex = 6;
            this.xoaButton.Text = "Xóa";
            this.xoaButton.UseVisualStyleBackColor = true;
            this.xoaButton.Click += new System.EventHandler(this.xoaButton_Click);
            // 
            // suaButton
            // 
            this.suaButton.Location = new System.Drawing.Point(535, 250);
            this.suaButton.Name = "suaButton";
            this.suaButton.Size = new System.Drawing.Size(75, 23);
            this.suaButton.TabIndex = 7;
            this.suaButton.Text = "Sửa";
            this.suaButton.UseVisualStyleBackColor = true;
            this.suaButton.Click += new System.EventHandler(this.suaButton_Click);
            // 
            // luuButton
            // 
            this.luuButton.Location = new System.Drawing.Point(616, 250);
            this.luuButton.Name = "luuButton";
            this.luuButton.Size = new System.Drawing.Size(75, 23);
            this.luuButton.TabIndex = 8;
            this.luuButton.Text = "Lưu";
            this.luuButton.UseVisualStyleBackColor = true;
            this.luuButton.Click += new System.EventHandler(this.luuButton_Click);
            // 
            // khachHangTextBox
            // 
            this.khachHangTextBox.Location = new System.Drawing.Point(101, 66);
            this.khachHangTextBox.Name = "khachHangTextBox";
            this.khachHangTextBox.Size = new System.Drawing.Size(198, 20);
            this.khachHangTextBox.TabIndex = 1;
            // 
            // phongComboBox
            // 
            this.phongComboBox.FormattingEnabled = true;
            this.phongComboBox.Items.AddRange(new object[] {
            "Nội địa",
            "Nước ngoài"});
            this.phongComboBox.Location = new System.Drawing.Point(101, 28);
            this.phongComboBox.Name = "phongComboBox";
            this.phongComboBox.Size = new System.Drawing.Size(198, 21);
            this.phongComboBox.TabIndex = 0;
            // 
            // thanhToanButton
            // 
            this.thanhToanButton.Location = new System.Drawing.Point(698, 249);
            this.thanhToanButton.Name = "thanhToanButton";
            this.thanhToanButton.Size = new System.Drawing.Size(75, 23);
            this.thanhToanButton.TabIndex = 9;
            this.thanhToanButton.Text = "Thanh toán";
            this.thanhToanButton.UseVisualStyleBackColor = true;
            this.thanhToanButton.Click += new System.EventHandler(this.thanhToanButton_Click);
            // 
            // CheckInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 293);
            this.Controls.Add(this.thanhToanButton);
            this.Controls.Add(this.phongComboBox);
            this.Controls.Add(this.khachHangTextBox);
            this.Controls.Add(this.luuButton);
            this.Controls.Add(this.suaButton);
            this.Controls.Add(this.xoaButton);
            this.Controls.Add(this.themButton);
            this.Controls.Add(this.phieuThuePhongGridView);
            this.Controls.Add(this.loaiKhachComboBox);
            this.Controls.Add(this.CMNDTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "CheckInForm";
            this.Text = "Phiếu thuê phòng";
            this.Load += new System.EventHandler(this.CheckInForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phieuThuePhongGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CMNDTextBox;
        private System.Windows.Forms.ComboBox loaiKhachComboBox;
        private System.Windows.Forms.DataGridView phieuThuePhongGridView;
        private System.Windows.Forms.Button themButton;
        private System.Windows.Forms.Button xoaButton;
        private System.Windows.Forms.Button suaButton;
        private System.Windows.Forms.Button luuButton;
        private System.Windows.Forms.TextBox khachHangTextBox;
        private System.Windows.Forms.ComboBox phongComboBox;
        private System.Windows.Forms.Button thanhToanButton;
    }
}
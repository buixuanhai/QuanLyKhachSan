namespace QuanLyKhachSan
{
    partial class PhieuThuePhong
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.phongTextBox = new System.Windows.Forms.TextBox();
            this.ngayThueTextBox = new System.Windows.Forms.TextBox();
            this.diaChiTextBox = new System.Windows.Forms.TextBox();
            this.cMDNTextBox = new System.Windows.Forms.TextBox();
            this.loaiKhachComboBox = new System.Windows.Forms.ComboBox();
            this.phieuThuePhongGridView = new System.Windows.Forms.DataGridView();
            this.themButton = new System.Windows.Forms.Button();
            this.xoaButton = new System.Windows.Forms.Button();
            this.suaButton = new System.Windows.Forms.Button();
            this.luuButton = new System.Windows.Forms.Button();
            this.khachHangTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.phieuThuePhongGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phòng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày thuê";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loại khách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CMND";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Địa chỉ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // phongTextBox
            // 
            this.phongTextBox.Location = new System.Drawing.Point(101, 27);
            this.phongTextBox.Name = "phongTextBox";
            this.phongTextBox.Size = new System.Drawing.Size(100, 20);
            this.phongTextBox.TabIndex = 6;
            // 
            // ngayThueTextBox
            // 
            this.ngayThueTextBox.Location = new System.Drawing.Point(293, 27);
            this.ngayThueTextBox.Name = "ngayThueTextBox";
            this.ngayThueTextBox.Size = new System.Drawing.Size(100, 20);
            this.ngayThueTextBox.TabIndex = 7;
            // 
            // diaChiTextBox
            // 
            this.diaChiTextBox.Location = new System.Drawing.Point(101, 181);
            this.diaChiTextBox.Name = "diaChiTextBox";
            this.diaChiTextBox.Size = new System.Drawing.Size(121, 20);
            this.diaChiTextBox.TabIndex = 8;
            // 
            // cMDNTextBox
            // 
            this.cMDNTextBox.Location = new System.Drawing.Point(101, 144);
            this.cMDNTextBox.Name = "cMDNTextBox";
            this.cMDNTextBox.Size = new System.Drawing.Size(121, 20);
            this.cMDNTextBox.TabIndex = 9;
            // 
            // loaiKhachComboBox
            // 
            this.loaiKhachComboBox.FormattingEnabled = true;
            this.loaiKhachComboBox.Items.AddRange(new object[] {
            "Nội địa",
            "Nước ngoài"});
            this.loaiKhachComboBox.Location = new System.Drawing.Point(101, 106);
            this.loaiKhachComboBox.Name = "loaiKhachComboBox";
            this.loaiKhachComboBox.Size = new System.Drawing.Size(121, 21);
            this.loaiKhachComboBox.TabIndex = 11;
            this.loaiKhachComboBox.SelectedIndexChanged += new System.EventHandler(this.loaiKhachcomboBox_SelectedIndexChanged);
            // 
            // phieuThuePhongGridView
            // 
            this.phieuThuePhongGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phieuThuePhongGridView.Location = new System.Drawing.Point(421, 27);
            this.phieuThuePhongGridView.Name = "phieuThuePhongGridView";
            this.phieuThuePhongGridView.Size = new System.Drawing.Size(325, 196);
            this.phieuThuePhongGridView.TabIndex = 12;
            // 
            // themButton
            // 
            this.themButton.Location = new System.Drawing.Point(147, 246);
            this.themButton.Name = "themButton";
            this.themButton.Size = new System.Drawing.Size(75, 23);
            this.themButton.TabIndex = 13;
            this.themButton.Text = "Thêm";
            this.themButton.UseVisualStyleBackColor = true;
            // 
            // xoaButton
            // 
            this.xoaButton.Location = new System.Drawing.Point(486, 261);
            this.xoaButton.Name = "xoaButton";
            this.xoaButton.Size = new System.Drawing.Size(75, 23);
            this.xoaButton.TabIndex = 14;
            this.xoaButton.Text = "Xóa";
            this.xoaButton.UseVisualStyleBackColor = true;
            // 
            // suaButton
            // 
            this.suaButton.Location = new System.Drawing.Point(567, 261);
            this.suaButton.Name = "suaButton";
            this.suaButton.Size = new System.Drawing.Size(75, 23);
            this.suaButton.TabIndex = 15;
            this.suaButton.Text = "Sửa";
            this.suaButton.UseVisualStyleBackColor = true;
            // 
            // luuButton
            // 
            this.luuButton.Location = new System.Drawing.Point(648, 261);
            this.luuButton.Name = "luuButton";
            this.luuButton.Size = new System.Drawing.Size(75, 23);
            this.luuButton.TabIndex = 16;
            this.luuButton.Text = "Lưu";
            this.luuButton.UseVisualStyleBackColor = true;
            // 
            // khachHangTextBox
            // 
            this.khachHangTextBox.Location = new System.Drawing.Point(101, 66);
            this.khachHangTextBox.Name = "khachHangTextBox";
            this.khachHangTextBox.Size = new System.Drawing.Size(100, 20);
            this.khachHangTextBox.TabIndex = 17;
            // 
            // PhieuThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 442);
            this.Controls.Add(this.khachHangTextBox);
            this.Controls.Add(this.luuButton);
            this.Controls.Add(this.suaButton);
            this.Controls.Add(this.xoaButton);
            this.Controls.Add(this.themButton);
            this.Controls.Add(this.phieuThuePhongGridView);
            this.Controls.Add(this.loaiKhachComboBox);
            this.Controls.Add(this.cMDNTextBox);
            this.Controls.Add(this.diaChiTextBox);
            this.Controls.Add(this.ngayThueTextBox);
            this.Controls.Add(this.phongTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PhieuThuePhong";
            this.Text = "Phiếu thuê phòng";
            ((System.ComponentModel.ISupportInitialize)(this.phieuThuePhongGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phongTextBox;
        private System.Windows.Forms.TextBox ngayThueTextBox;
        private System.Windows.Forms.TextBox diaChiTextBox;
        private System.Windows.Forms.TextBox cMDNTextBox;
        private System.Windows.Forms.ComboBox loaiKhachComboBox;
        private System.Windows.Forms.DataGridView phieuThuePhongGridView;
        private System.Windows.Forms.Button themButton;
        private System.Windows.Forms.Button xoaButton;
        private System.Windows.Forms.Button suaButton;
        private System.Windows.Forms.Button luuButton;
        private System.Windows.Forms.TextBox khachHangTextBox;
    }
}
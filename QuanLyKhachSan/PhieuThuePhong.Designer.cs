﻿namespace QuanLyKhachSan
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
            this.phongtextBox = new System.Windows.Forms.TextBox();
            this.ngayThuetextBox = new System.Windows.Forms.TextBox();
            this.diaChitextBox = new System.Windows.Forms.TextBox();
            this.cMDNtextBox = new System.Windows.Forms.TextBox();
            this.loaiKhachcomboBox = new System.Windows.Forms.ComboBox();
            this.phieuThuePhongGridView = new System.Windows.Forms.DataGridView();
            this.ThemButton = new System.Windows.Forms.Button();
            this.XoaButton = new System.Windows.Forms.Button();
            this.SuaButton = new System.Windows.Forms.Button();
            this.luuButton = new System.Windows.Forms.Button();
            this.khachHangtextBox = new System.Windows.Forms.TextBox();
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
            // phongtextBox
            // 
            this.phongtextBox.Location = new System.Drawing.Point(101, 27);
            this.phongtextBox.Name = "phongtextBox";
            this.phongtextBox.Size = new System.Drawing.Size(100, 20);
            this.phongtextBox.TabIndex = 6;
            // 
            // ngayThuetextBox
            // 
            this.ngayThuetextBox.Location = new System.Drawing.Point(293, 27);
            this.ngayThuetextBox.Name = "ngayThuetextBox";
            this.ngayThuetextBox.Size = new System.Drawing.Size(100, 20);
            this.ngayThuetextBox.TabIndex = 7;
            // 
            // diaChitextBox
            // 
            this.diaChitextBox.Location = new System.Drawing.Point(101, 181);
            this.diaChitextBox.Name = "diaChitextBox";
            this.diaChitextBox.Size = new System.Drawing.Size(121, 20);
            this.diaChitextBox.TabIndex = 8;
            // 
            // cMDNtextBox
            // 
            this.cMDNtextBox.Location = new System.Drawing.Point(101, 144);
            this.cMDNtextBox.Name = "cMDNtextBox";
            this.cMDNtextBox.Size = new System.Drawing.Size(121, 20);
            this.cMDNtextBox.TabIndex = 9;
            // 
            // loaiKhachcomboBox
            // 
            this.loaiKhachcomboBox.FormattingEnabled = true;
            this.loaiKhachcomboBox.Items.AddRange(new object[] {
            "Nội địa",
            "Nước ngoài"});
            this.loaiKhachcomboBox.Location = new System.Drawing.Point(101, 106);
            this.loaiKhachcomboBox.Name = "loaiKhachcomboBox";
            this.loaiKhachcomboBox.Size = new System.Drawing.Size(121, 21);
            this.loaiKhachcomboBox.TabIndex = 11;
            this.loaiKhachcomboBox.SelectedIndexChanged += new System.EventHandler(this.loaiKhachcomboBox_SelectedIndexChanged);
            // 
            // phieuThuePhongGridView
            // 
            this.phieuThuePhongGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phieuThuePhongGridView.Location = new System.Drawing.Point(421, 27);
            this.phieuThuePhongGridView.Name = "phieuThuePhongGridView";
            this.phieuThuePhongGridView.Size = new System.Drawing.Size(325, 196);
            this.phieuThuePhongGridView.TabIndex = 12;
            // 
            // ThemButton
            // 
            this.ThemButton.Location = new System.Drawing.Point(147, 246);
            this.ThemButton.Name = "ThemButton";
            this.ThemButton.Size = new System.Drawing.Size(75, 23);
            this.ThemButton.TabIndex = 13;
            this.ThemButton.Text = "Thêm";
            this.ThemButton.UseVisualStyleBackColor = true;
            // 
            // XoaButton
            // 
            this.XoaButton.Location = new System.Drawing.Point(486, 261);
            this.XoaButton.Name = "XoaButton";
            this.XoaButton.Size = new System.Drawing.Size(75, 23);
            this.XoaButton.TabIndex = 14;
            this.XoaButton.Text = "Xóa";
            this.XoaButton.UseVisualStyleBackColor = true;
            // 
            // SuaButton
            // 
            this.SuaButton.Location = new System.Drawing.Point(567, 261);
            this.SuaButton.Name = "SuaButton";
            this.SuaButton.Size = new System.Drawing.Size(75, 23);
            this.SuaButton.TabIndex = 15;
            this.SuaButton.Text = "Sửa";
            this.SuaButton.UseVisualStyleBackColor = true;
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
            // khachHangtextBox
            // 
            this.khachHangtextBox.Location = new System.Drawing.Point(101, 66);
            this.khachHangtextBox.Name = "khachHangtextBox";
            this.khachHangtextBox.Size = new System.Drawing.Size(100, 20);
            this.khachHangtextBox.TabIndex = 17;
            // 
            // PhieuThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 442);
            this.Controls.Add(this.khachHangtextBox);
            this.Controls.Add(this.luuButton);
            this.Controls.Add(this.SuaButton);
            this.Controls.Add(this.XoaButton);
            this.Controls.Add(this.ThemButton);
            this.Controls.Add(this.phieuThuePhongGridView);
            this.Controls.Add(this.loaiKhachcomboBox);
            this.Controls.Add(this.cMDNtextBox);
            this.Controls.Add(this.diaChitextBox);
            this.Controls.Add(this.ngayThuetextBox);
            this.Controls.Add(this.phongtextBox);
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
        private System.Windows.Forms.TextBox phongtextBox;
        private System.Windows.Forms.TextBox ngayThuetextBox;
        private System.Windows.Forms.TextBox diaChitextBox;
        private System.Windows.Forms.TextBox cMDNtextBox;
        private System.Windows.Forms.ComboBox loaiKhachcomboBox;
        private System.Windows.Forms.DataGridView phieuThuePhongGridView;
        private System.Windows.Forms.Button ThemButton;
        private System.Windows.Forms.Button XoaButton;
        private System.Windows.Forms.Button SuaButton;
        private System.Windows.Forms.Button luuButton;
        private System.Windows.Forms.TextBox khachHangtextBox;
    }
}
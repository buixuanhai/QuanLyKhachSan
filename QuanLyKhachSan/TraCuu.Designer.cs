namespace QuanLyKhachSan
{
    partial class TraCuu
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
            this.timKiemButton = new System.Windows.Forms.Button();
            this.loaiPhongComboBox = new System.Windows.Forms.ComboBox();
            this.ngayThuePhongComboBox = new System.Windows.Forms.ComboBox();
            this.loaiKhachComboBox = new System.Windows.Forms.ComboBox();
            this.traCuuGridView = new System.Windows.Forms.DataGridView();
            this.xoaButton = new System.Windows.Forms.Button();
            this.suaButton = new System.Windows.Forms.Button();
            this.luuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.traCuuGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại khách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày thuê phòng";
            // 
            // timKiemButton
            // 
            this.timKiemButton.Location = new System.Drawing.Point(171, 148);
            this.timKiemButton.Name = "timKiemButton";
            this.timKiemButton.Size = new System.Drawing.Size(75, 23);
            this.timKiemButton.TabIndex = 3;
            this.timKiemButton.Text = "Tìm Kiếm";
            this.timKiemButton.UseVisualStyleBackColor = true;
            // 
            // loaiPhongComboBox
            // 
            this.loaiPhongComboBox.FormattingEnabled = true;
            this.loaiPhongComboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.loaiPhongComboBox.Location = new System.Drawing.Point(162, 23);
            this.loaiPhongComboBox.Name = "loaiPhongComboBox";
            this.loaiPhongComboBox.Size = new System.Drawing.Size(121, 21);
            this.loaiPhongComboBox.TabIndex = 4;
            // 
            // ngayThuePhongComboBox
            // 
            this.ngayThuePhongComboBox.FormattingEnabled = true;
            this.ngayThuePhongComboBox.Location = new System.Drawing.Point(162, 94);
            this.ngayThuePhongComboBox.Name = "ngayThuePhongComboBox";
            this.ngayThuePhongComboBox.Size = new System.Drawing.Size(121, 21);
            this.ngayThuePhongComboBox.TabIndex = 5;
            // 
            // loaiKhachComboBox
            // 
            this.loaiKhachComboBox.FormattingEnabled = true;
            this.loaiKhachComboBox.Items.AddRange(new object[] {
            "Nội địa",
            "Nước ngoài"});
            this.loaiKhachComboBox.Location = new System.Drawing.Point(162, 58);
            this.loaiKhachComboBox.Name = "loaiKhachComboBox";
            this.loaiKhachComboBox.Size = new System.Drawing.Size(121, 21);
            this.loaiKhachComboBox.TabIndex = 6;
            // 
            // traCuuGridView
            // 
            this.traCuuGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.traCuuGridView.Location = new System.Drawing.Point(328, 23);
            this.traCuuGridView.Name = "traCuuGridView";
            this.traCuuGridView.Size = new System.Drawing.Size(333, 163);
            this.traCuuGridView.TabIndex = 7;
            // 
            // xoaButton
            // 
            this.xoaButton.Location = new System.Drawing.Point(424, 207);
            this.xoaButton.Name = "xoaButton";
            this.xoaButton.Size = new System.Drawing.Size(75, 23);
            this.xoaButton.TabIndex = 8;
            this.xoaButton.Text = "Xóa";
            this.xoaButton.UseVisualStyleBackColor = true;
            // 
            // suaButton
            // 
            this.suaButton.Location = new System.Drawing.Point(505, 207);
            this.suaButton.Name = "suaButton";
            this.suaButton.Size = new System.Drawing.Size(75, 23);
            this.suaButton.TabIndex = 9;
            this.suaButton.Text = "Sửa";
            this.suaButton.UseVisualStyleBackColor = true;
            // 
            // luuButton
            // 
            this.luuButton.Location = new System.Drawing.Point(586, 207);
            this.luuButton.Name = "luuButton";
            this.luuButton.Size = new System.Drawing.Size(75, 23);
            this.luuButton.TabIndex = 10;
            this.luuButton.Text = "Lưu";
            this.luuButton.UseVisualStyleBackColor = true;
            // 
            // TraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 325);
            this.Controls.Add(this.luuButton);
            this.Controls.Add(this.suaButton);
            this.Controls.Add(this.xoaButton);
            this.Controls.Add(this.traCuuGridView);
            this.Controls.Add(this.loaiKhachComboBox);
            this.Controls.Add(this.ngayThuePhongComboBox);
            this.Controls.Add(this.loaiPhongComboBox);
            this.Controls.Add(this.timKiemButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TraCuu";
            this.Text = "Tra Cứu";
            ((System.ComponentModel.ISupportInitialize)(this.traCuuGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button timKiemButton;
        private System.Windows.Forms.ComboBox loaiPhongComboBox;
        private System.Windows.Forms.ComboBox ngayThuePhongComboBox;
        private System.Windows.Forms.ComboBox loaiKhachComboBox;
        private System.Windows.Forms.DataGridView traCuuGridView;
        private System.Windows.Forms.Button xoaButton;
        private System.Windows.Forms.Button suaButton;
        private System.Windows.Forms.Button luuButton;
    }
}
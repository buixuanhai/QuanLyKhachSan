namespace QuanLyKhachSan
{
    partial class DanhSachPhong
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
            this.soPhongTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loaiPhongcomboBox = new System.Windows.Forms.ComboBox();
            this.xoaButton = new System.Windows.Forms.Button();
            this.luuButton = new System.Windows.Forms.Button();
            this.suaButton = new System.Windows.Forms.Button();
            this.themButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.donGiacomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tinhTrangtextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // soPhongTextBox
            // 
            this.soPhongTextBox.Location = new System.Drawing.Point(83, 28);
            this.soPhongTextBox.Name = "soPhongTextBox";
            this.soPhongTextBox.Size = new System.Drawing.Size(100, 20);
            this.soPhongTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loại phòng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(238, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(285, 161);
            this.dataGridView1.TabIndex = 4;
            // 
            // loaiPhongcomboBox
            // 
            this.loaiPhongcomboBox.FormattingEnabled = true;
            this.loaiPhongcomboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.loaiPhongcomboBox.Location = new System.Drawing.Point(82, 63);
            this.loaiPhongcomboBox.Name = "loaiPhongcomboBox";
            this.loaiPhongcomboBox.Size = new System.Drawing.Size(121, 21);
            this.loaiPhongcomboBox.TabIndex = 5;
            // 
            // xoaButton
            // 
            this.xoaButton.Location = new System.Drawing.Point(285, 194);
            this.xoaButton.Name = "xoaButton";
            this.xoaButton.Size = new System.Drawing.Size(75, 23);
            this.xoaButton.TabIndex = 6;
            this.xoaButton.Text = "Xóa";
            this.xoaButton.UseVisualStyleBackColor = true;
            // 
            // luuButton
            // 
            this.luuButton.Location = new System.Drawing.Point(447, 194);
            this.luuButton.Name = "luuButton";
            this.luuButton.Size = new System.Drawing.Size(75, 23);
            this.luuButton.TabIndex = 7;
            this.luuButton.Text = "Lưu";
            this.luuButton.UseVisualStyleBackColor = true;
            this.luuButton.Click += new System.EventHandler(this.luuButton_Click);
            // 
            // suaButton
            // 
            this.suaButton.Location = new System.Drawing.Point(366, 194);
            this.suaButton.Name = "suaButton";
            this.suaButton.Size = new System.Drawing.Size(75, 23);
            this.suaButton.TabIndex = 8;
            this.suaButton.Text = "Sửa";
            this.suaButton.UseVisualStyleBackColor = true;
            // 
            // themButton
            // 
            this.themButton.Location = new System.Drawing.Point(83, 194);
            this.themButton.Name = "themButton";
            this.themButton.Size = new System.Drawing.Size(75, 23);
            this.themButton.TabIndex = 9;
            this.themButton.Text = "Thêm";
            this.themButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Đơn giá";
            // 
            // donGiacomboBox
            // 
            this.donGiacomboBox.FormattingEnabled = true;
            this.donGiacomboBox.Items.AddRange(new object[] {
            "150 000",
            "170 000",
            "200 000"});
            this.donGiacomboBox.Location = new System.Drawing.Point(83, 103);
            this.donGiacomboBox.Name = "donGiacomboBox";
            this.donGiacomboBox.Size = new System.Drawing.Size(121, 21);
            this.donGiacomboBox.TabIndex = 11;
            this.donGiacomboBox.SelectedIndexChanged += new System.EventHandler(this.donGiacomboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tình trạng";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tinhTrangtextBox
            // 
            this.tinhTrangtextBox.Location = new System.Drawing.Point(82, 135);
            this.tinhTrangtextBox.Name = "tinhTrangtextBox";
            this.tinhTrangtextBox.Size = new System.Drawing.Size(122, 20);
            this.tinhTrangtextBox.TabIndex = 13;
            // 
            // DanhSachPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 261);
            this.Controls.Add(this.tinhTrangtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.donGiacomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.themButton);
            this.Controls.Add(this.suaButton);
            this.Controls.Add(this.luuButton);
            this.Controls.Add(this.xoaButton);
            this.Controls.Add(this.loaiPhongcomboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.soPhongTextBox);
            this.Name = "DanhSachPhong";
            this.Text = "Danh sách phòng";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox soPhongTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox loaiPhongcomboBox;
        private System.Windows.Forms.Button xoaButton;
        private System.Windows.Forms.Button luuButton;
        private System.Windows.Forms.Button suaButton;
        private System.Windows.Forms.Button themButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox donGiacomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tinhTrangtextBox;
    }
}
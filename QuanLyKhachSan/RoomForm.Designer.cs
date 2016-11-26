namespace QuanLyKhachSan
{
    partial class RoomForm
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
            this.danhSachPhongGridView = new System.Windows.Forms.DataGridView();
            this.xoaButton = new System.Windows.Forms.Button();
            this.luuButton = new System.Windows.Forms.Button();
            this.suaButton = new System.Windows.Forms.Button();
            this.themButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.loaiPhongComboBox = new System.Windows.Forms.ComboBox();
            this.tinhTrangPhongComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachPhongGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // soPhongTextBox
            // 
            this.soPhongTextBox.Location = new System.Drawing.Point(83, 28);
            this.soPhongTextBox.Name = "soPhongTextBox";
            this.soPhongTextBox.Size = new System.Drawing.Size(121, 20);
            this.soPhongTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
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
            // danhSachPhongGridView
            // 
            this.danhSachPhongGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhSachPhongGridView.Location = new System.Drawing.Point(238, 12);
            this.danhSachPhongGridView.Name = "danhSachPhongGridView";
            this.danhSachPhongGridView.Size = new System.Drawing.Size(460, 147);
            this.danhSachPhongGridView.TabIndex = 10;
            // 
            // xoaButton
            // 
            this.xoaButton.Location = new System.Drawing.Point(344, 165);
            this.xoaButton.Name = "xoaButton";
            this.xoaButton.Size = new System.Drawing.Size(75, 23);
            this.xoaButton.TabIndex = 7;
            this.xoaButton.Text = "Xóa";
            this.xoaButton.UseVisualStyleBackColor = true;
            this.xoaButton.Click += new System.EventHandler(this.xoaButton_Click);
            // 
            // luuButton
            // 
            this.luuButton.Location = new System.Drawing.Point(506, 165);
            this.luuButton.Name = "luuButton";
            this.luuButton.Size = new System.Drawing.Size(75, 23);
            this.luuButton.TabIndex = 9;
            this.luuButton.Text = "Lưu";
            this.luuButton.UseVisualStyleBackColor = true;
            this.luuButton.Click += new System.EventHandler(this.luuButton_Click);
            // 
            // suaButton
            // 
            this.suaButton.Location = new System.Drawing.Point(425, 165);
            this.suaButton.Name = "suaButton";
            this.suaButton.Size = new System.Drawing.Size(75, 23);
            this.suaButton.TabIndex = 8;
            this.suaButton.Text = "Sửa";
            this.suaButton.UseVisualStyleBackColor = true;
            this.suaButton.Click += new System.EventHandler(this.suaButton_Click);
            // 
            // themButton
            // 
            this.themButton.Location = new System.Drawing.Point(82, 136);
            this.themButton.Name = "themButton";
            this.themButton.Size = new System.Drawing.Size(121, 23);
            this.themButton.TabIndex = 6;
            this.themButton.Text = "Thêm";
            this.themButton.UseVisualStyleBackColor = true;
            this.themButton.Click += new System.EventHandler(this.themButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tình trạng";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // loaiPhongComboBox
            // 
            this.loaiPhongComboBox.FormattingEnabled = true;
            this.loaiPhongComboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.loaiPhongComboBox.Location = new System.Drawing.Point(82, 63);
            this.loaiPhongComboBox.Name = "loaiPhongComboBox";
            this.loaiPhongComboBox.Size = new System.Drawing.Size(121, 21);
            this.loaiPhongComboBox.TabIndex = 3;
            // 
            // tinhTrangPhongComboBox
            // 
            this.tinhTrangPhongComboBox.FormattingEnabled = true;
            this.tinhTrangPhongComboBox.Items.AddRange(new object[] {
            "150 000",
            "170 000",
            "200 000"});
            this.tinhTrangPhongComboBox.Location = new System.Drawing.Point(83, 97);
            this.tinhTrangPhongComboBox.Name = "tinhTrangPhongComboBox";
            this.tinhTrangPhongComboBox.Size = new System.Drawing.Size(121, 21);
            this.tinhTrangPhongComboBox.TabIndex = 5;
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 199);
            this.Controls.Add(this.tinhTrangPhongComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.themButton);
            this.Controls.Add(this.suaButton);
            this.Controls.Add(this.luuButton);
            this.Controls.Add(this.xoaButton);
            this.Controls.Add(this.loaiPhongComboBox);
            this.Controls.Add(this.danhSachPhongGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.soPhongTextBox);
            this.Name = "RoomForm";
            this.Text = "Danh sách phòng";
            this.Load += new System.EventHandler(this.DanhSachPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.danhSachPhongGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox soPhongTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView danhSachPhongGridView;
        private System.Windows.Forms.Button xoaButton;
        private System.Windows.Forms.Button luuButton;
        private System.Windows.Forms.Button suaButton;
        private System.Windows.Forms.Button themButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox loaiPhongComboBox;
        private System.Windows.Forms.ComboBox tinhTrangPhongComboBox;
    }
}
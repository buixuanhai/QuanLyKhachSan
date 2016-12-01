namespace QuanLyKhachSan
{
    partial class ReportForm
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
            this.thangComboBox = new System.Windows.Forms.ComboBox();
            this.loaiPhongComboBox = new System.Windows.Forms.ComboBox();
            this.baoCaoDoanhThuGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.viewButon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoDoanhThuGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tháng";
            // 
            // thangComboBox
            // 
            this.thangComboBox.FormattingEnabled = true;
            this.thangComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.thangComboBox.Location = new System.Drawing.Point(156, 24);
            this.thangComboBox.Name = "thangComboBox";
            this.thangComboBox.Size = new System.Drawing.Size(121, 21);
            this.thangComboBox.TabIndex = 4;
            // 
            // loaiPhongComboBox
            // 
            this.loaiPhongComboBox.FormattingEnabled = true;
            this.loaiPhongComboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.loaiPhongComboBox.Location = new System.Drawing.Point(156, 55);
            this.loaiPhongComboBox.Name = "loaiPhongComboBox";
            this.loaiPhongComboBox.Size = new System.Drawing.Size(121, 21);
            this.loaiPhongComboBox.TabIndex = 5;
            // 
            // baoCaoDoanhThuGridView
            // 
            this.baoCaoDoanhThuGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.baoCaoDoanhThuGridView.Location = new System.Drawing.Point(298, 24);
            this.baoCaoDoanhThuGridView.Name = "baoCaoDoanhThuGridView";
            this.baoCaoDoanhThuGridView.Size = new System.Drawing.Size(364, 301);
            this.baoCaoDoanhThuGridView.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại phòng";
            // 
            // viewButon
            // 
            this.viewButon.Location = new System.Drawing.Point(156, 92);
            this.viewButon.Name = "viewButon";
            this.viewButon.Size = new System.Drawing.Size(121, 23);
            this.viewButon.TabIndex = 9;
            this.viewButon.Text = "Xem";
            this.viewButon.UseVisualStyleBackColor = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 337);
            this.Controls.Add(this.viewButon);
            this.Controls.Add(this.baoCaoDoanhThuGridView);
            this.Controls.Add(this.loaiPhongComboBox);
            this.Controls.Add(this.thangComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReportForm";
            this.Text = "Báo Cáo Doanh Thu";
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoDoanhThuGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox thangComboBox;
        private System.Windows.Forms.ComboBox loaiPhongComboBox;
        private System.Windows.Forms.DataGridView baoCaoDoanhThuGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button viewButon;
    }
}
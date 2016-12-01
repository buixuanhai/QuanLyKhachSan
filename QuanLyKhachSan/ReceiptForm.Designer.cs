namespace QuanLyKhachSan
{
    partial class ReceiptForm
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
            this.hoaDonGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.receiptIdTextBox = new System.Windows.Forms.TextBox();
            this.searchReceiptButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // hoaDonGridView
            // 
            this.hoaDonGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hoaDonGridView.Location = new System.Drawing.Point(12, 99);
            this.hoaDonGridView.Name = "hoaDonGridView";
            this.hoaDonGridView.Size = new System.Drawing.Size(683, 186);
            this.hoaDonGridView.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Danh sách hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nhập mã hóa đơn";
            // 
            // receiptIdTextBox
            // 
            this.receiptIdTextBox.Location = new System.Drawing.Point(113, 56);
            this.receiptIdTextBox.Name = "receiptIdTextBox";
            this.receiptIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.receiptIdTextBox.TabIndex = 18;
            // 
            // searchReceiptButton
            // 
            this.searchReceiptButton.Location = new System.Drawing.Point(219, 55);
            this.searchReceiptButton.Name = "searchReceiptButton";
            this.searchReceiptButton.Size = new System.Drawing.Size(75, 23);
            this.searchReceiptButton.TabIndex = 19;
            this.searchReceiptButton.Text = "Tìm kiếm";
            this.searchReceiptButton.UseVisualStyleBackColor = true;
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 297);
            this.Controls.Add(this.searchReceiptButton);
            this.Controls.Add(this.receiptIdTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hoaDonGridView);
            this.Name = "ReceiptForm";
            this.Text = "Hóa Đơn Thanh Toán";
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView hoaDonGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox receiptIdTextBox;
        private System.Windows.Forms.Button searchReceiptButton;
    }
}
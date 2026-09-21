namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMaSP = new TextBox();
            txtDonGia = new TextBox();
            txtSoLuong = new TextBox();
            btnThem = new Button();
            btnXoaTrang = new Button();
            lstKetQua = new ListBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 56);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã Sản Phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 84);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Số Lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 112);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Đơn Giá";
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(145, 53);
            txtMaSP.Margin = new Padding(3, 2, 3, 2);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(190, 23);
            txtMaSP.TabIndex = 3;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(145, 109);
            txtDonGia.Margin = new Padding(3, 2, 3, 2);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(190, 23);
            txtDonGia.TabIndex = 4;
            txtDonGia.TextChanged += txtDonGia_TextChanged;
            txtDonGia.KeyPress += txtDonGia_KeyPress;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(145, 82);
            txtSoLuong.Margin = new Padding(3, 2, 3, 2);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(190, 23);
            txtSoLuong.TabIndex = 5;
            txtSoLuong.KeyPress += txtSoLuong_KeyPress;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(47, 187);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(110, 22);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm (F2)";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.Location = new Point(196, 187);
            btnXoaTrang.Margin = new Padding(3, 2, 3, 2);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(119, 22);
            btnXoaTrang.TabIndex = 7;
            btnXoaTrang.Text = "Xóa trắng (F5)";
            btnXoaTrang.UseVisualStyleBackColor = true;
            btnXoaTrang.Click += btnXoaTrang_Click;
            // 
            // lstKetQua
            // 
            lstKetQua.FormattingEnabled = true;
            lstKetQua.Location = new Point(385, 9);
            lstKetQua.Margin = new Padding(3, 2, 3, 2);
            lstKetQua.Name = "lstKetQua";
            lstKetQua.Size = new Size(280, 304);
            lstKetQua.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(135, 17);
            label4.Name = "label4";
            label4.Size = new Size(163, 15);
            label4.TabIndex = 9;
            label4.Text = "6551071067_VOHOANGPHUC";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label4);
            Controls.Add(lstKetQua);
            Controls.Add(btnXoaTrang);
            Controls.Add(btnThem);
            Controls.Add(txtSoLuong);
            Controls.Add(txtDonGia);
            Controls.Add(txtMaSP);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Quan Ly Ban Hang";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMaSP;
        private TextBox txtDonGia;
        private TextBox txtSoLuong;
        private Button btnThem;
        private Button btnXoaTrang;
        private ListBox lstKetQua;
        private Label label4;
    }
}

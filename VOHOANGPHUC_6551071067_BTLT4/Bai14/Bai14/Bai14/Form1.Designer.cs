namespace Bai14
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTen = new Label();
            txtTen = new TextBox();
            lblLop = new Label();
            cboLop = new ComboBox();
            btnCapNhat = new Button();
            lblLopA = new Label();
            lblLopB = new Label();
            lstLopA = new ListBox();
            lstLopB = new ListBox();
            btnPhai1 = new Button();
            btnPhaiAll = new Button();
            btnTrai1 = new Button();
            btnTraiAll = new Button();
            btnXoaA = new Button();
            btnXoaB = new Button();
            btnKetThuc = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(18, 41);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(58, 15);
            lblTen.TabIndex = 1;
            lblTen.Text = "Họ và tên";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(97, 39);
            txtTen.Margin = new Padding(3, 2, 3, 2);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(176, 23);
            txtTen.TabIndex = 2;
            // 
            // lblLop
            // 
            lblLop.AutoSize = true;
            lblLop.Location = new Point(288, 41);
            lblLop.Name = "lblLop";
            lblLop.Size = new Size(27, 15);
            lblLop.TabIndex = 3;
            lblLop.Text = "Lớp";
            // 
            // cboLop
            // 
            cboLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLop.Location = new Point(332, 39);
            cboLop.Margin = new Padding(3, 2, 3, 2);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(106, 23);
            cboLop.TabIndex = 4;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(455, 37);
            btnCapNhat.Margin = new Padding(3, 2, 3, 2);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(88, 23);
            btnCapNhat.TabIndex = 5;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // lblLopA
            // 
            lblLopA.AutoSize = true;
            lblLopA.Location = new Point(18, 75);
            lblLopA.Name = "lblLopA";
            lblLopA.Size = new Size(38, 15);
            lblLopA.TabIndex = 6;
            lblLopA.Text = "Lớp A";
            // 
            // lblLopB
            // 
            lblLopB.AutoSize = true;
            lblLopB.Location = new Point(368, 75);
            lblLopB.Name = "lblLopB";
            lblLopB.Size = new Size(37, 15);
            lblLopB.TabIndex = 7;
            lblLopB.Text = "Lớp B";
            // 
            // lstLopA
            // 
            lstLopA.Location = new Point(18, 94);
            lstLopA.Margin = new Padding(3, 2, 3, 2);
            lstLopA.Name = "lstLopA";
            lstLopA.SelectionMode = SelectionMode.MultiExtended;
            lstLopA.Size = new Size(193, 184);
            lstLopA.TabIndex = 8;
            lstLopA.SelectedIndexChanged += lstLopA_SelectedIndexChanged;
            // 
            // lstLopB
            // 
            lstLopB.Location = new Point(368, 94);
            lstLopB.Margin = new Padding(3, 2, 3, 2);
            lstLopB.Name = "lstLopB";
            lstLopB.SelectionMode = SelectionMode.MultiExtended;
            lstLopB.Size = new Size(193, 184);
            lstLopB.TabIndex = 9;
            // 
            // btnPhai1
            // 
            btnPhai1.Location = new Point(237, 113);
            btnPhai1.Margin = new Padding(3, 2, 3, 2);
            btnPhai1.Name = "btnPhai1";
            btnPhai1.Size = new Size(105, 26);
            btnPhai1.TabIndex = 10;
            btnPhai1.Text = ">";
            btnPhai1.UseVisualStyleBackColor = true;
            btnPhai1.Click += btnPhai1_Click;
            // 
            // btnPhaiAll
            // 
            btnPhaiAll.Location = new Point(237, 150);
            btnPhaiAll.Margin = new Padding(3, 2, 3, 2);
            btnPhaiAll.Name = "btnPhaiAll";
            btnPhaiAll.Size = new Size(105, 26);
            btnPhaiAll.TabIndex = 11;
            btnPhaiAll.Text = ">>";
            btnPhaiAll.UseVisualStyleBackColor = true;
            btnPhaiAll.Click += btnPhaiAll_Click;
            // 
            // btnTrai1
            // 
            btnTrai1.Location = new Point(237, 187);
            btnTrai1.Margin = new Padding(3, 2, 3, 2);
            btnTrai1.Name = "btnTrai1";
            btnTrai1.Size = new Size(105, 26);
            btnTrai1.TabIndex = 12;
            btnTrai1.Text = "<";
            btnTrai1.UseVisualStyleBackColor = true;
            btnTrai1.Click += btnTrai1_Click;
            // 
            // btnTraiAll
            // 
            btnTraiAll.Location = new Point(237, 225);
            btnTraiAll.Margin = new Padding(3, 2, 3, 2);
            btnTraiAll.Name = "btnTraiAll";
            btnTraiAll.Size = new Size(105, 26);
            btnTraiAll.TabIndex = 13;
            btnTraiAll.Text = "<<";
            btnTraiAll.UseVisualStyleBackColor = true;
            btnTraiAll.Click += btnTraiAll_Click;
            // 
            // btnXoaA
            // 
            btnXoaA.Location = new Point(18, 293);
            btnXoaA.Margin = new Padding(3, 2, 3, 2);
            btnXoaA.Name = "btnXoaA";
            btnXoaA.Size = new Size(105, 26);
            btnXoaA.TabIndex = 14;
            btnXoaA.Text = "Xóa lớp A";
            btnXoaA.UseVisualStyleBackColor = true;
            btnXoaA.Click += btnXoaA_Click;
            // 
            // btnXoaB
            // 
            btnXoaB.Location = new Point(368, 293);
            btnXoaB.Margin = new Padding(3, 2, 3, 2);
            btnXoaB.Name = "btnXoaB";
            btnXoaB.Size = new Size(105, 26);
            btnXoaB.TabIndex = 15;
            btnXoaB.Text = "Xóa lớp B";
            btnXoaB.UseVisualStyleBackColor = true;
            btnXoaB.Click += btnXoaB_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(455, 293);
            btnKetThuc.Margin = new Padding(3, 2, 3, 2);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(105, 26);
            btnKetThuc.TabIndex = 16;
            btnKetThuc.Text = "Kết thúc";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 17;
            label1.Text = "6551071067";
            // 
            // Form1
            // 
            AcceptButton = btnCapNhat;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 337);
            Controls.Add(label1);
            Controls.Add(btnKetThuc);
            Controls.Add(btnXoaB);
            Controls.Add(btnXoaA);
            Controls.Add(btnTraiAll);
            Controls.Add(btnTrai1);
            Controls.Add(btnPhaiAll);
            Controls.Add(btnPhai1);
            Controls.Add(lstLopB);
            Controls.Add(lstLopA);
            Controls.Add(lblLopB);
            Controls.Add(lblLopA);
            Controls.Add(btnCapNhat);
            Controls.Add(cboLop);
            Controls.Add(lblLop);
            Controls.Add(txtTen);
            Controls.Add(lblTen);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 14 - Quản lý danh sách lớp";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTen;
        private TextBox txtTen;
        private Label lblLop;
        private ComboBox cboLop;
        private Button btnCapNhat;
        private Label lblLopA;
        private Label lblLopB;
        private ListBox lstLopA;
        private ListBox lstLopB;
        private Button btnPhai1;
        private Button btnPhaiAll;
        private Button btnTrai1;
        private Button btnTraiAll;
        private Button btnXoaA;
        private Button btnXoaB;
        private Button btnKetThuc;
        private Label label1;
    }
}

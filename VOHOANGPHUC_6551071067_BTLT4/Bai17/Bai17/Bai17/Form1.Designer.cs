namespace Bai17
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
            menuStrip1 = new MenuStrip();
            mnuChucNang = new ToolStripMenuItem();
            mnuCapNhat = new ToolStripMenuItem();
            mnuPhai1 = new ToolStripMenuItem();
            mnuPhaiAll = new ToolStripMenuItem();
            mnuTrai1 = new ToolStripMenuItem();
            mnuTraiAll = new ToolStripMenuItem();
            mnuXoaA = new ToolStripMenuItem();
            mnuXoaB = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuKetThuc = new ToolStripMenuItem();
            mnuThongTin = new ToolStripMenuItem();
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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuChucNang, mnuThongTin });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(586, 24);
            menuStrip1.TabIndex = 0;
            // 
            // mnuChucNang
            // 
            mnuChucNang.DropDownItems.AddRange(new ToolStripItem[] { mnuCapNhat, mnuPhai1, mnuPhaiAll, mnuTrai1, mnuTraiAll, mnuXoaA, mnuXoaB, toolStripSeparator1, mnuKetThuc });
            mnuChucNang.Name = "mnuChucNang";
            mnuChucNang.Size = new Size(77, 20);
            mnuChucNang.Text = "Chức năng";
            // 
            // mnuCapNhat
            // 
            mnuCapNhat.Name = "mnuCapNhat";
            mnuCapNhat.Size = new Size(248, 22);
            mnuCapNhat.Text = "Cập nhật";
            mnuCapNhat.Click += mnuCapNhat_Click;
            // 
            // mnuPhai1
            // 
            mnuPhai1.Name = "mnuPhai1";
            mnuPhai1.Size = new Size(248, 22);
            mnuPhai1.Text = "Chuyển phần tử chọn sang lớp B";
            mnuPhai1.Click += mnuPhai1_Click;
            // 
            // mnuPhaiAll
            // 
            mnuPhaiAll.Name = "mnuPhaiAll";
            mnuPhaiAll.Size = new Size(248, 22);
            mnuPhaiAll.Text = "Chuyển toàn bộ sang lớp B";
            mnuPhaiAll.Click += mnuPhaiAll_Click;
            // 
            // mnuTrai1
            // 
            mnuTrai1.Name = "mnuTrai1";
            mnuTrai1.Size = new Size(248, 22);
            mnuTrai1.Text = "Chuyển phần tử chọn sang lớp A";
            mnuTrai1.Click += mnuTrai1_Click;
            // 
            // mnuTraiAll
            // 
            mnuTraiAll.Name = "mnuTraiAll";
            mnuTraiAll.Size = new Size(248, 22);
            mnuTraiAll.Text = "Chuyển toàn bộ sang lớp A";
            mnuTraiAll.Click += mnuTraiAll_Click;
            // 
            // mnuXoaA
            // 
            mnuXoaA.Name = "mnuXoaA";
            mnuXoaA.Size = new Size(248, 22);
            mnuXoaA.Text = "Xóa lớp A";
            mnuXoaA.Click += mnuXoaA_Click;
            // 
            // mnuXoaB
            // 
            mnuXoaB.Name = "mnuXoaB";
            mnuXoaB.Size = new Size(248, 22);
            mnuXoaB.Text = "Xóa lớp B";
            mnuXoaB.Click += mnuXoaB_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(245, 6);
            // 
            // mnuKetThuc
            // 
            mnuKetThuc.Name = "mnuKetThuc";
            mnuKetThuc.Size = new Size(248, 22);
            mnuKetThuc.Text = "Kết thúc";
            mnuKetThuc.Click += mnuKetThuc_Click;
            // 
            // mnuThongTin
            // 
            mnuThongTin.Name = "mnuThongTin";
            mnuThongTin.Size = new Size(71, 20);
            mnuThongTin.Text = "Thông tin";
            mnuThongTin.Click += mnuThongTin_Click;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(18, 60);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(58, 15);
            lblTen.TabIndex = 2;
            lblTen.Text = "Họ và tên";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(96, 58);
            txtTen.Margin = new Padding(3, 2, 3, 2);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(176, 23);
            txtTen.TabIndex = 3;
            // 
            // lblLop
            // 
            lblLop.AutoSize = true;
            lblLop.Location = new Point(289, 60);
            lblLop.Name = "lblLop";
            lblLop.Size = new Size(27, 15);
            lblLop.TabIndex = 4;
            lblLop.Text = "Lớp";
            // 
            // cboLop
            // 
            cboLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLop.Location = new Point(332, 58);
            cboLop.Margin = new Padding(3, 2, 3, 2);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(106, 23);
            cboLop.TabIndex = 5;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(455, 56);
            btnCapNhat.Margin = new Padding(3, 2, 3, 2);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(88, 22);
            btnCapNhat.TabIndex = 6;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // lblLopA
            // 
            lblLopA.AutoSize = true;
            lblLopA.Location = new Point(18, 94);
            lblLopA.Name = "lblLopA";
            lblLopA.Size = new Size(38, 15);
            lblLopA.TabIndex = 7;
            lblLopA.Text = "Lớp A";
            // 
            // lblLopB
            // 
            lblLopB.AutoSize = true;
            lblLopB.Location = new Point(368, 94);
            lblLopB.Name = "lblLopB";
            lblLopB.Size = new Size(37, 15);
            lblLopB.TabIndex = 8;
            lblLopB.Text = "Lớp B";
            // 
            // lstLopA
            // 
            lstLopA.Location = new Point(18, 112);
            lstLopA.Margin = new Padding(3, 2, 3, 2);
            lstLopA.Name = "lstLopA";
            lstLopA.SelectionMode = SelectionMode.MultiExtended;
            lstLopA.Size = new Size(193, 184);
            lstLopA.TabIndex = 9;
            // 
            // lstLopB
            // 
            lstLopB.Location = new Point(368, 112);
            lstLopB.Margin = new Padding(3, 2, 3, 2);
            lstLopB.Name = "lstLopB";
            lstLopB.SelectionMode = SelectionMode.MultiExtended;
            lstLopB.Size = new Size(193, 184);
            lstLopB.TabIndex = 10;
            // 
            // btnPhai1
            // 
            btnPhai1.Location = new Point(236, 131);
            btnPhai1.Margin = new Padding(3, 2, 3, 2);
            btnPhai1.Name = "btnPhai1";
            btnPhai1.Size = new Size(105, 26);
            btnPhai1.TabIndex = 11;
            btnPhai1.Text = ">";
            btnPhai1.UseVisualStyleBackColor = true;
            btnPhai1.Click += btnPhai1_Click;
            // 
            // btnPhaiAll
            // 
            btnPhaiAll.Location = new Point(236, 169);
            btnPhaiAll.Margin = new Padding(3, 2, 3, 2);
            btnPhaiAll.Name = "btnPhaiAll";
            btnPhaiAll.Size = new Size(105, 26);
            btnPhaiAll.TabIndex = 12;
            btnPhaiAll.Text = ">>";
            btnPhaiAll.UseVisualStyleBackColor = true;
            btnPhaiAll.Click += btnPhaiAll_Click;
            // 
            // btnTrai1
            // 
            btnTrai1.Location = new Point(236, 206);
            btnTrai1.Margin = new Padding(3, 2, 3, 2);
            btnTrai1.Name = "btnTrai1";
            btnTrai1.Size = new Size(105, 26);
            btnTrai1.TabIndex = 13;
            btnTrai1.Text = "<";
            btnTrai1.UseVisualStyleBackColor = true;
            btnTrai1.Click += btnTrai1_Click;
            // 
            // btnTraiAll
            // 
            btnTraiAll.Location = new Point(236, 244);
            btnTraiAll.Margin = new Padding(3, 2, 3, 2);
            btnTraiAll.Name = "btnTraiAll";
            btnTraiAll.Size = new Size(105, 26);
            btnTraiAll.TabIndex = 14;
            btnTraiAll.Text = "<<";
            btnTraiAll.UseVisualStyleBackColor = true;
            btnTraiAll.Click += btnTraiAll_Click;
            // 
            // btnXoaA
            // 
            btnXoaA.Location = new Point(18, 311);
            btnXoaA.Margin = new Padding(3, 2, 3, 2);
            btnXoaA.Name = "btnXoaA";
            btnXoaA.Size = new Size(105, 26);
            btnXoaA.TabIndex = 15;
            btnXoaA.Text = "Xóa lớp A";
            btnXoaA.UseVisualStyleBackColor = true;
            btnXoaA.Click += btnXoaA_Click;
            // 
            // btnXoaB
            // 
            btnXoaB.Location = new Point(368, 311);
            btnXoaB.Margin = new Padding(3, 2, 3, 2);
            btnXoaB.Name = "btnXoaB";
            btnXoaB.Size = new Size(105, 26);
            btnXoaB.TabIndex = 16;
            btnXoaB.Text = "Xóa lớp B";
            btnXoaB.UseVisualStyleBackColor = true;
            btnXoaB.Click += btnXoaB_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(455, 311);
            btnKetThuc.Margin = new Padding(3, 2, 3, 2);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(105, 26);
            btnKetThuc.TabIndex = 17;
            btnKetThuc.Text = "Kết thúc";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(258, 27);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 18;
            label1.Text = "6551071067";
            // 
            // Form1
            // 
            AcceptButton = btnCapNhat;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 356);
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
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 17 - Menu cho Bài 14";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuChucNang;
        private ToolStripMenuItem mnuCapNhat;
        private ToolStripMenuItem mnuPhai1;
        private ToolStripMenuItem mnuPhaiAll;
        private ToolStripMenuItem mnuTrai1;
        private ToolStripMenuItem mnuTraiAll;
        private ToolStripMenuItem mnuXoaA;
        private ToolStripMenuItem mnuXoaB;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuKetThuc;
        private ToolStripMenuItem mnuThongTin;
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

namespace Bai18
{
    partial class frmMain
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
            mnuFile = new ToolStripMenuItem();
            mnuNewChild = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuExit = new ToolStripMenuItem();
            mnuWindow = new ToolStripMenuItem();
            mnuCascade = new ToolStripMenuItem();
            mnuTileHorizontal = new ToolStripMenuItem();
            mnuTileVertical = new ToolStripMenuItem();
            mnuHelp = new ToolStripMenuItem();
            mnuAbout = new ToolStripMenuItem();
            lblMssv = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile, mnuWindow, mnuHelp });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(788, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuNewChild, toolStripSeparator1, mnuExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(37, 20);
            mnuFile.Text = "File";
            // 
            // mnuNewChild
            // 
            mnuNewChild.Name = "mnuNewChild";
            mnuNewChild.Size = new Size(129, 22);
            mnuNewChild.Text = "New Child";
            mnuNewChild.Click += mnuNewChild_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(126, 6);
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(129, 22);
            mnuExit.Text = "Exit";
            mnuExit.Click += mnuExit_Click;
            // 
            // mnuWindow
            // 
            mnuWindow.DropDownItems.AddRange(new ToolStripItem[] { mnuCascade, mnuTileHorizontal, mnuTileVertical });
            mnuWindow.Name = "mnuWindow";
            mnuWindow.Size = new Size(63, 20);
            mnuWindow.Text = "Window";
            // 
            // mnuCascade
            // 
            mnuCascade.Name = "mnuCascade";
            mnuCascade.Size = new Size(151, 22);
            mnuCascade.Text = "Cascade";
            mnuCascade.Click += mnuCascade_Click;
            // 
            // mnuTileHorizontal
            // 
            mnuTileHorizontal.Name = "mnuTileHorizontal";
            mnuTileHorizontal.Size = new Size(151, 22);
            mnuTileHorizontal.Text = "Tile Horizontal";
            mnuTileHorizontal.Click += mnuTileHorizontal_Click;
            // 
            // mnuTileVertical
            // 
            mnuTileVertical.Name = "mnuTileVertical";
            mnuTileVertical.Size = new Size(151, 22);
            mnuTileVertical.Text = "Tile Vertical";
            mnuTileVertical.Click += mnuTileVertical_Click;
            // 
            // mnuHelp
            // 
            mnuHelp.DropDownItems.AddRange(new ToolStripItem[] { mnuAbout });
            mnuHelp.Name = "mnuHelp";
            mnuHelp.Size = new Size(44, 20);
            mnuHelp.Text = "Help";
            // 
            // mnuAbout
            // 
            mnuAbout.Name = "mnuAbout";
            mnuAbout.Size = new Size(107, 22);
            mnuAbout.Text = "About";
            mnuAbout.Click += mnuAbout_Click;
            // 
            // lblMssv
            // 
            lblMssv.AutoSize = true;
            lblMssv.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMssv.Location = new Point(31, 40);
            lblMssv.Name = "lblMssv";
            lblMssv.Size = new Size(261, 19);
            lblMssv.TabIndex = 2;
            lblMssv.Text = "MSSV: 6551071067 - VOHOANGPHUC";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 412);
            Controls.Add(lblMssv);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 18 - Ứng dụng MDI";
            WindowState = FormWindowState.Maximized;
            FormClosing += frmMain_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuNewChild;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuWindow;
        private ToolStripMenuItem mnuCascade;
        private ToolStripMenuItem mnuTileHorizontal;
        private ToolStripMenuItem mnuTileVertical;
        private ToolStripMenuItem mnuHelp;
        private ToolStripMenuItem mnuAbout;
        private Label lblMssv;
    }
}

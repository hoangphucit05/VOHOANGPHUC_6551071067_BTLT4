namespace bai_16
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
            components = new System.ComponentModel.Container();
            mnuMainMenu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            mnuContext = new ContextMenuStrip(components);
            đToolStripMenuItem = new ToolStripMenuItem();
            coppyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip2 = new ContextMenuStrip(components);
            textBox1 = new TextBox();
            label1 = new Label();
            mnuMainMenu.SuspendLayout();
            mnuContext.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMainMenu
            // 
            mnuMainMenu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, formatToolStripMenuItem, helpToolStripMenuItem });
            mnuMainMenu.Location = new Point(0, 0);
            mnuMainMenu.Name = "mnuMainMenu";
            mnuMainMenu.Size = new Size(800, 24);
            mnuMainMenu.TabIndex = 0;
            mnuMainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveAsToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(35, 20);
            fileToolStripMenuItem.Text = "file";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(114, 22);
            newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(114, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(114, 22);
            saveAsToolStripMenuItem.Text = "Save As";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(114, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(55, 20);
            formatToolStripMenuItem.Text = "format";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(42, 20);
            helpToolStripMenuItem.Text = "help";
            // 
            // mnuContext
            // 
            mnuContext.Items.AddRange(new ToolStripItem[] { đToolStripMenuItem, coppyToolStripMenuItem, pasteToolStripMenuItem });
            mnuContext.Name = "mnuContext";
            mnuContext.Size = new Size(110, 70);
            mnuContext.Opening += contextMenuStrip1_Opening;
            // 
            // đToolStripMenuItem
            // 
            đToolStripMenuItem.Name = "đToolStripMenuItem";
            đToolStripMenuItem.Size = new Size(109, 22);
            đToolStripMenuItem.Text = "Cut";
            đToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // coppyToolStripMenuItem
            // 
            coppyToolStripMenuItem.Name = "coppyToolStripMenuItem";
            coppyToolStripMenuItem.Size = new Size(109, 22);
            coppyToolStripMenuItem.Text = "Coppy";
            coppyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(109, 22);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // textBox1
            // 
            textBox1.ContextMenuStrip = mnuContext;
            textBox1.Location = new Point(26, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            textBox1.ContextMenuStripChanged += textBox1_TextChanged;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 122);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 3;
            label1.Text = "6551071067";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(mnuMainMenu);
            MainMenuStrip = mnuMainMenu;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ContextMenuStripChanged += textBox1_TextChanged;
            mnuMainMenu.ResumeLayout(false);
            mnuMainMenu.PerformLayout();
            mnuContext.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMainMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ContextMenuStrip mnuContext;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem đToolStripMenuItem;
        private ToolStripMenuItem coppyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private TextBox textBox1;
        private Label label1;
    }
}

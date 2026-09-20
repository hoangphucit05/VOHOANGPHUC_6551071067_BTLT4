namespace Bai15
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
            lblColor = new Label();
            dudColor = new DomainUpDown();
            lblSize = new Label();
            nudSize = new NumericUpDown();
            lblSampleText = new Label();
            btnDong = new Button();
            ((System.ComponentModel.ISupportInitialize)nudSize).BeginInit();
            SuspendLayout();
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(18, 45);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(31, 15);
            lblColor.TabIndex = 1;
            lblColor.Text = "Màu";
            // 
            // dudColor
            // 
            dudColor.Location = new Point(105, 43);
            dudColor.Margin = new Padding(3, 2, 3, 2);
            dudColor.Name = "dudColor";
            dudColor.Size = new Size(140, 23);
            dudColor.TabIndex = 2;
            dudColor.Wrap = true;
            dudColor.SelectedItemChanged += dudColor_SelectedItemChanged;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(18, 83);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(45, 15);
            lblSize.TabIndex = 3;
            lblSize.Text = "Cỡ chữ";
            // 
            // nudSize
            // 
            nudSize.Location = new Point(105, 81);
            nudSize.Margin = new Padding(3, 2, 3, 2);
            nudSize.Name = "nudSize";
            nudSize.Size = new Size(140, 23);
            nudSize.TabIndex = 4;
            nudSize.ValueChanged += nudSize_ValueChanged;
            // 
            // lblSampleText
            // 
            lblSampleText.BorderStyle = BorderStyle.FixedSingle;
            lblSampleText.Location = new Point(18, 127);
            lblSampleText.Name = "lblSampleText";
            lblSampleText.Size = new Size(386, 91);
            lblSampleText.TabIndex = 5;
            lblSampleText.Text = "6551071067_VOHOANGPHUC";
            lblSampleText.TextAlign = ContentAlignment.MiddleCenter;
            lblSampleText.Click += lblSampleText_Click;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(315, 240);
            btnDong.Margin = new Padding(3, 2, 3, 2);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(88, 26);
            btnDong.TabIndex = 6;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 285);
            Controls.Add(btnDong);
            Controls.Add(lblSampleText);
            Controls.Add(nudSize);
            Controls.Add(lblSize);
            Controls.Add(dudColor);
            Controls.Add(lblColor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 15 - DomainUpDown và NumericUpDown";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblColor;
        private DomainUpDown dudColor;
        private Label lblSize;
        private NumericUpDown nudSize;
        private Label lblSampleText;
        private Button btnDong;
    }
}

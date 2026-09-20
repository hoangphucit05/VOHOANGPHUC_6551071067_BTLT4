namespace bai_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open clicked");
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }

        // Sự kiện cho menu File → Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Sự kiện cho Context Menu
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cut clicked");
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copy clicked");
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Paste clicked");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

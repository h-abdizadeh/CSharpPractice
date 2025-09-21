namespace FardaWinFormsAppPack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(label1.Text);
            int m = int.Parse(textBox1.Text);
            if (n < m)
            {
                n = n + 1;
                label1.Text = n.ToString();
            }
            else
            {
                MessageBox.Show("end",
                    "msg",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(label1.Text);
            if (n > 0)
            {
                n = n - 1;
            }
            label1.Text = n.ToString();
        }


    }
}

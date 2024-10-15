namespace KeyControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var key = e.KeyChar;

            if (key is 'w')
            {
                pictureBox1.Top -= 1;
                pictureBox1.BackColor = Color.Red;
            }
            if (key is 'a')
            {
                pictureBox1.Left -= 1;
                pictureBox1.BackColor = Color.Green;
            }
            if (key is 'd')
            {
                pictureBox1.Left += 1;
                pictureBox1.BackColor = Color.Blue;
            }
            if (key is 's')
            {
                pictureBox1.Top += 1;
                pictureBox1.BackColor = Color.Yellow;
            }
        }
    }
}
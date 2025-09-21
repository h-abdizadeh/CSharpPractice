namespace News
{
    public partial class Form1 : Form
    {
        int slide = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Left += 5;
            if (label2.Left > panel1.Width)
            {
                label2.Left = -label2.Width;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text += " *** " + textBox1.Text;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = pictureBox3.BackgroundImage;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(slide == 1)
            {
                pictureBox1.BackgroundImage= pictureBox2.BackgroundImage;
                slide++;
            }
            else if(slide == 2)
            {
                pictureBox1.BackgroundImage = pictureBox3.BackgroundImage;
                slide=1;
            }
        }
    }
}

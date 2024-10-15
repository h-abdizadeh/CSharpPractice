namespace TimerCount
{
    public partial class Form1 : Form
    {
        int ms = 0, ss = 0, mm = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text.ToLower() is "start")
            {
                button1.Text = "STOP";
                button1.BackColor = Color.Red;
                timer1.Start();
            }
            else
            {
                button1.Text = "start".ToUpper();
                button1.BackColor = Color.Teal;
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ms = int.Parse(label1.Text);
            if (ms < 99)
            {
                ms++;
            }
            else if (ss < 59)
            {
                ms = 0;
                ss++;
            }
            else
            {
                ss = 0;
                mm++;
            }
            label1.Text = ms.ToString("00");
            label2.Text = $"{mm} minutes";
            label3.Text = $"{ss} seconds";
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ms = ss = mm = 0;
            label1.Text = "0";
            label2.Text = "0 minutes";
            label3.Text = "0 seconds";
            timer1.Stop();
            button1.Text = "START";
            button1.BackColor = Color.Teal;
        }
    }
}
namespace Counter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var n = int.Parse(label1.Text);
            var target = int.Parse(textBox1.Text);

            if (n < target)
                n++;

            label1.Text=n.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }
    }
}

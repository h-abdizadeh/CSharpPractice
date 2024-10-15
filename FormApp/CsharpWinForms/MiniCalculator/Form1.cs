namespace MiniCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out var n);
            double.TryParse(textBox2.Text, out var m);

            var result = n + m;
            label1.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out var n);
            double.TryParse(textBox2.Text, out var m);

            var result = n - m;
            label1.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out var n);
            double.TryParse(textBox2.Text, out var m);

            var result = n * m;
            label1.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out var n);
            double.TryParse(textBox2.Text, out var m);

            var result = n / m;
            label1.Text = result.ToString();
        }
    }
}
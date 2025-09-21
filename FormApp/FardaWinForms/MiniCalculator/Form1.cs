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
            var a = float.Parse(textBox1.Text);
            var b = float.Parse(textBox2.Text);

            label1.Text = (a + b).ToString();
        }

        private void calc1()
        {
            var a = float.Parse(textBox1.Text);
            var b = float.Parse(textBox2.Text);

            label1.Text = (a - b).ToString();
        }

        private void Calc(char opr)
        {
            var a = float.Parse(textBox1.Text);
            var b = float.Parse(textBox2.Text);

            if (opr == '+')
                label1.Text = (a + b).ToString();
            else if (opr == '-')
                label1.Text = (a - b).ToString();
            else if (opr == '*')
                label1.Text = (a * b).ToString();
            else if (opr == '/')
                label1.Text = (a / b).ToString();
        }
        private double CalcReturn(float a, float b, char opr)
        {
            var result = 0.0;

            if (opr == '+')
                result = a + b;
            else if (opr == '-')
                result = a - b;
            else if (opr == '*')
                result = a * b;
            else if (opr == '/')
                result = a / b;

            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calc1();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calc('*');
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var m = float.Parse(textBox1.Text);
            var n = float.Parse(textBox2.Text);

            var value = CalcReturn(m, n, '/');

            label1.Text = value.ToString();
        }
    }
}

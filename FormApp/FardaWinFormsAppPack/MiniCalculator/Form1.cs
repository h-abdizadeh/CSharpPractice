namespace MiniCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float a, b;
        private void button1_Click(object sender, EventArgs e)
        {
            float.TryParse(textBox1.Text, out var n);
            float.TryParse(textBox2.Text, out var m);

            label1.Text = (n + m).ToString();
        }

        public void Calc1(string opr)
        {
            float.TryParse(textBox1.Text, out var n);
            float.TryParse(textBox2.Text, out var m);

            if (opr is "+")
                label1.Text = (n + m).ToString();
            else if (opr is "-")
                label1.Text = (n - m).ToString();
            else if (opr is "*")
                label1.Text = (n * m).ToString();
            else if (opr is "/")
                label1.Text = (n / m).ToString();
        }

        public float Calc2(float n, float m, string opr)
        {
            var result = 0f;
            if (opr is "+")
                result = n + m;
            else if (opr is "-")
                result = n - m;
            else if (opr is "*")
                result = n * m;
            else if (opr is "/")
                result = n / m;

            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calc1("-");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //float.TryParse(textBox1.Text, out a);
            //float.TryParse(textBox2.Text, out b);

            //1
            //var r = Calc2(a, b, "*");
            //label1.Text = r.ToString();

            //2
            label1.Text = Calc2(a, b, "*").ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(textBox1.Text, out a);
            //MessageBox.Show(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(textBox2.Text, out b);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (b == 0)
                label1.Text = "Cannot divide by zero";
            else
                label1.Text = Calc2(a, b, "/").ToString();
        }
    }
}

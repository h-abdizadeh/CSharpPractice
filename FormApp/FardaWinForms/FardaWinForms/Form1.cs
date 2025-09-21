namespace FardaWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("سلام");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var n = int.Parse(button2.Text);
            if (n < 50)
                n = n + 1;//n++;
            button2.Text = n.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = comboBox1.SelectedIndex;

            if (index == 0)
                BackColor = Color.Red;

            //int n = (int)2.5;
            var text = (string)comboBox1.SelectedItem;

            if (text == "green")
                BackColor = Color.Green;

            if (index == comboBox1.Items.Count - 1)
            {
            rnd:
                var n = new Random().Next(4);
                if (n == 0 && BackColor != Color.Red)
                    BackColor = Color.Red;
                else if (n == 1 && BackColor != Color.Green)
                    BackColor = Color.Green;
                else if (n == 2 && BackColor != Color.Yellow)
                    BackColor = Color.Yellow;
                else if (n == 3 && BackColor != Color.Teal)
                    BackColor = Color.Teal;
                else
                    goto rnd;
            }
        }
    }
}

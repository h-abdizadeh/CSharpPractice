namespace StepCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //click button
        private void button1_Click(object sender, EventArgs e)
        {
            int count = int.Parse(label1.Text);
            //int end = int.Parse(textBox1.Text);
            int.TryParse(textBox1.Text, out int end);

            if (count < end)
            {
                count++;
                label1.Text = count.ToString();
            }
        }

        //reset button
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }
    }
}
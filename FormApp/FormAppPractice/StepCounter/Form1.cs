namespace StepCounter
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
            ushort.TryParse(textBox1.Text, out var end);
            if (n < end)
                n++;//n=n+1; n+=1;
                //if (n is end)
                    //messagebox...
            else
                MessageBox.Show("The End", "message", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            label1.Text = $"{n}";//n.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }
    }
}
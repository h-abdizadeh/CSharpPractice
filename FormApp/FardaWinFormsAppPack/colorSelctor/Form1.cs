namespace colorSelctor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //1
            //var colors = comboBox1.Items;
            //var i = new Random().Next(colors.Count);

            //if (i == 0) BackColor = Color.Red;
            //else if (i == 1) BackColor = Color.Green;
            //else if (i == 2) BackColor = Color.Yellow;
            //else if (i == 3) BackColor = Color.Teal;

            //2
            var colorText = "0123456789abcdef".ToCharArray();
            var color = "";

            for (int i = 1; i <= 6; i++)
            {
                var index = new Random().Next(colorText.Length);
                color += colorText[index];
            }

            BackColor = ColorTranslator.FromHtml($"#{color}");
            Text = $"#{color}";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text is "stop")
            {
                timer1.Stop();
                button1.Text = "start";
            }
            else
            {
                timer1.Start();
                button1.Text = "stop";
            }
        }
    }
}

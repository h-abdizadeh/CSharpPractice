namespace CircleClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1
            Circle circle = new Circle();
            //circle.PI = 3.14;//error
            circle.Radius = 10;

            MessageBox.Show($"PI = {circle.PI}");
            MessageBox.Show($"Radius = {circle.Radius}");

        }
    }
}
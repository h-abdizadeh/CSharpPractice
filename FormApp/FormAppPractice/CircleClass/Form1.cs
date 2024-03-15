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

        private void button2_Click(object sender, EventArgs e)
        {
            //2
            double.TryParse(textBox1.Text, out var r);
            Circle circle = new Circle()
            {
                //1
                //Radius = double.Parse(textBox1.Text)

                //2
                Radius = r,
            };

            var result = circle.GetPerimeter();
            MessageBox
            .Show($"radius={circle.Radius}, perimeter={result}");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //1
            //var circle = new Circle(5);

            //2
            double.TryParse(textBox1.Text, out var r);
            var circle = new Circle(r);

            MessageBox
            .Show($"radius={circle.Radius}, area={circle.GetArea()}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var circle = new Circle(5);

            //1
            //var ch = new CircleChild();
            //var result = ch.GetAreaChild();

            MessageBox
            .Show($"child area={new CircleChild(circle).GetAreaChild()}");
        }
    }
}
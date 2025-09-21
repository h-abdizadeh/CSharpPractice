namespace DrawingForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var map = new Bitmap(200, 200);
            using var graphic = Graphics.FromImage(map);
            graphic.Clear(Color.White);
            //graphic.DrawLine(Pens.Blue, 0, 0, 50, 50);
            graphic.DrawLine(Pens.Blue, new Point(0, 0), new Point(200, 200));
            graphic.DrawLine(Pens.Orange, new Point(0, 100), new Point(200, 100));
            //graphic.DrawRectangle(Pens.Red,
            //    new Rectangle(new Point(0, 0), new Size(50, 25)));
            graphic.DrawRectangle(Pens.Red,35,75,50,75);
            graphic.DrawBezier(Pens.Black, 5, 10, 11, 7, 38, 19,20,25);
            pictureBox1.BackgroundImage = map;

        }
    }
}

namespace DrawApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        var bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        var graphic = Graphics.FromImage(bmp);
        var pen = new Pen(Color.Red, 2.5f);

        graphic.DrawLine(pen, 0, 0, 480, 460);
        graphic.DrawLine(pen, new Point(0, 460), new Point(480, 0));
        graphic.DrawLine(pen, 0, 230, 240, 230);
        graphic.DrawLine(pen, 240, 230, 240, 0);

        pen = new Pen(Color.Teal, 2.5f);
        graphic.DrawRectangle(pen, 150, 150, 300, 300);

        pen = new Pen(Color.Blue, 2.5f);
        graphic.DrawPie(pen, 100, 100, 150, 150, 45, 310);

        pen = new Pen(Color.Orange, 2.5f);
        Point[] points =
            {new Point(100,100),
            new Point(300,300),
            new Point(50,200)};
        graphic.DrawPolygon(pen, points);

        var brush = new SolidBrush(Color.Olive);
        pen = new Pen(Color.Black, 10);
        Rectangle rectangle = new Rectangle(50, 50, 200, 100);
        graphic.FillRectangle(brush, rectangle);
        graphic.DrawRectangle(pen, rectangle);

        pictureBox1.BackgroundImage = bmp;
    }
}

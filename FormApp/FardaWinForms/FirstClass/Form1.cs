using FirstClass.classes;

namespace FirstClass;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        //var circle = new Circle();
        var circle=new Circle(7);
        //circle.Radius = 3;
        label1.Text = $"""
            radius : {circle.Radius}
            Diameter: {circle.Diameter}
            Area: {circle.Area()}
            Circumference: {circle.Circumference()}
            """;



    }
}


namespace CircleClass;

public class Circle
{
    //property 1
    //prop -> tab
    public double PI { get; } = Math.PI;
    public double Radius { get; set; }

    //constructor 3
    //ctor -> tab
    public Circle(double radius = 0)
    {
        Radius = radius;
    }

    //method 2
    public double GetPerimeter()
    {
        return 2 * Radius * PI;
    }

    public double GetArea()
    {
        //1
        return Radius * Radius * PI;

        //2
        //return Math.Pow(Radius, 2) * PI;
    }

}

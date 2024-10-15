
namespace CircleClass;

public class Circle
{
    //property (attribute)
    public double Radius { get; set; }
    public double Pi { get; set; } = Math.PI;

    //constructor
    public Circle(double _Radius)
    {
        //this.Radius = _Radius;
        Radius = _Radius;
    }


    //method
    public double Perimeter()
    {
        var P = 2 * Radius * Pi;
        return P;
    }

    public double Area()
    {
        var A = Radius * Radius * Pi;
        return A;
    }
}

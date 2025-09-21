

namespace FirstClass.classes;

public class Circle
{
    //1 property (prop + tab)
    public int Radius { get; set; }
    private double pi { get; set; } = 3.14;
    public int Diameter
    {
        get
        {
            return 2 * Radius;
        }
    }

    //2 constructor (ctor + tab)
    public Circle(int r = 1)
    {
        Radius = r;
    }


    //3 method
    public double Circumference()
    {
        //var c = Radius * 2 * pi;
        var c = Diameter * pi;
        return c;
    }

    public double Area()
    {
        var a = Radius * Radius * pi;
        return a;
    }
}

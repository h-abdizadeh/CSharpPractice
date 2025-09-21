
namespace CircleClass;

public class Circle
{
    //property (prop + tab)
    /*public double Radius { get; set; }*/
    private double Radius; /*{ get; set; }*/

    public double _Radius
    {
        get => Radius;
        set
        {
            if (value < 0)
                Radius = 0;
            else
                Radius = value;
        }
    }

    public double Pi { get; set; } = 3.14;


    //1
    public double Diameter => Radius * 2;
    //2
    //public double Diameter
    //{
    //    get
    //    {
    //        return Radius * 2;
    //    }
    //}


    //constructor (ctor + tab)
    public Circle(double r)
    {
        Radius = r;
    }





    //method
    public double Area()
    {
        var a = Radius * Radius * Pi;
        return a;
    }

    public double Circumference()
    {
        //var c = 2 * Radius * Pi;
        var c = Diameter * Pi;
        return c;
    }
}

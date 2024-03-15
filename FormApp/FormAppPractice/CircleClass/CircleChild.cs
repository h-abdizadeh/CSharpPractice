

namespace CircleClass;

public class CircleChild : Circle
{
    private double r { get; set; }
    public CircleChild(Circle c)
    {
        r = Radius / 2;
    }

    public double GetAreaChild()
    {
        return 2 * r * PI;
    }
}

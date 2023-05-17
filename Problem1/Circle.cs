namespace Problem1;
public class Circle : IArea
{
    public uint Radius { get; private set; }
    public double Area { get; protected set; }
    public Circle(uint radius)
    {
        Radius = radius;
        Area = Math.PI * Radius * Radius;
    }
    public double GetArea()
    {
        return Area;
    }
}

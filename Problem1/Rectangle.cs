using Problem1l;

namespace Problem1;
public class Rectangle : PolygonBase
{
    public uint Side_A { get; private set; }
    public uint Side_B { get; private set; }
    public Rectangle(uint a, uint b)
    {
        Side_A = a; Side_B = b;
        ComputePolygon();
    }

    protected override void CheckIfRegular()
    {
        IsRegular = true;
    }

    protected override void ComputeArea()
    {
        Area = Side_A * Side_B;
    }

    protected override void ComputePerimeter()
    {
        Perimeter = (Side_A + Side_B) * 2;
    }
    // This method may check if both sides are equal and return false.
    // Because they should use Square class (which should be created)
    protected override void IsValid()
    {
    }
}


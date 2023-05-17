using Problem1l;

namespace Problem1;
public class Triangle : PolygonBase
{
    public bool IsRightTriangle { get; private set; }
    public uint Side_A { get; private set; }
    public uint Side_B { get; private set; }
    public uint Side_C { get; private set; }
    public Triangle(uint a, uint b, uint c)
    {
        Side_A = a; Side_B = b; Side_C = c;
        ReArrangeSides();
        ComputePolygon();
        CheckIfRightTriangle();
    }
    private void CheckIfRightTriangle()
    {
        if (IsRegular) // regular triangles cannot be right triangles
        {
            return;
        }
        
        if (Side_A * Side_A + Side_B * Side_B == Side_C * Side_C)
        {
            IsRightTriangle = true;
        }
    }
    protected override void ComputeArea()
    {
        // half perimeter
        double p = Perimeter / 2;
        // Heron's formula
        double area = Math.Sqrt(p * (p - Side_A) * (p - Side_B) * (p - Side_C));
        Area = area;
    }

    protected override void CheckIfRegular()
    {
        if (Side_A == Side_B && Side_B == Side_C)
        {
            IsRegular = true;
        }
    }

    protected override void ComputePerimeter()
    {
        Perimeter = Side_A + Side_B + Side_C;
    }
    // Method should be called after ReArrangeSides() method.
    protected override void IsValid()
    {
        if (Side_A <= 0 || Side_B <= 0 || Side_C <= 0)
        {
            throw new ArgumentException("All sides' length should be greater than 0");
        }
        if (Side_A + Side_B <= Side_C)
        {
            throw new ArgumentException("Sum of two sides should be greater than third one");
        }
    }
    private void ReArrangeSides()
    {
        if (Side_A > Side_B)
        {
            var temp = Side_A;
            Side_A = Side_B;
            Side_B = temp;
        }
        if (Side_B > Side_C)
        {
            var temp = Side_B;
            Side_B = Side_C;
            Side_C = temp;
        }
        if (Side_A > Side_B)
        {
            var temp = Side_A;
            Side_A = Side_B;
            Side_B = temp;
        }
    }
}


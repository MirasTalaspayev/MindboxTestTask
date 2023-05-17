namespace Problem1;
public class Triangle : Polygon
{
    public bool IsRightTriangle { get; private set; }
    public Triangle(uint a, uint b, uint c) : base(a, b, c)
    {
        CheckIfRightTriangle();
    }
    private void CheckIfRightTriangle()
    {
        if (IsRegular) // regular triangles cannot be right triangles
        {
            return;
        }

        int index_hypotenuse = 0;
        if (Sides[0] < Sides[1])
        {
            index_hypotenuse = 1;
            if (Sides[1] < Sides[2])
            {
                index_hypotenuse = 2;
            }
        } 
        else
        {
            if (Sides[0] < Sides[2])
            {
                index_hypotenuse = 2;
            }
        }

        if (Sides[index_hypotenuse] * Sides[index_hypotenuse] == 
            Sides[(index_hypotenuse - 1) % 3] * Sides[(index_hypotenuse - 1) % 3] +
            Sides[(index_hypotenuse + 1) % 3] * Sides[(index_hypotenuse + 1) % 3])
        {
            IsRightTriangle = true;
        }
        return;
    }
    protected override void ComputeArea()
    {
        // half perimeter
        double p = Perimeter / 2;
        // Heron's formula
        double area = Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p - Sides[2]));
        Area = area;
    }
}


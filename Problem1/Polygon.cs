using Problem1l;

namespace Problem1;
// This is more like a test class
public class Polygon : PolygonBase
{
    public uint[] Sides { get; protected set; }
    public Polygon(params uint[] sides)
    {
        Sides = sides;
        ComputePolygon();
    }
    protected override void CheckIfRegular()
    {
        uint side = Sides[0];
        for (int i = 1; i < Sides.Length; i++)
        {
            if (Sides[i] != side)
            {
                return;
            }
        }
        IsRegular = true;
    }
    protected override void IsValid()
    {
        if (Sides.Length < 3) // A polygon must have at least 3 sides
        {
            throw new ArgumentException("The number of sides should be at least 3");
        }

        for (int i = 0; i < Sides.Length; i++)
        {
            if (Sides[i] <= 0) // Length of each side must be positive
            {
                throw new ArgumentException($"Side with index {i} should be positive");
            }

            uint sumOfOtherSides = 0;
            for (int j = 0; j < Sides.Length; j++)
            {
                if (i != j)
                {
                    sumOfOtherSides += Sides[j];
                }
            }

            if (Sides[i] >= sumOfOtherSides)
            {
                throw new ArgumentException("One side's length should be less than a sum of a other sides' lengths");
            }
        }
    }
    protected override void ComputePerimeter()
    {
        Perimeter = 0;
        for (int i = 0; i < Sides.Length; i++)
        {
            Perimeter += Sides[i];
        }
    }
    // Polygon could be calculated as several triangels, but for now I will leave it as empty
    protected override void ComputeArea()
    {
        
    }
}


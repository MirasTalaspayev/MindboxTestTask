namespace Problem1;
public abstract class Polygon : IArea
{
    public uint[] Sides { get; protected set; }
    public double Area { get; protected set; }
    public bool IsRegular { get; private set; }
    public uint Perimeter { get; private set; }
    protected Polygon(params uint[] sides)
    {
        Sides = sides;
        if (!IsValid())
        {
            throw new ArgumentException($"Provided values for {this.GetType().Name} are not valid.");
        }
        CheckIfRegular();
        ComputePerimeter();
        ComputeArea();
    }
    public double GetArea()
    {
        return Area;
    }
    // all new Polygons should override this function.
    protected abstract void ComputeArea();
    private void CheckIfRegular()
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
    private bool IsValid()
    {
        if (Sides.Length < 3) // A polygon must have at least 3 sides
        {
            return false;
        }

        for (int i = 0; i < Sides.Length; i++)
        {
            if (Sides[i] <= 0) // Length of each side must be positive
            {
                return false;
            }

            uint sumOfOtherSides = 0;
            for (int j = 0; j < Sides.Length; j++)
            {
                if (i != j)
                {
                    sumOfOtherSides += Sides[j];
                }
            }

            if (Sides[i] >= sumOfOtherSides) // Sum of any two sides must be greater than the third side
            {
                return false;
            }
        }

        return true; // All conditions are met, the polygon is valid
    }
    private void ComputePerimeter()
    {
        Perimeter = 0;
        for (int i = 0; i < Sides.Length; i++)
        {
            Perimeter += Sides[i];
        }
    }
}


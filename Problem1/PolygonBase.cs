using Problem1;

namespace Problem1l;
public abstract class PolygonBase : IArea
{
    public uint Perimeter { get; protected set; }
    public double Area { get; protected set; }
    public bool IsRegular { get; protected set; }
    public double GetArea()
    {
        return Area;
    }
    // All new Polygons should override this functions
    protected abstract void ComputePerimeter();
    protected abstract void ComputeArea();
    protected abstract void CheckIfRegular();
    protected abstract void IsValid();
    // This method should be called in every constructor
    protected void ComputePolygon()
    {
        IsValid();
        CheckIfRegular();
        ComputePerimeter();
        ComputeArea();
    }
}


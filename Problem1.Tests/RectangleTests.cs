namespace Problem1.Tests;
internal class RectangleTests
{
    [Test]
    public void Area_Correct_Test()
    {
        var rect = new Rectangle(3, 4);
        Assert.AreEqual(rect.Area, 12);
    }
    [Test]
    public void Area_Wrong_Test()
    {
        var rect = new Rectangle(3, 4);
        Assert.AreNotEqual(rect.Area, 6);
    }
    [Test]
    public void Perimeter_Correct_Test()
    {
        var rect = new Rectangle(3, 4);
        Assert.AreEqual(rect.Perimeter, 14);
    }
    [Test]
    public void IsRegular_True_Test()
    {
        var rect = new Rectangle(4, 4);
        Assert.IsTrue(rect.IsRegular);
    }
}


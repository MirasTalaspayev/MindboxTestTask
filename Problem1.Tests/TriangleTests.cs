namespace Problem1.Tests;
internal class TriangleTests
{
    [Test]
    public void Triangle_CorrectPerimeter_Test()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.AreEqual(triangle.Perimeter, 12);
    }
    [Test]
    public void Triangle_CorrectArea_Test()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.AreEqual(triangle.Area, 6);
    }
    [Test]
    public void Triangle_WrongPerimeter_Test()
    {
        var triangle = new Triangle(2, 2, 3);
        Assert.AreNotEqual(triangle.Perimeter, 6);
    }
    [Test]
    public void Triangle_Regular_Test()
    {
        var triangle = new Triangle(1, 1, 1);
        Assert.IsTrue(triangle.IsRegular);
    }
    [Test]
    public void Triangle_RightTriangle_Test()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.IsTrue(triangle.IsRightTriangle);
    }
    [Test]
    public void Triangle_NotRightTriangle_Test()
    {
        var triangle = new Triangle(3, 4, 4);
        Assert.IsFalse(triangle.IsRightTriangle);
    }
    [Test]
    public void CorrectReArrangeSides()
    {
        var triangle = new Triangle(10, 4, 7);
        Assert.AreEqual(triangle.Side_A, 4);
        Assert.AreEqual(triangle.Side_B, 7);
        Assert.AreEqual(triangle.Side_C, 10);
    }
    [Test]
    public void ThrowsException_NotValid_SumOfTwoSidesLessThanThird_Test()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            var triangle = new Triangle(2, 2, 4);
        });
    }
    [Test]
    public void ThrowsException_NotValid_ArgumentIsZero_Test()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            var triangle = new Triangle(0, 2, 1);
        });
    }
}


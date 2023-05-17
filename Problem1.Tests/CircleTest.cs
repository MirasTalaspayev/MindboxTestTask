namespace Problem1.Tests;
internal class CircleTest
{
    [Test]
    public void Area_Correct_Test()
    {
        var area = new Circle(4);
        Assert.AreEqual(Math.PI * 16, area.Area);
    }
}


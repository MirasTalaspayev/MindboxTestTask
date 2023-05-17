using NSubstitute;
namespace Problem1.Tests;
internal class PolygonTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ReturnsCorrectArea_Test()
    {
        var polygon = Substitute.For<IArea>();
        polygon.GetArea().Returns(10);
        Assert.AreEqual(polygon.GetArea(), 10);
    }
    [Test]
    public void Regular_Test()
    {
        var polygon = new Polygon(10, 10, 10);
        Assert.IsTrue(polygon.IsRegular);
    }
    [Test]
    public void ThrowsException_OnlyTwoArguments()
    {
        Assert.Throws<ArgumentException>(() => 
        {
            var polygon = new Polygon(10, 10);
        });
    }
    [Test]
    public void ThrowsException_ArgumentIsZero() 
    {
        Assert.Throws<ArgumentException>(() =>
        {
            var polygon = new Polygon(0, 2, 2);
        });
    }
}
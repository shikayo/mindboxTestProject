using System;
using NUnit.Framework;
using SquareLib.Classes;

namespace SquareTests;

public class CircleTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ZeroRTest()
    {
        Assert.Catch<ArgumentException>(() => new Circle(0));
    }

    [Test]
    public void BelowZeroRTest()
    {
        Assert.Catch<ArgumentException>(() => new Circle(-3));
    }

    [Test]
    public void SquareTest()
    {
        //arrange
        var r = 5;
        var c = new Circle(r);
        var result = Math.PI * Math.Pow(r, 2);
        
        //act
        var square = c.CalculateSquare();
        
        //assert
        Assert.AreEqual(result,square);
    }
}
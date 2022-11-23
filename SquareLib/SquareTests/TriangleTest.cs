using System;
using NUnit.Framework;
using SquareLib.Classes;

namespace SquareTests;

public class TriangleTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void WrongTriangleTest()
    {
        //arrange
        double x1 = -3, y1 = 2, z1 = 3;
        double x2 = 3, y2 = -2, z2 = 3;
        double x3 = 3, y3 = 2, z3 = -3;
        double x4 = 0, y4 = 0, z4 = 0;
        
        //act

        //assert
        Assert.Catch<ArgumentException>(() => new Triangle(x1, y1, z1));
        Assert.Catch<ArgumentException>(() => new Triangle(x2, y2, z2));
        Assert.Catch<ArgumentException>(() => new Triangle(x3, y3, z3));
        Assert.Catch<ArgumentException>(() => new Triangle(x4, y4, z4));
    }

    [Test]
    public void NotTriangleTest()
    {
        double x = 2, y = 2, z = 6;

        Assert.Catch<ArgumentException>(() => new Triangle(x, y, z));
    }

    [Test]
    public void CreateTest()
    {
        //arrange
        double x = 3, y = 4, z = 5;
        
        //act
        var t = new Triangle(x, y, z);
        
        //assert
        Assert.AreEqual(x,t.SideA);
        Assert.AreEqual(y,t.SideB);
        Assert.AreEqual(z,t.SideC);
    }

    [Test]
    public void IsTriangleRightTest()
    {
        //arrange
        double x1 = 3, y1 = 4, z1 = 5;
        var exp1 = true;
        var t1 = new Triangle(x1, y1, z1);

        double x2 = 2, y2 = 2, z2 = 3;
        var exp2 = false;
        var t2 = new Triangle(x2, y2, z2);
        
        //act
        var res1 = t1.IsTriangleRight;
        var res2 = t2.IsTriangleRight;
        
        //assert
        Assert.AreEqual(exp1,res1);
        Assert.AreEqual(exp2,res2);
    }

    [Test]
    public void SquareTest()
    {
        //arrange
        double x = 3, y = 4, z = 5;
        double res = 6;
        var t = new Triangle(x, y, z);
        
        //act
        var S = t.CalculateSquare();
        
        //assert
        Assert.AreEqual(res,S);
    }
    
}
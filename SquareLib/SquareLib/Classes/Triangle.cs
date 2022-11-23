using SquareLib.Interfaces;

namespace SquareLib.Classes;

public class Triangle : ITriangle
{
    private const double CalcAcc = 1e-7;
    private readonly Lazy<bool> _isTriangleRight;
    public bool IsTriangleRight
    {
        get => _isTriangleRight.Value;
        set => throw new NotImplementedException();
    }

    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }
    

    public Triangle(double sideA,double sideB,double sideC)
    {
        if (sideA < CalcAcc || sideB < CalcAcc || sideC < CalcAcc)
        {
            throw new ArgumentException("some side was wrong");
        }

        var largestSide = Math.Max(sideA, Math.Max(sideB, sideC));
        var P = sideA + sideB + sideC;

        if ((P - largestSide) - largestSide < CalcAcc)
        {
            throw new ArgumentException(
                "The largest side of the triangle must be less than the sum of the other sides");
        }

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;

        _isTriangleRight = new Lazy<bool>(CheckIsRight);

    }
    
    public double CalculateSquare()
    {
        var P = (SideA + SideB + SideC) / 2d;
        var S = Math.Sqrt(P * (P - SideA) * (P - SideB) * (P - SideC));
        return S;
    }

    public bool CheckIsRight()
    {
        var sideA = SideA;
        var sideB = SideB;
        var sideC = SideC;
        double box;

        if (sideB - sideA > CalcAcc)
        {
            box = sideB;
            sideB = sideA;
            sideA = box;
        }
        
        if (sideC - sideA > CalcAcc)
        {
            box = sideC;
            sideC = sideA;
            sideA = box;
        }

        return Math.Abs(Math.Pow(sideA, 2) - Math.Pow(sideB, 2) - Math.Pow(sideC, 2)) == 0;
    }
}
using SquareLib.Interfaces;

namespace SquareLib.Classes;

public class Circle : IFigure
{
    private const double MinimumR = 1e-6;
    private const double CalcAcc = 1e-7;
    public double Radius { get; set; }

    public Circle(double r)
    {
        if (r - MinimumR < CalcAcc)
        {
            throw new ArgumentException("wrong radius");
        }

        Radius = r;
    }
    
    public double CalculateSquare()
    {
        return Math.PI * Math.Pow(Radius, 2d);
    }
}
using MyMath.Abstractions;
using System.Collections.Generic;

namespace MyMath
{
    public static class Area
    {
        public static double GetArea<T>(T figure) where T : IFigure
        {           
            return figure.GetArea();
        }

    }
}
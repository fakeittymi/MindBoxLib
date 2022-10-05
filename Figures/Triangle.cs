using MyMath.Abstractions;

namespace MyMath.Figures
{
    public class Triangle: IFigure
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        // Формула Герона
        public double GetArea()
        {
            if (Side1 + Side2 <= Side3 || Side2 + Side3 <= Side1 || Side1 + Side3 <= Side2)
                throw new ArgumentException("Incorrectly initialized triangle. In a triangle, the sum of any two sides must be greater than the third");

            var p = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }

        // Через основание и высоту
        //public double GetArea(double basis, double height)
        //{
        //    if (basis <= 0 || height <= 0)
        //        throw new ArgumentException("Incorrectly initialized triangle. Values cannot be less than or equal to zero");

        //    return (basis * height) / 2;
        //}

        // Проверка на прямой угол
        public bool IsRight()
        {
            if (Side1 + Side2 <= Side3 || Side2 + Side3 <= Side1 || Side1 + Side3 <= Side2)
                throw new ArgumentException("Incorrectly initialized triangle. In a triangle, the sum of any two sides must be greater than the third");

            var orderedSides = new[] { Side1, Side2, Side3 }.OrderBy(p => p).ToList();

            return Math.Pow(orderedSides[2], 2) == Math.Pow(orderedSides[0], 2) + Math.Pow(orderedSides[1], 2);
        }


    }
}

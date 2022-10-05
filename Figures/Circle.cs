using MyMath.Abstractions;


namespace MyMath.Figures
{
    public class Circle: IFigure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            if (Radius < 0)
                throw new ArgumentException("Incorrectly initialized circle radius. Radius cannot be less than zero");

            return Math.PI * Radius * Radius;
        }
    }
}

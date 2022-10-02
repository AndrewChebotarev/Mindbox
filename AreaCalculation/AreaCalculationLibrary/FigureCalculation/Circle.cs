namespace AreaCalculationLibrary.FigureCalculation
{
    public class Circle : Calculation
    {
        private double radius;
        private double area;

        private bool IsPositiveValue;

        public Circle(double radius) => this.radius = radius;

        public override void AreaCalculation()
        {
            CheckPositiveValue();
            area = Math.PI * Math.Pow(radius, 2);
        }

        private void CheckPositiveValue()
        {
            if (radius > 0)
                IsPositiveValue = true;
            else
            {
                area = 0;
                IsPositiveValue = false;
            }
        }

        public override void Result()
        {
            if (IsPositiveValue)
                Console.WriteLine($"The area of ​​the circle is: {area}");
            else
                Console.WriteLine($"This circle does not exist");
        }

        public override double ResultReturn()
        {
            return area;
        }
    }
}

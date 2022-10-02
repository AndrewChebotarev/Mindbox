namespace AreaCalculationLibrary.FigureCalculatorCreator
{
    public class CircleCalculator : CalculatorCreate
    {
        private double radius;
        public CircleCalculator(double radius) => this.radius = radius;
        public override Calculation Create() => new Circle(radius);
    }
}

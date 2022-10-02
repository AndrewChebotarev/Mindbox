namespace AreaCalculationLibrary.FigureCalculatorCreator
{
    public class TriangleCalculator : CalculatorCreate
    {
        private double firstSide;
        private double secondSide;
        private double thirdSide;

        public TriangleCalculator(double firstSide, double secondSide, double thirdSide)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;
        }

        public override Calculation Create() => new Triangle(firstSide, secondSide, thirdSide);
    }
}

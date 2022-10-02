namespace UintTestApp.Tests
{
    public class UnitTestsAreaCalculationTriangle
    {
        private double[] massFirstSide = new double[10];
        private double[] massSecondSide = new double[10];
        private double[] massThirdSide = new double[10];

        private double[] massArea = new double[10];

        Random rnd = new Random();

        [Fact]
        public void Index()
        {
            ArrayFillingFirstSide();
            ArrayFillingSecondSide();
            ArrayFillingThirdSide();

            СalculationAreaCircle();

            for (int i = 0; i < 10; i++)
            {
                CalculatorCreate calculator = new TriangleCalculator(massFirstSide[i], massSecondSide[i], massThirdSide[i]);
                Calculation calculation = calculator.Create();
                calculation.AreaCalculation();
                var result = calculation.ResultReturn();

                Assert.Equal(massArea[i], result);
            }
        }

        private void ArrayFillingFirstSide()
        {
            for (int i = 0; i < 10; i++)
            {
                massFirstSide[i] = rnd.Next(-10, 100);
            }
        }
        private void ArrayFillingSecondSide()
        {
            for (int i = 0; i < 10; i++)
            {
                massSecondSide[i] = rnd.Next(-10, 100);
            }
        }
        private void ArrayFillingThirdSide()
        {
            for (int i = 0; i < 10; i++)
            {
                massThirdSide[i] = rnd.Next(-10, 100);
            }
        }
        private void СalculationAreaCircle()
        {
            for (int i = 0; i < 10; i++)
            {
                var semiPerimeter = (massFirstSide[i] + massSecondSide[i] + massThirdSide[i]) / 2;
                massArea[i] = Math.Sqrt(semiPerimeter * (semiPerimeter - massFirstSide[i]) * (semiPerimeter - massSecondSide[i]) * (semiPerimeter - massThirdSide[i]));
            }
        }
    }
}

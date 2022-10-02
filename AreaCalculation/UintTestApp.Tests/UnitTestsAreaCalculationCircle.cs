namespace UintTestApp.Tests
{
    public class UnitTestsAreaCalculationCircle
    {
        private double[] massRadius = new double[10];
        private double[] massArea = new double[10];

        Random rnd = new Random();

        [Fact]
        public void Index()
        {
            ArrayFillingRadius();
            СalculationAreaCircle();

            for (int i = 0; i < 10; i++)
            {
                CalculatorCreate calculator = new CircleCalculator(massRadius[i]);
                Calculation calculation = calculator.Create();
                calculation.AreaCalculation();
                var result = calculation.ResultReturn();

                Assert.Equal(massArea[i], result);
            }
        }

        private void ArrayFillingRadius()
        {
            for(int i = 0; i < 10; i++)
            {
                massRadius[i] = rnd.Next(-10, 100);
            }
        }
        private void СalculationAreaCircle()
        {
            for (int i = 0; i < 10; i++)
            {
                massArea[i] = Math.PI * Math.Pow(massRadius[i], 2);
            }
        }
    }
}
namespace ConsoleApp
{
    public class ProgramMain
    {
        public static void Main()
        {
            ProgramMain programMain = new();
            Validation validation = new();

            programMain.SelectionTextOutput();

            var figure = Console.ReadLine();

            figure = validation.ValidationNameFigure(figure);

            if (figure == "circle")
            {
                var radius = programMain.GettingCircleData();
                programMain.ResultCircleArea(radius);
            }

            if (figure == "triangle")
            {
                var massSides = programMain.GettingTriangleData();
                programMain.ResultTriangleArea(massSides);
            }
        }

        private void SelectionTextOutput()
        {
            Console.WriteLine("What area do you want to calculate?");
            Console.WriteLine("If it's a circle, then print \"circle\". If it's a triangle, then print \"triangle\".");
        }

        private void ResultCircleArea(double radius)
        {
            CalculatorCreate calculator = new CircleCalculator(radius);
            Calculation calculation = calculator.Create();
            calculation.AreaCalculation();
            calculation.Result();
        }
        private double GettingCircleData()
        {
            Console.WriteLine("Enter what the radius is");

            try {
                var raduis = Convert.ToDouble(Console.ReadLine());
                return raduis;
            }
            catch
            {
                Console.WriteLine("Invalid input. Enter a number for the radius.");
                var raduis = Convert.ToDouble(Console.ReadLine());
                return raduis;
            }
        }

        private void ResultTriangleArea(double[] massSides)
        {
            CalculatorCreate calculator = new TriangleCalculator(massSides[0], massSides[1], massSides[2]);
            Calculation calculation = calculator.Create();
            calculation.AreaCalculation();
            calculation.Result();
        }
        private double[] GettingTriangleData()
        {
            try
            {
                Console.WriteLine("Enter what the first side is");
                var firstSide = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter what the second side is");
                var secondSide = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter what the thied side is");
                var thirdSide = Convert.ToDouble(Console.ReadLine());

                double[] massSides = new double[3];

                massSides[0] = firstSide;
                massSides[1] = secondSide;
                massSides[2] = thirdSide;

                return massSides;
            }
            catch
            {
                Console.WriteLine("Invalid input. Enter a number for the radius. Start over.");
                return new double[3] {0, 0, 0};
            }
        }

    }
}
namespace AreaCalculationLibrary.FigureCalculation
{
    public class Triangle : Calculation
    {
        private double firstSide;
        private double secondSide;
        private double thirdSide;

        private double area;
        private double semiPerimeter;

        private bool IsRectangular;
        private bool IsExists;

        private List<double> ListSides = new List<double>();

        public Triangle(double firstSide,double secondSide, double thirdSide)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;

            ListSides.Add(firstSide);
            ListSides.Add(secondSide);
            ListSides.Add(thirdSide);
        }

        public override void AreaCalculation()
        {
            CheckForSquareness();

            semiPerimeteCalculation();

            area = Math.Sqrt(semiPerimeter * (semiPerimeter - firstSide) * (semiPerimeter - secondSide) * (semiPerimeter - thirdSide));
        }
        private void CheckForSquareness()
        {
            var putativeHypotenuse = ListSides.Max();
            ListSides.Remove(putativeHypotenuse);

            var firstSideForCheck = ListSides.FirstOrDefault();
            var secondSideForCheck = ListSides.LastOrDefault();

            CheckExists(putativeHypotenuse, firstSideForCheck, secondSideForCheck);

            var result = PythagoreanTheorem(putativeHypotenuse, firstSideForCheck, secondSideForCheck);

            IsRectangular = result;
        }
        private void CheckExists(double putativeHypotenuse, double firstSideForCheck, double secondSideForCheck)
        {
            if (putativeHypotenuse < (firstSideForCheck + secondSideForCheck))
                IsExists = true;

            else
            {
                area = 0;
                IsExists = false;
            }
        }
        private bool PythagoreanTheorem(double putativeHypotenuse, double firstSideForCheck, double secondSideForCheck)
        {
            var hypotenuseSquared = Math.Pow(putativeHypotenuse, 2);
            var firstSideSquared = Math.Pow(firstSideForCheck, 2);
            var secondSideSquared = Math.Pow(secondSideForCheck, 2);

            if (hypotenuseSquared == (firstSideSquared + secondSideSquared))
                return true;

            else
                return false;
        }
        private void semiPerimeteCalculation()
        {
            semiPerimeter = (firstSide + secondSide + thirdSide) / 2;
        }

        public override void Result()
        {
            if (IsExists == false)
                Console.WriteLine("This rectangle does not exist.");
            else
            {
                if (IsRectangular)
                    Console.WriteLine($"This triangle is a right triangle. The area of ​​the triangle is: {area}");

                else
                    Console.WriteLine($"This triangle is not a right triangle. The area of ​​the triangle is: {area}");
            }
        }

        public override double ResultReturn()
        {
            return area;
        }
    }
}

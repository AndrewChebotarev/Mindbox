namespace ConsoleApp
{
    public class Validation
    {
        public string ValidationNameFigure(string figure)
        {
            while (figure != "circle" && figure != "triangle")
            {
                Console.WriteLine($"Invalid input. Choose \"circle\" or \"triangle\".");

                figure = Console.ReadLine();
            }
            return figure;
        }
    }
}

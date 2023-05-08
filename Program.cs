using System;

namespace MarsRover
{
    internal static class Program
    {

        private static void Main()
        {
            Console.WriteLine("Input the plateau grid size, e.g. 5 5");
            var gridsize =  Console.ReadLine();

            Console.WriteLine("Input 1st rover coordinates and starting direction, e.g. 1 2 N");
            var roverOneStart = Console.ReadLine();

            Console.WriteLine("Input 1st rover movement instructions, e.g. LMLMLMLMM");
            var roverOneMovements = Console.ReadLine();

            Console.WriteLine("Input 2nd rover coordinates and starting direction, e.g. 3 3 E");
            var roverTwoStart = Console.ReadLine();

            Console.WriteLine("Input 2nd rover movement instructions, e.g. MMRMMRMRRM");
            var roverTwoMovements = Console.ReadLine();

            var input = $"{gridsize}{System.Environment.NewLine}" +
                $"{roverOneStart}{System.Environment.NewLine}" +
                $"{roverOneMovements}{System.Environment.NewLine}" +
                $"{roverTwoStart}{System.Environment.NewLine}" +
                $"{roverTwoMovements}{System.Environment.NewLine}";

            var reader = new InputReader(input);

            Console.ReadLine();
        }
    }
}
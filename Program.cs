using System;

namespace MarsRover
{
    internal static class Program
    {

        private static void Main()
        {
            Console.WriteLine("Input the plateau grid size, e.g. 5 5");
            var lineOne =  Console.ReadLine();

            Console.WriteLine("Input 1st rover coordinates and starting direction, e.g. 1 2 N");
            var lineTwo = Console.ReadLine();

            Console.WriteLine("Input 1st rover movement instructions, e.g. LMLMLMLMM");
            var lineThree = Console.ReadLine();

            Console.WriteLine("Input 2nd rover coordinates and starting direction, e.g. 3 3 E");
            var lineFour = Console.ReadLine();

            Console.WriteLine("Input 2nd rover movement instructions, e.g. MMRMMRMRRM");
            var lineFive = Console.ReadLine();

            var input = $"{lineOne}{System.Environment.NewLine}" +
                $"{lineTwo}{System.Environment.NewLine}" +
                $"{lineThree}{System.Environment.NewLine}" +
                $"{lineFour}{System.Environment.NewLine}" +
                $"{lineFive}{System.Environment.NewLine}";

            var reader = new InputReader(input);

            Console.ReadLine();
        }
    }
}
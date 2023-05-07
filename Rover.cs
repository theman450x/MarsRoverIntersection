using System;
using System.Security.Cryptography.X509Certificates;

namespace MarsRover
{
    public class Rover
    {
        private Coordinate Position { get; set; } = new Coordinate();
        private string Facing { get; set; }
        public List<Coordinate> Path { get; private set; } = new List<Coordinate>();

        public Rover(string inputCoordinates, string inputCommands, Plateau plateau)
        {
            var coordinates = inputCoordinates.Split(' ');
            var commands = inputCommands.ToCharArray();
            var rotationCommands = new char[]{'L', 'R'};

            Position.XCoordinate = int.Parse(coordinates[0]);
            Position.YCoordinate = int.Parse(coordinates[1]);
            Facing = coordinates[2];

            if (!IsRoverInPlateau(plateau))
            {
                Console.WriteLine("Rover is not in plateau.");

                return;
            }

            //"M" - move rover
            //"L" or "R" - rotate rover
            foreach (var command in commands)
            {
                if (command.Equals('M'))
                {
                    MoveRover();

                    //Newing coordinate to prevent unwanted references
                    Path.Add(new Coordinate(Position.XCoordinate, Position.YCoordinate));
                }
                else if (rotationCommands.Contains(command))    
                {
                    RotateRover(command);
                }

            }
            
            Console.WriteLine("Rover ends at: " + Position.XCoordinate + " " + Position.YCoordinate + " " + Facing);
        }
        
        private void MoveRover()
        {
            switch (Facing)
            {
                case "N":
                    Position.YCoordinate += 1;
                    break;
                case "W":
                    Position.XCoordinate -= 1;
                    break;
                case "S":
                    Position.YCoordinate -= 1;
                    break;
                case "E":
                    Position.XCoordinate += 1;
                    break;
            }
        }
        
        private void RotateRover(char direction)
        {
            if (Char.ToUpper(direction).Equals('L'))
            {
                TurnRoverLeft();
            }
            else if (Char.ToUpper(direction).Equals('R'))
            {
                TurnRoverRight();
            }
            else
            {
                Console.WriteLine("Cannot read a command.");
            }
        }
        
        private bool IsRoverInPlateau(Plateau plateau)
        {
            return Position.XCoordinate >= 0 &&
                   Position.XCoordinate <= plateau.PlateauWidth &&
                   Position.YCoordinate >= 0 &&
                   Position.YCoordinate <= plateau.PlateauHeight;
        }
        
        private void TurnRoverLeft()
        {
            switch (Facing)
            {
                case "N":
                    Facing = "W";
                    break;
                case "W":
                    Facing = "S";
                    break;
                case "S":
                    Facing = "E";
                    break;
                case "E":
                    Facing = "N";
                    break;
            }
        }
        
        private void TurnRoverRight()
        {
            switch (Facing)
            {
                case "N":
                    Facing = "E";
                    break;
                case "E":
                    Facing = "S";
                    break;
                case "S":
                    Facing = "W";
                    break;
                case "W":
                    Facing = "N";
                    break;
            }
        }
    }
}
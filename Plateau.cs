namespace MarsRover
{
    public class Plateau
    {
        public int PlateauWidth { get; }
        public int PlateauHeight { get; }

        public Plateau(string plateauCoordinates)
        {
            var coordinates = plateauCoordinates.Split(' ');

            PlateauWidth = int.Parse(coordinates[0]);
            PlateauHeight = int.Parse(coordinates[1]);
        }
    }
}
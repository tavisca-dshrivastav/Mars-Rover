using System.Collections.Generic;

namespace MarsRover
{
    public class Map
    {
        public Map(SurfaceCordinate currentPosition, SurfaceCordinate lastValidPosition)
        {
            CurrentPosition = currentPosition;
            LastValidPosition = lastValidPosition;
        }

        public SurfaceCordinate CurrentPosition { get; private set; }
        public SurfaceCordinate LastValidPosition { get; private set; }
        public void UpdateCurrentPosition(int xCordinate, int yCordinate)
        {
            CurrentPosition = new SurfaceCordinate(
                CurrentPosition.XCordinate + xCordinate,
                CurrentPosition.YCordinate + yCordinate
                );
        }
        public bool isValidMove(Dictionary<string, List<int>> moveForwardData, string currentDirection)
        {
            if (((moveForwardData[currentDirection][0] + CurrentPosition.XCordinate > LastValidPosition.XCordinate)
                && (moveForwardData[currentDirection][0] + CurrentPosition.XCordinate < 0)))
                return false;

            if (((moveForwardData[currentDirection][1] + CurrentPosition.YCordinate > LastValidPosition.YCordinate)
                            && (moveForwardData[currentDirection][1] + CurrentPosition.YCordinate < 0)))
                return false;
            return true;
        }

    }
}

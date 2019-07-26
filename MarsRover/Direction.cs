using System.Collections.Generic;

namespace MarsRover
{
    public class Direction
    {
        public Direction(string currentDirection)
        {
            CurrentDirection = currentDirection;
            MoveLeftDirection = new Dictionary<string, string>()
            {
                { "N", "NW" },
                { "W", "SW" },
                { "S", "SE" },
                { "E", "NE" },
                { "NW", "W" },
                { "NE", "N" },
                { "SW", "S" },
                { "SE", "E" },
            };
            MoveRightDirection = new Dictionary<string, string>()
            {
                { "N", "NE" },
                { "W", "NW" },
                { "S", "SW" },
                { "E", "SE" },
                { "NW", "N" },
                { "NE", "E" },
                { "SW", "W" },
                { "SE", "S" },

            };
            MoveForward = new Dictionary<string, List<int>>()
            {
                { "N", new List<int>{0, 1} },
                { "E", new List<int>{1, 0} },
                { "S", new List<int>{0, -1} },
                { "W", new List<int>{-1, 0} },
                { "NW", new List<int>{-1, 1} },
                { "NE", new List<int>{1, 1} },
                { "SW", new List<int>{-1, -1} },
                { "SE", new List<int>{1, -1} },
            };
        }
        public Dictionary<string, string> MoveLeftDirection { get; private set; }
        public Dictionary<string, string> MoveRightDirection { get; private set; }
        public Dictionary<string, List<int>> MoveForward { get; private set; }
        public string CurrentDirection { get; private set; }      
        public void OnMoveLeft()
        {
            CurrentDirection = MoveLeftDirection[CurrentDirection];
        }
        public void OnMoveRight()
        {
            CurrentDirection = MoveRightDirection[CurrentDirection];
        }
        public void OnMoveForward(Map map)
        {
            if (map.isValidMove(MoveForward, CurrentDirection) == false)
                return;
            map.UpdateCurrentPosition(MoveForward[CurrentDirection][0], MoveForward[CurrentDirection][1]);
        }
    }
}

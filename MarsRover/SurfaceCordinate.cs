using System;
using System.Collections.Generic;

namespace MarsRover
{
    public class SurfaceCordinate
    {
        public SurfaceCordinate(int xCordinate, int yCordinate)
        {
            XCordinate = xCordinate;
            YCordinate = yCordinate;
        }

        public int XCordinate { get; private set; }
        public int YCordinate { get; private set; }
        
    }
    public class Direction
    {
        public Direction(string currentDirection)
        {
            CurrentDirection = currentDirection;
            MoveLeftDirection = new Dictionary<string, string>()
            {
                { "N", "W" },
                { "W", "S" },
                { "S", "E" },
                { "E", "N" }
            };
            MoveRightDirection = new Dictionary<string, string>()
            {
                { "N", "E" },
                { "W", "N" },
                { "S", "W" },
                { "E", "S" }
            };
            MoveForward = new Dictionary<string, List<int>>()
            {
                { "N", new List<int>{0, 1} },
                { "E", new List<int>{1, 0} },
                { "S", new List<int>{0, -1} },
                { "W", new List<int>{-1, 0} },

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
            map.UpdateCurrentPosition(MoveForward[CurrentDirection][0], MoveForward[CurrentDirection][1]);
        }
    }
}

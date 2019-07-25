using System;

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
}

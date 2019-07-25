using System.Collections.Generic;

namespace MarsRover
{
    public class Helper
    {
        public string ProcessInput(List<string> input)
        {
            //token1 is in format of {Max_X Max_Y}
            var token1 = input[0].Split(' ');
            var lastValidPosition = new SurfaceCordinate(int.Parse(token1[0]), int.Parse(token1[1]));

            //token2 is in format of {current_x current_y direction}
            var token2 = input[1].Split(' ');
            var currentPosition = new SurfaceCordinate(int.Parse(token2[0]), int.Parse(token2[1]));

            var direction = new Direction(token2[2]);
            var map = new Map(currentPosition, lastValidPosition);

            //token3 is a string of instruction 
            //e.g. LLFFLL
            var token3 = input[2];
            var rover = new Rover(map, direction);


            return rover.ExecuteInstruction(token3);


        }
    }
}

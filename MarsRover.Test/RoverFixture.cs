using FluentAssertions;
using Xunit;

namespace MarsRover.Test
{
    public class RoverFixture
    {
        [Fact]
        public void Rover_should_have_map_and_direction_and_execute_instruction()
        {
            var map = new Map(new SurfaceCordinate(2, 4), new SurfaceCordinate(5, 5));
            var direction = new Direction("N");
            var rover = new Rover(map, direction);
            rover.ExecuteInstruction("LLRF").Should().Be("1 5 NW");
        }
    }
}

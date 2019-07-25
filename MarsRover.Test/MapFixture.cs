using FluentAssertions;
using Xunit;

namespace MarsRover.Test
{
    public class MapFixture
    {
        private Map _map;
        [Fact]
        public void Map_should_have_current_position_and_last_valid_position()
        {
            SurfaceCordinate currentPosition = new SurfaceCordinate(1, 2);
            SurfaceCordinate lastValidPosition = new SurfaceCordinate(5, 5);
            _map = new Map(currentPosition, lastValidPosition);
            _map.CurrentPosition.Should().Equals(currentPosition);
            _map.LastValidPosition.Should().Equals(lastValidPosition);
            
        }
        [Fact]
        public void Map_should_update_current_position()
        {
            SurfaceCordinate currentPosition = new SurfaceCordinate(1, 2);
            SurfaceCordinate lastValidPosition = new SurfaceCordinate(5, 5);
            _map = new Map(currentPosition, lastValidPosition);
            _map.UpdateCurrentPosition(0, 1);
            _map.CurrentPosition.XCordinate.Should().Be(1);
            _map.CurrentPosition.YCordinate.Should().Be(3);
            
        }
    }
}

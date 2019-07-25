using FluentAssertions;
using System.Collections.Generic;
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
        [Fact]
        public void Map_should_check_moves_validity_when_move_not_possible()
        {
            var moveForwardData = new Dictionary<string, List<int>>()
            {
                { "N", new List<int>{0, 1} },
                { "S", new List<int>{0, -1} },
                { "E", new List<int>{1, 0} },
                { "W", new List<int>{-1, 0} },

            };
            _map = new Map(new SurfaceCordinate(2, 5), new SurfaceCordinate(5, 5));
            var currentDirection = "N";
            _map.isValidMove(moveForwardData, currentDirection).Should().BeFalse();
        }
        [Fact]
        public void Map_should_check_moves_validity_when_move_is_possible()
        {
            var moveForwardData = new Dictionary<string, List<int>>()
            {
                { "N", new List<int>{0, 1} },
                { "S", new List<int>{0, -1} },
                { "E", new List<int>{1, 0} },
                { "W", new List<int>{-1, 0} },

            };
            _map = new Map(new SurfaceCordinate(2, 4), new SurfaceCordinate(5, 5));
            var currentDirection = "N";
            _map.isValidMove(moveForwardData, currentDirection).Should().BeTrue();
        }
    }
}

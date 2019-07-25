using FluentAssertions;
using System;
using Xunit;

namespace MarsRover.Test
{
    public class SurfaceCordinateFixture
    {
        private SurfaceCordinate _surfaceCordinate;
        [Fact]
        public void Surface_cordinate_should_add_cordinate()
        {
            _surfaceCordinate = new SurfaceCordinate(4, 5);
            _surfaceCordinate.XCordinate.Should().Be(4);
            _surfaceCordinate.YCordinate.Should().Be(5);
        }
    }
    public class DirectionFixture
    {
        private Direction _direction;
        [Fact]
        public void Direction_should_have_current_direction()
        {
            _direction = new Direction("N");
            _direction.CurrentDirection.Should().Be("N");
        }
        
        [Fact]
        public void Direction_should_have_OnMoveLeft()
        {
            _direction = new Direction("N");
            _direction.OnMoveLeft();
            _direction.CurrentDirection.Should().Be("W");
        }
        [Fact]
        public void Direction_should_have_OnMoveRight()
        {
            _direction = new Direction("N");
            _direction.OnMoveRight();
            _direction.CurrentDirection.Should().Be("E");
        }
        [Fact]
        public void Direction_should_have_OnForward()
        {
            Map map = new Map(new SurfaceCordinate(1, 2), new SurfaceCordinate(5, 5));
            _direction = new Direction("N");
            _direction.OnMoveRight();
            _direction.OnMoveForward(map);
            map.CurrentPosition.XCordinate.Should().Be(2);
            map.CurrentPosition.YCordinate.Should().Be(2);
        }
    }
}

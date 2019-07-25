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
}

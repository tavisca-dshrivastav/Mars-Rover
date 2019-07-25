using FluentAssertions;
using System;
using System.Collections.Generic;
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
    public class MarsRoverFixture
    {
        [Fact]
        public void Test_on_actual_input()
        {
            List<string> input = new List<string>
            {
                "5 5",
                "1 2 N",
                "LFLFLFLFF"
            };
            var helper = new Helper();
            helper.ProcessInput(input).Should().Be("1 3 N");
        }
    }
}

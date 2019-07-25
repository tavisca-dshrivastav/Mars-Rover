using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace MarsRover.Test
{
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

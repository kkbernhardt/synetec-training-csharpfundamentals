using System;
using TestTime;
using Xunit;

namespace TestTimeTests
{
    public class UnitTestsForTestTime
    {
        [Fact]
        public void ShouldGiveBackMinutesValueOfStruct()
        {
            Time testTime = new Time(5, 10);

            Assert.Equal(310, testTime.minutes);
        }
    }
}

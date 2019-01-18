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

        [Fact]
        public void ShouldGiveBackMinutesValueOfClass()
        {
            Time2 testTime2 = new Time2(4, 100);
            Assert.Equal(340, testTime2.minutes);
        }


    }
}

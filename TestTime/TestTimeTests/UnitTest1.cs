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

        [Fact]
        public void ShouldStructValueVariableDoesNotChangeAfterAssignedANewValue()
        {
            Time t1 = new Time(9, 30);
            Time t2 = t1;
            t1.minutes = 100;
            Assert.NotEqual(100, t2.minutes);
        }

        [Fact]
        public void ShouldClassVariableChangeAppliesToAllVariable()
        {
            Time2 t21 = new Time2(9, 30);
            Time2 t22 = t21;
            t21.minutes = 100;
            Assert.Equal(100, t22.minutes);
        }
    }
}

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

        [Fact]
        public void ShouldSubstractTwoValues()
        {
            Time t5 = new Time(12, 5);
            Time t6 = new Time(20, 5);
            Time t56 = t5 - t6;
            Assert.Equal(-480, t56.minutes);
        }

        [Fact]
        public void ShouldAddTwoStructValues()
        {
            Time t3 = new Time(2, 50);
            Time t4 = new Time(5, 15);
            Time t34 = t3 + t4;
            Assert.Equal(485, t34.minutes);
        }

        [Fact]
        public void ShouldImplicitlyConvertFromIntToTimeType()
        {
            int v2 = 100;
            Time timeImpl = v2;
            Assert.IsType<Time>(timeImpl);
        }

        [Fact]
        public void ShouldExplicitlyConvertFromTimeTypeToInt()
        {
            Time v = new Time(8, 50);
            int timeExpl = (int)v;
            Assert.IsType<int>(timeExpl);
        }
    }
}

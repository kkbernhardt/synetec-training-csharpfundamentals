using System;
using TestGenericStruct;
using Xunit;

namespace TestGenericStructTests
{
    public class UnitTestsForTestGenericStructProject
    {
        [Fact]
        public void ShouldBeEqualToFst()
        {
            Pair<string, int> pairStruct = new Pair<string, int>("Andrew", 2);
            Assert.Equal("Andrew", pairStruct.Fst);
        }

        [Fact]
        public void ShouldBeTypeInt()
        {
            Pair<string, int> pairStruct = new Pair<string, int>("Andrew", 2);
            Assert.IsType<int>(pairStruct.Snd);
        }

        [Fact]
        public void ShouldGiveBackNullwhenNoValueAssignedToString()
        {
            Pair<string, double> fourthPerson = new Pair<string, double>();
            Assert.Null(fourthPerson.Fst);
        }

        [Fact]
        public void ShouldGiveBackZeroWhenNoValueAssignedToDouble()
        {
            Pair<string, double> fourthPerson = new Pair<string, double>();
            Assert.Equal(0, fourthPerson.Snd);
        }

        [Fact]
        public void ShouldGivePairType()
        {
            Pair<string, int> pairFirst = new Pair<string, int>();
            Pair<Pair<string, int>, string> appointment = new Pair<Pair<string, int>, string>(pairFirst, "local GP");
            Assert.IsType<Pair<string, int>>(appointment.Fst);
        }

        [Fact]
        public void ShouldSwapPairTypes()
        {
            Pair<string, int> pairFirst = new Pair<string, int>();
            Assert.IsType<Pair<int, string>>(pairFirst.Swap());
        }
    }
}

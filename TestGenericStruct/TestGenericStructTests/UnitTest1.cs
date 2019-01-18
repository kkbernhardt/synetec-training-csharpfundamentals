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
    }
}

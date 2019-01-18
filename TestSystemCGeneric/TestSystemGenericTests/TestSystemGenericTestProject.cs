using System;
using System.Collections.Generic;
using TestSystemCGeneric;
using Xunit;

namespace TestSystemGenericTests
{
    public class TestSystemGenericTestProject
    {
        List<double> myList = new List<double>() { 2.5, 4.5, 7.3 };
        [Fact]
        public void ShouldGiveCorrectResult()
        {
            var num = 5;
            int result = Program.GreaterCount(myList, 5);
            Assert.Equal(1, result);
        }
    }
}

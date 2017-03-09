using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class DecodeWaysTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(string s, int output)
        {
            Assert.Equal(output, Solution091.NumDecodings());
        }
    }
}


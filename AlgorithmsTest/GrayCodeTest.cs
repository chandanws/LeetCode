using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class GrayCodeTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(int n, IList<int> output)
        {
            Assert.Equal(output, Solution089.GrayCode());
        }
    }
}


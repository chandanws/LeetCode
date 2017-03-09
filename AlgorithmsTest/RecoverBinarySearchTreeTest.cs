using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class RecoverBinarySearchTreeTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(,  output)
        {
            Assert.Equal(output, Solution099.());
        }
    }
}


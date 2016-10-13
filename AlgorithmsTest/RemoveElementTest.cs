using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class RemoveElementTest
    {
        [Theory]
        [InlineData(new[]{2,2,3},2,1)]
        public void TestMethod(int[] nums, int val, int output)
        {
            Assert.Equal(output, Solution027.RemoveElement(nums,val));
        }
    }
}


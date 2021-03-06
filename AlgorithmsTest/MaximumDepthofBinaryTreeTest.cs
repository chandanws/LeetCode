using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class MaximumDepthofBinaryTreeTest
    {
        [Theory]
        [InlineData()]
        [MemberData(nameof(InlineData))]
        public void TestMethod(TreeNode root, int output)
        {
            Assert.Equal(output, Solution104.MaxDepth(root));
        }
        
        public static IEnumerable<object[]> InlineData
        {
            get
            {
                 var driverData = new List<object[]>();
                 return driverData;
            }
        }
    }
}


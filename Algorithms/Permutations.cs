// Source : https://leetcode.com/problems/permutations/ 
// Author : codeyu 
// Date : Tuesday, October 25, 2016 11:19:51 PM 

/**********************************************************************************
*
* 
* Given a collection of distinct numsbers, return all possible permutations.
* 
* 
* 
* For example,
* [1,2,3] have the following permutations:
* 
* [
*   [1,2,3],
*   [1,3,2],
*   [2,1,3],
*   [2,3,1],
*   [3,1,2],
*   [3,2,1]
* ]
* 
* 
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
namespace Algorithms
{
    public class Solution046 
    {
        public static IList<IList<int>> Permute(int[] nums) 
        {
            IList<IList<int>> result = new List<IList<int>>();
            if(nums==null || nums.Length==0) return result;
            helper(nums, new bool[nums.Length], new List<int>(), result);
            return result;
            
        }
        
        private static void helper(int[] nums, bool[] used, IList<int> item, IList<IList<int>> result)
        {
            if(item.Count == nums.Length)
            {
                result.Add(new List<int>(item));
                return;
            }
            for(int i=0;i<nums.Length;i++)
            {
                if(!used[i])
                {
                    used[i] = true;
                    item.Add(nums[i]);
                    helper(nums, used, item, result);
                    item.RemoveAt(item.Count - 1);
                    used[i] = false;
                }
            }
        }
        public IList<IList<int>> Permute2(int[] nums) 
        {
            IList<IList<int>> result = new List<IList<int>>();
            if(nums == null || nums.Length==0) return result;
            IList<int> first = new List<int>();
            first.Add(nums[0]);
            result.Add(first);
            for(int i=1;i<nums.Length;i++)
            {
                IList<IList<int>> newresult = new List<IList<int>>();
                for(int j=0;j<result.Count;j++)
                {
                    IList<int> cur = result[j];
                    for(int k=0;k<cur.Count+1;k++)
                    {
                        IList<int> item = new List<int>(cur);
                        item.Insert(k,nums[i]);
                        newresult.Add(item);
                    }
                }
                result = newresult;
            }
            return result;   
        }
    }
}


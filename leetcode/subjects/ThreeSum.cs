using System;
using System.Collections.Generic;

namespace leetcode.subjects
{
    public class ThreeSum
    {
        public static void Run(){
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            var res = new ThreeSum().MyMethod(new int[4]{1,-1,-1,0});
            sw.Stop();
            Console.WriteLine(res);
            Console.WriteLine(sw.ElapsedTicks/10000d +" ms");
        }

        public IList<IList<int>> MyMethod(int[] nums)
        {
            IList<IList<int>> result =new List<IList<int>>();
            int length = nums.Length;
            if(length<3) return result; 
            Array.Sort(nums);
            for (int first = 0; first < length; ++first)
            {
                if(first>0 && nums[first]==nums[first-1]) continue;
                for (int second = first + 1,third = length - 1; second < length; ++second)
                {
                    if(second>first+1 && nums[second]==nums[second-1])continue;
                    while(second<third && nums[second] + nums[third]> -nums[first])
                        --third;
                    if(second == third) break;
                    if(nums[first] + nums[second] + nums[third]==0)
                        result.Add(new List<int>(3){nums[first],nums[second],nums[third]});
                }
            }
            return result;
        }
    }
}
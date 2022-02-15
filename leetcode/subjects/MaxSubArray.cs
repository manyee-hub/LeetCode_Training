using System;

namespace leetcode.subjects{
    class MaxSubArray
    {
        public static void Run(){
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            int[] nums = new int[9]{-2,1,-3,4,-1,2,1,-5,4};
            int res = new MaxSubArray().MyMethod(nums);
            sw.Stop();
            Console.WriteLine(res);
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        public int MyMethod(int[] nums){
            int pre= 0,maxSum = nums[0]; 
            for (int i = 0,length = nums.Length; i < length; i++)
            {
                int x = nums[i];
                pre = Math.Max(pre + x, x);
                maxSum = Math.Max(maxSum, pre);
            }
            return maxSum;
        }

        public int Official(int[] nums) {
            return 0;
        }
    }
}
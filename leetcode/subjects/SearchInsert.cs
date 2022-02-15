using System;

namespace leetcode.subjects{
    class SearchInsert
    {
        public static void Run(){
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            int[] obj = new int[5]{1,3,5,6,7};
            int target = 8;
            int res = new SearchInsert().MyMethod(obj,target);
            sw.Stop();
            Console.WriteLine(res);
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        public int MyMethod(int[] nums,int target){
            int min = 0,max = nums.Length-1;
            while(min<=max){
                int mid = ((max-min)>>1) +min;
                if(nums[mid] >= target)
                    max = mid-1;
                else
                    min = mid+1;
            }
            return min;
        }
        public int Official(int[] nums,int target) {
            int n = nums.Length;
            int left = 0, right = n - 1, ans = n;
            while (left <= right) {
                int mid = ((right - left) >> 1) + left;
                if (target <= nums[mid]) {
                    ans = mid;
                    right = mid - 1;
                } else {
                    left = mid + 1;
                }
            }
            return ans;
        }
    }
}
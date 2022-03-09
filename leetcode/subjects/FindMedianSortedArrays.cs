using System;

namespace leetcode.subjects
{
    class FindMedianSortedArrays
    {
        public static void Run(){
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            int[] nums1 = new int[2]{1,3}, nums2 = new int[1]{2};
            double res = new FindMedianSortedArrays().MyMethod(nums1,nums2);
            sw.Stop();
            Console.WriteLine(res);
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
        // nums1.length == m
        // nums2.length == n
        // 0 <= m <= 1000
        // 0 <= n <= 1000
        // 1 <= m + n <= 2000
        // -106 <= nums1[i], nums2[i] <= 106
        public double MyMethod(int[] nums1, int[] nums2){
            int length = nums1.Length + nums2.Length, i = 0, j = 0 , mid = length >> 1,first = 0, last = 0;
            bool isOdd = length%2!=0;
            while(i+j<=mid){
                int temp = 0;
                if(i==nums1.Length){
                    temp = nums2[j++];
                }else if(j==nums2.Length){
                    temp = nums1[i++];
                }else if(nums1[i]<nums2[j]){
                    temp = nums1[i++];
                }else{
                    temp = nums2[j++];
                }
                if(isOdd){
                    if(i+j==mid+1) first = temp;
                }else{
                    if(i+j == mid) first = temp;
                    if(i+j == mid+1) last = temp;
                }
            }
            return isOdd?first:(first+last)/2d;
        }
        
        public double Official(int[] nums1, int[] nums2) {
            int length = nums1.Length + nums2.Length, i = 0, j = 0 , mid = length >> 1,first = 0, last = 0;
            bool isOdd = length%2!=0;
            while(i+j<=mid){
                int temp = 0;
                if(i==nums1.Length){
                    temp = nums2[j++];
                }else if(j==nums2.Length){
                    temp = nums1[i++];
                }else if(nums1[i]<nums2[j]){
                    temp = nums1[i++];
                }else{
                    temp = nums2[j++];
                }
                if(isOdd){
                    if(i+j==mid+1) first = temp;
                }else{
                    if(i+j == mid) first = temp;
                    if(i+j == mid+1) last = temp;
                }
            }
            return isOdd?first:(first+last)/2d;
        }
    }
}
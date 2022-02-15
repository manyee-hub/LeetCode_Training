using System;
using System.Linq;

namespace leetcode.subjects{
    class Merge
    {
        public static void Run(){
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            int[] nums1 = new int[6]{7,0,0,0,0,0}, nums2 = new int[5]{1,3,5,6,7};
            int m = 1, n = 5;
            new Merge().Official(nums1,m,nums2,n);
            sw.Stop();
            nums1.ToList().ForEach(num=>Console.WriteLine(num));
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        public void MyMethod(int[] nums1, int m, int[] nums2, int n){
            int i = m - 1, j = n - 1;
            while (j>=0)
            {
                if(i<0){
                    nums1[j] = nums2[j--];
                }else{
                    if(nums1[i]>=nums2[j]){
                        nums1[i+j+1] = nums1[i--];
                    }else{
                        nums1[i+j+1] = nums2[j--];
                    }
                }
            }
        }
        
        public void Official(int[] nums1, int m, int[] nums2, int n) {
            int p1 = m - 1, p2 = n - 1;
            int tail = m + n - 1;
            int cur;
            while (p1 >= 0 || p2 >= 0) {
                if (p1 == -1) {
                    cur = nums2[p2--];
                } else if (p2 == -1) {
                    cur = nums1[p1--];
                } else if (nums1[p1] > nums2[p2]) {
                    cur = nums1[p1--];
                } else {
                    cur = nums2[p2--];
                }
                nums1[tail--] = cur;
            }
        }
    }
}
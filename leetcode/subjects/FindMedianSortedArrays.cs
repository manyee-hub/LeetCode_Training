using System;

namespace leetcode.subjects
{
    class FindMedianSortedArrays
    {
        public static void Run(){
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            int[] nums1 = new int[5]{1,5,7,8,9}, nums2 = new int[4]{3,5,6,8};
            double res = new FindMedianSortedArrays().MyMethod(nums1,nums2);
            sw.Stop();
            Console.WriteLine(res);
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        public double MyMethod(int[] nums1, int[] nums2){
            int[] res = new int[nums1.Length+nums2.Length];
            int i = 0, j = 0 ,s = 0 ,mid = (nums1.Length+nums2.Length)/2;
            while(i<nums1.Length || j<nums2.Length){
                if(i>=nums1.Length){
                    res[s++] = nums2[j++];
                }else if(j>=nums2.Length){
                    res[s++] = nums1[i++];
                }else{
                    if(nums1[i] > nums2[j]){
                        res[s++] = nums2[j++];
                    }else{
                        res[s++] = nums1[i++];
                    }
                }
            }
            if(s==1) return res[0];
            else{
                if(s%2==0){return (res[mid]+res[mid+1])/2d;}
                else return res[mid];
            }
        }
        
        public double Official(int[] nums1, int[] nums2) {
            return 0;
        }
    }
}
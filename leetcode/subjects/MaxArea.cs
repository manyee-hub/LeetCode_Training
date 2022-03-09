using System;
using System.Text;

namespace leetcode.subjects
{
    public class MaxArea
    {
        public static void Run(){
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            int[] arr = new int[5]{4,3,2,1,4};
            var res = new MaxArea().Official(arr);
            sw.Stop();
            Console.WriteLine(res);
            Console.WriteLine(sw.ElapsedTicks/10000d +" ms");
        }
        
        public int MyMethod(int[] height){
            int max = 0 ,left = 0, right = height.Length-1;
            while(left<right){
                int w = right-left, h = 0;
                if(height[left] < height[right]){
                    h = height[left];
                    ++left;
                }else{
                    h = height[right];
                    --right;
                }
                max = Math.Max(max,w*h);
            }
            return max;
        }
        
        public int Official(int[] height){
            int maxV = 0,count = height.Length;
            for (int i = 0,j=count-1; i <= j; )
            {
                if (Math.Min(height[i],height[j])* (j-i)>maxV)
                    maxV = Math.Min(height[i], height[j]) * (j - i);
                if (height[i] > height[j])--j;else ++i;
            }
            return maxV;
        }
    }
}
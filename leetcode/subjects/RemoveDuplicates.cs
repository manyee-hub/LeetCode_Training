using System;

namespace leetcode.subjects{
    class RemoveDuplicates
    {
        public static void Run(){
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            int[] ints = new int[]{};
            int res = new RemoveDuplicates().MyMethod(ints,3);
            sw.Stop();
            Console.WriteLine(res);
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        public int MyMethod(int[] ints,int target){
            int fast = 0,slow = 0,length = ints.Length;
            if (length==0) return 0;
            while(++fast<length){
                int temp = ints[fast];
                if(ints[slow] != temp)
                    ints[++slow] = temp;
            }
            return slow+1;
        }
        public int Official(int[] ints) {
            return 0;
        }
    }
}
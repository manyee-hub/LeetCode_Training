using System;

namespace leetcode.subjects{
    class RemoveElement
    {
        public static void Run(){
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            int[] ints = new int[8]{0,1,2,2,3,0,4,2};
            int res = new RemoveElement().MyMethod(ints,3);
            sw.Stop();
            Console.WriteLine(res);
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        public int MyMethod(int[] ints,int target){
            int i = 0,length = ints.Length;
            while (i<length)
            {
                if(ints[i] ==target){
                   ints[i] = ints[length-1];
                   ints[length-1] = target;
                   length--;
                }else i++;
            }
            return length;
        }
        public int Official(int[] ints) {
            return 0;
        }
    }
}
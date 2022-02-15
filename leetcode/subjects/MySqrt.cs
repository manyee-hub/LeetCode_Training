using System;

namespace leetcode.subjects{
    class MySqrt
    {
        public static void Run(){
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            int num = 45;
            int res = new MySqrt().MyMethod(num);
            sw.Stop();
            Console.WriteLine(res);
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        public int MyMethod(int n){
            int n_1 = 0,n_2 = 0,target = 1;
            for (int i = 0,length = n; i < length; ++i)
            {
                n_2 = n_1;
                n_1 = target;
                target = n_1 + n_2;
            }
            return target;
        }
        public int Official(int n) {
            return n;
        }
    }
}
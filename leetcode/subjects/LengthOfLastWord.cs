using System;

namespace leetcode.subjects{
    class LengthOfLastWord
    {
        public static void Run(){
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            int res = new LengthOfLastWord().MyMethod("joyboy");
            sw.Stop();
            Console.WriteLine(res);
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        public int MyMethod(string str){
            str = str.Trim();
            return str.Length-str.LastIndexOf(" ")-1;
        }
        public int Official() {
            return 0;
        }
    }
}
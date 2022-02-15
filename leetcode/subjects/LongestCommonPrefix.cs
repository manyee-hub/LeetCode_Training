using System;

namespace leetcode.subjects{
    class LongestCommonPrefix
    {
        public static void Run(){
            //string[] objs = new string[3]{"cb","cbb","a"};
            //string[] objs = new string[3]{"flower","flow","flider"};
            //string[] objs = new string[2]{"car","cir"};
            string[] objs = new string[3]{"reflower","flow","flider"};
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            string res = new LongestCommonPrefix().MyMethod(objs);
            sw.Stop();
            Console.WriteLine(res);
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        public string MyMethod(string[] strs){
            string current = strs[0];
            int i = 1,maxIndex = current.Length;
            while (i < strs.Length)
            {
                var next = strs[i++];
                if(string.IsNullOrEmpty(current) || string.IsNullOrEmpty(next)) return "";
                var temp = GetSamePrefixIndex(maxIndex,current,next);
                if(temp==0)return"";
                if(maxIndex > temp) maxIndex = temp;
                if(maxIndex > next.Length) current = next;
            }
            return current.Substring(0,maxIndex);
        }
        public string Official(string[] strs) {
            return "";
        }

        public int GetSamePrefixIndex(int len,string current,string next){
            int index = 0;
            if(next.Length<len)len = next.Length;
            for (int i = 0; i < len; i++)
                if(current[i] == next[i]) index++;
                else return index;
            return index;
        }
    }
}
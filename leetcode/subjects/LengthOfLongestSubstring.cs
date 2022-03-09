using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace leetcode.subjects
{
    public class LengthOfLongestSubstring
    {
        public static void Run(){
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            var res = new LengthOfLongestSubstring().MyMethod("pwckeqa");
            sw.Stop();
            Console.WriteLine(res);
            Console.WriteLine(sw.ElapsedTicks/10000d +" ms");
        }

        public int MyMethod(string s){
            int max = 0,fast = 0,slow = 0,length = s.Length;
            HashSet<char> set = new HashSet<char>();
            while(fast<length){
                if(set.Contains(s[fast])){
                    set.Remove(s[slow]);
                    ++slow;
                }else{
                    set.Add(s[fast]);
                    ++fast;
                }
                if(fast - slow > max) max = fast - slow;
            }
            return max;
        }
        public int Official(string s){
            int max = 0;
            HashSet<char> set = new HashSet<char>();
            for (int fast = -1,slow = 0,length = s.Length; slow < length; ++slow)
            {
                if(slow>0) set.Remove(s[slow-1]);
                while(fast+1<length && !set.Contains(s[fast+1])){
                    set.Add(s[fast+1]);
                    ++fast;
                }
                if(fast+1 - slow > max) max = fast+1 - slow;
            }
            return max;
        }
    }
}
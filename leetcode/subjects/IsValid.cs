using System;
using System.Collections.Generic;

namespace leetcode.subjects{
    class IsValid
    {
        public static void Run(){
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            string target = "]]";
            bool res = new IsValid().MyMethod(target);
            sw.Stop();
            Console.WriteLine(res);
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        public bool MyMethod(string s){
            var chars = new Stack<char>();
            char curr;
            for (int i = s.Length-1; i >= 0; i--)
            {
                curr = s[i];
                int right = SwitchChar(curr);
                if(right==0)return false;
                if(right>0)
                    chars.Push(curr);
                else{
                    if(chars.Count==0) return false;
                    var left = SwitchChar(chars.Pop());
                    if(right+left!=0) return false;
                }
            }
            return chars.Count==0;
        }

        public int SwitchChar(char x){
            switch (x)
            {
                case '(':
                return -1;
                case ')':
                return 1;
                case '[':
                return -2;
                case ']':
                return 2;
                case '{':
                return -3;
                case '}':
                return 3;
                default:
                return 0;
            }
        }

        public bool Official(string target) {
            return true;
        }
    }
}
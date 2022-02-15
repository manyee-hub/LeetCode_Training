using System;

namespace leetcode.subjects{
    class RomanToInt
    {
        public static void Run(){
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            string roman = "MCMXCIV";
            int res = new RomanToInt().MyMethod(roman);
            sw.Stop();
            Console.WriteLine(res);
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        public int MyMethod(string s){
            s = s.Replace("IV","a");
            s = s.Replace("IX","b");
            s = s.Replace("XL","c");
            s = s.Replace("XC","d");
            s = s.Replace("CD","e");
            s = s.Replace("CM","f");
            int res = 0;
            for (int i = 0,length = s.Length; i < length; i++)
            {
                res += SwitchInt(s[i]);
            }
            return res;
        }

        public int SwitchInt(char x){
            switch (x)
            {
                case 'I':
                return 1;
                case 'V':
                return 5;
                case 'X':
                return 10;
                case 'L':
                return 50;
                case 'C':
                return 100;
                case 'D':
                return 500;
                case 'M':
                return 1000;
                case 'a':
                return 4;
                case 'b':
                return 9;
                case 'c':
                return 40;
                case 'd':
                return 90;
                case 'e':
                return 400;
                case 'f':
                return 900;
                default:
                return 0;
            }
        }
        public int Official(string s) {
            return 0;
        }
    }
}
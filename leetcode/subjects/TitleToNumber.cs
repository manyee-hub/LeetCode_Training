using System;

namespace leetcode.subjects
{
    public class TitleToNumber{
        
        public static void Run(){
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            int res = new TitleToNumber().MyMethod("AZ");
            sw.Stop();
            Console.WriteLine(res);
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        public int MyMethod(string columnTitle){
            double sum = 0d;
            for (int i = 0,length = columnTitle.Length; i < length; i++)
            {
                sum += (Math.Pow(26,length-i-1) * (columnTitle[i] - 64));
            }
            return (int)sum;
        }

        public int Official(string columnTitle) {
            int number = 0;
            int multiple = 1;
            for (int i = columnTitle.Length - 1; i >= 0; i--) {
                int k = columnTitle[i] - 'A' + 1;
                number += k * multiple;
                multiple *= 26;
            }
            return number;
        }
    }
}
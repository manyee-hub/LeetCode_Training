using System;
using System.Text;

namespace leetcode.subjects
{
    public class ConvertToTitle{
        public static void Run(){
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            string res = new ConvertToTitle().MyMethod(701);
            sw.Stop();
            Console.WriteLine(res);
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        public string MyMethod(int columnNumber){
            StringBuilder sb = new StringBuilder();
            while(columnNumber!=0){
                char one = 'A';
                int remainder = columnNumber%26;
                int quotient = columnNumber/26;
                if(remainder==0){
                    one += (char)25;
                    --quotient;
                }else{
                    one += (char)(remainder-1);
                }
                sb.Insert(0,one);
                columnNumber = quotient;
            }
            return sb.ToString();
        }

        public string Official(int columnNumber) {
            return "";
        }
    }
}
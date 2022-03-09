using System;
using System.Text;

namespace leetcode.subjects
{
    public class Convert
    {
        public static void Run(){
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            string res = new Convert().MyMethod("yridnxbcheovotmaqhveidmnobswcdrawcfjzhlincdevpgnydrggftxhntltknpmubndmvrobvlsbzreqznwvkfidsdpftezwtdirwzsrmkulbaedncyzjicbmughyfdrknigoczbnvoqwsvlwtlfcpgqjmxjucbgplneomhdivvgqrtmkgsoyy",101);
            sw.Stop();
            Console.WriteLine(res);
            Console.WriteLine(sw.ElapsedTicks/10000d +" ms");
        }
        
        public string MyMethod(string s, int numRows){
            int length = s.Length,spacer = (numRows-1)*2;
            if(length<3 || numRows==1)return s;
            StringBuilder sb = new StringBuilder(length);
            for (int i = 0; i < numRows; ++i)
            {
                int start = i,index = 0;
                while(start<length){
                    sb.Append(s[start]);
                    if(i==0) start = 0;
                    if(i==numRows-1) ++index;
                    start = spacer*++index - start;
                }
            }
            return sb.ToString();
        }
        
        public string Official(string s, int numRows) {
            return "";
        }
    }
}
using System;
using System.Linq;
using System.Text;

namespace leetcode.subjects{
    class AddBinary
    {
        public static void Run(){
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            string a = "1",b = "111";
            string res = new AddBinary().MyMethod(a,b);
            sw.Stop();
            Console.WriteLine(res);
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        public string MyMethod(string a, string b){
            StringBuilder str = new StringBuilder("");
            int length = Math.Max(a.Length,b.Length);
            a = a.PadLeft(length,'0');
            b = b.PadLeft(length,'0');
            char carry = '0';
            for (int i = length-1; i >=-1; i--)
            {
                if(i<0) {
                    if(carry!='0')str.Insert(0,carry);
                }else if(a[i]==b[i]){
                    str.Insert(0,carry);
                    carry = a[i];
                }else{
                    str.Insert(0,carry=='1'?'0':'1');
                }
            }
            return str.ToString();
        }

        public string Official(string a, string b) {
            // char _a = a.ElementAtOrDefault(i), _b = b.ElementAtOrDefault(i);
            // if(_a!='1')_a = '0';
            // if(_b!='1')_b = '0';
            // if(_a=='1' && _b=='1'){
            //     str.Insert(0,temp);
            //     temp = '1';
            // }else if(_a=='0' && _b=='0'){
            //     str.Insert(0,temp);
            // }else{
            //     str.Insert(0,temp=='1'?'0':'1');
            // }
            return "";
        }
    }   
}
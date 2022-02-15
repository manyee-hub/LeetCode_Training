using System;
using System.Linq;

namespace leetcode.subjects{
    class PlusOne
    {
        public static void Run(){
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            int[] digits = new int[4]{9,9,9,9};
            int[] res = new PlusOne().MyMethod(digits);
            sw.Stop();
            res.ToList().ForEach(item=>Console.WriteLine(item));
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        public int[] MyMethod(int[] digits){
            int temp = 1,index= digits.Length-1;
            while (temp!=0 && index>=0)
            {
                int item = digits[index];
                digits[index] = (item+temp>=10)?((item+temp)%10) :(item+temp);
                temp = (item+temp)/10;
                index--;
            }
            if(temp != 0 ) {
                var _digits = new int[digits.Length+1];
                _digits[0] = temp;
                for (int i = 0,length = digits.Length; i < length; i++)
                {
                    _digits[i+1] = digits[i];
                }
                digits = _digits;
            }
            return digits;
        }

        public int[] Official(int[] digits) {
            int temp = 1,index= digits.Length-1;
            while (temp!=0 && index>=0)
            {
                int item = digits[index];
                digits[index] = (item+temp>=10)?((item+temp)%10) :(item+temp);
                temp = (item+temp)/10;
                index--;
            }
            if(temp != 0 ) {
                Array.Reverse(digits);
                int end = digits.Length;
                Array.Resize(ref digits, end+1);
                digits[end] = temp;
                Array.Reverse(digits);
            }
            return digits;
        }
    }
}
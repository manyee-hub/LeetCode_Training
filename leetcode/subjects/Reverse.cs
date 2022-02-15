using System;
using System.Linq;


namespace leetcode.subjects
{
    class Reverse
    {
        public static void Run(){
            int obj = -2147237411;
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            int res = new Reverse().Official(obj);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
        // 整体思路是 利用取余的方式，将目标数个位作为栈顶的方向，单次取出一个数，
        // 后再通过*10将推入新的栈底，每推一步，判断新数字是否超出int的范围值除以10
        // 重点： 要求不能使用int范围外的整型值，然后将数字翻转，要判断翻转后不能超过int范围
        // 方法：数字判断使用除以10的结果
        // 定理：以上结果只要在int范围除以10的范围内 那么最终结果必定在int范围内，因为int范围的开头2 如果原数字位数超过2 翻转后必定超出范围，然后第二位为1，如果除以10 之后的尾数数字大于1也超出
        // 
        //
        public int Official(int x) {
            int rev = 0;
            while (x != 0) {
                if (rev < int.MinValue / 10 || rev > int.MaxValue / 10) {// 判断当前结果栈是否在int/10的范围内，主要目的是当数字是在int的范围附近，避免超出异常，同时返回0
                    return 0;
                }
                int digit = x % 10;// 把尾数弹出栈顶
                x /= 10;
                rev = rev * 10 + digit;// 把上一个栈弹出的数字 推进结果栈
            }
            return rev;
        }

        public int MyReverse(int x) {
            bool isNegative = x<0;
            if(x==int.MinValue||x==int.MaxValue) return 0;
            var _x = string.Join("",Math.Abs(x).ToString().ToCharArray().Reverse());
            if(_x.Length>10){
                return 0;
            }else if(_x.Length ==10){
                var temp = int.Parse(_x.Substring(0,9));
                if(temp < int.MinValue / 10 || temp > int.MaxValue / 10)
                    return 0;
                else return isNegative?0-int.Parse(_x):int.Parse(_x);
            }else
                return isNegative?0-int.Parse(_x):int.Parse(_x);
 
        }
    }
}
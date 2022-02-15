using System;

namespace leetcode.subjects{
    class IsPalindrome
    {
        public static void Run(){
            int obj = 121;
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            bool res = new IsPalindrome().Official(obj);
            sw.Stop();
            Console.WriteLine(res);
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        public bool MyMethod(int x){
            if(x<0) return false;
            else{
                string _x = x.ToString();
                int length = _x.Length;
                if(length%2==1){
                    length--;
                    _x = _x.Remove(length/2,1);
                }
                for (int i = 0; i < length/2; i++)
                {
                    if(_x[i] != _x[length-i-1]){
                        return false;
                    }
                }
            }
            return true;
        }
        public bool Official(int x) {
            if(x<0 || (x%10==0 && x!=0)) return false;
            int _x = 0;
            while(x>_x){
                _x = _x*10+x%10;
                x /=10;
            }
            return x == _x || x == _x/10;
        }
    }
}
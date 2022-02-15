using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

namespace leetcode.subjects
{
    class Generate
    {
        public static void Run(){
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            var res = new Generate().MyMethod(30);
            sw.Stop();
            Console.WriteLine(res);
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        public IList<IList<int>> MyMethod(int numRows) {
            IList<IList<int>> res = new List<IList<int>>();
            for (int i = 0; i < numRows; ++i)
            {
                IList<int> item = new List<int>{1};
                if(i>1){
                    var pre = res[i-1];
                    for (int j = 1; j < i; ++j)
                    {
                        item.Add(pre[j] + pre[j-1]);
                    }
                }
                if(i>0)item.Add(1);
                res.Add(item);
            }
            return res;
        }
        
        public IList<IList<int>> Official(int numRows) {
            return null;
        }
    }
}
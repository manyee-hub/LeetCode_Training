using System;

namespace leetcode.subjects{
    class StrStr
    {
        public static void Run(){
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            string haystack ="aaaaa";
            string needle ="ba";
            var res = new StrStr().StrStrOther(haystack,needle);
            sw.Stop();
            Console.WriteLine(res);
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
         public int StrStrOther(string haystack, string needle) {
            if (needle.Length == 0)
                return 0;

            // 获取next数组
            int[] next = getNext(needle);

            int i = 0;
            int j = 0;

            while (i < haystack.Length && j < needle.Length)
            {
                if (j == -1 || haystack[i] == needle[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    j = next[j];
                }
            }
            if (j == needle.Length)
                return i - j;
            return -1;
        }

        public int [] getNext(string ps){
            char[] c = ps.ToCharArray();
            int [] next = new int [c.Length];
            int k = -1;
            int j = 0;
            next[0] = -1;
            while(j < c.Length - 1){
                if(k == -1 || c[j] == c[k]){
                    k++;
                    j++;
                    next[j] = k;
                }else{
                    k = next[k];
                }
            }
            return next;
        }

        public int MyMethod(string haystack, string needle){
            int targetLength = needle.Length,length = haystack.Length;
            if(targetLength==0) return 0;
            if(length < targetLength) return -1;
            for (int i = 0; i < length-targetLength+1; i++)
                if(needle.Equals(haystack.Substring(i,targetLength)))return i;
            return -1;
        }

        public bool CompareStr(string str1, string str2){
            for (int i = 0 ,length = str2.Length; i < length; i++)
                if(str1[i]!=str2[i]) return false;
            return true;
        }
        public int Official(string haystack, string needle) {
            return 0;
        }
    }
}
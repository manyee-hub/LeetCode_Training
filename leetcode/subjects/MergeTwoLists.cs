using System;

namespace leetcode.subjects{
    class MergeTwoLists
    {
        public static void Run(){
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ListNode list1 =null;
            ListNode list2 =null;
            var res = new MergeTwoLists().MyMethod(list1,list2);
            sw.Stop();
            Console.WriteLine(res);
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        public ListNode MyMethod(ListNode l1, ListNode l2){
            return null;
        }
        public ListNode Official(ListNode l1, ListNode l2) {
            if (l1 == null) {
                return l2;
            } else if (l2 == null) {
                return l1;
            } else if (l1.val < l2.val) {
                l1.next = Official(l1.next, l2);
                return l1;
            } else {
                l2.next = Official(l1, l2.next);
                return l2;
            }
        }
    }
}
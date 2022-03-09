using System;
using System.Runtime.InteropServices;
using System.Collections.Generic; 

namespace leetcode.subjects{
    class HasCycle
    {
        public static void Run(){
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ListNode end = new ListNode(5);
            ListNode start = new ListNode(3,new ListNode(-1,new ListNode(4,new ListNode(4,end))));
            //end.next = start;
            ListNode head =new ListNode(6,new ListNode(2,start));
            var res = new HasCycle().MyMethod(head);
            sw.Stop();
            Console.WriteLine(res);
            Console.WriteLine(sw.ElapsedTicks/10000d +" ms");
        }

        public bool MyMethod(ListNode head){
            if(head==null || head.next==null) return false;
            ListNode fast = head.next, low = head;
            while(low != fast){
                if(fast==null|| fast.next ==null)
                    return false;
                low = low.next;
                fast = fast.next.next;
            }
            return true;
        }
        
        public bool Official(ListNode head) {
            return true;
        }
    }
}
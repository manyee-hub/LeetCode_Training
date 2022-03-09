using System;
using System.Runtime.InteropServices;
using System.Collections.Generic; 

namespace leetcode.subjects{
    class DetectCycle
    {
        public static void Run(){
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ListNode end = new ListNode(5);
            ListNode start = new ListNode(3,new ListNode(-1,new ListNode(4,new ListNode(4,end))));
            end.next = start;
            ListNode head =new ListNode(6,new ListNode(2,start));
            var res = new DetectCycle().MyMethod(head);
            sw.Stop();
            Console.WriteLine(res);
            Console.WriteLine(sw.ElapsedTicks/10000d +" ms");
        }

        public ListNode MyMethod(ListNode head){
            if(head == null) return null;
            ListNode fast = head, low = head;
            while(fast!=null){
                if(fast.next !=null)
                    fast = fast.next.next;
                else
                    return null;
                ListNode pre = head;
                while(pre!=low){
                    pre = pre.next;
                }
            }
            return new ListNode();
        }
        
        public bool Official(ListNode head) {
            return true;
        }
    }
}
using System;

namespace leetcode.subjects{
    class SwapPairs
    {
        public static void Run(){
            //链表中节点的数目在范围 [0, 100] 内
            //0 <= Node.val <= 100
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ListNode head = new ListNode(1,new ListNode(6,new ListNode(7,new ListNode(17,new ListNode(19)))));
            ListNode res = new SwapPairs().MyMethod(head);
            sw.Stop();
            while (res!=null)
            {
                Console.WriteLine(res.val);
                res = res.next;
            }
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        public ListNode MyMethod(ListNode head){
            if(head==null || head.next==null) return head;
            var next = head.next;
            head.next = MyMethod(head.next.next);
            next.next = head;
            return next;
        }

        public ListNode Official(ListNode head) {
            return head;
        }
    }
}
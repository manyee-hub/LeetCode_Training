using System;

namespace leetcode.subjects{
    class RemoveNthFromEnd
    {
        public static void Run(){
            // 链表中结点的数目为 sz
            // 1 <= sz <= 30
            // 0 <= Node.val <= 100
            // 1 <= n <= sz
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ListNode head = new ListNode(1);
            ListNode res = new RemoveNthFromEnd().MyMethod(head,1);
            sw.Stop();
            while (res!=null)
            {
                Console.WriteLine(res.val);
                res = res.next;
            }
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        public ListNode MyMethod(ListNode head, int n){
            ListNode low = head,fast = head;
            int _low = 1,_fast = 1;
            while (fast.next != null)
            {
                if(_fast - n ==_low){
                    ++_low;
                    low = low.next;
                }
                ++_fast;
                fast = fast.next;
            }
            if(_fast==n){
                return head.next;
            }else{
                low.next = low.next.next;
                return head;
            }
        }

        public ListNode Official(ListNode head) {
            return head;
        }
    }
}
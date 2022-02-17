using System;

namespace leetcode.subjects{
    class RotateRight
    {
        public static void Run(){
            // 链表中节点的数目在范围 [0, 500] 内
            // -100 <= Node.val <= 100
            // 0 <= k <= 2 * 109
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ListNode head = new ListNode(1,new ListNode(2,new ListNode(3,new ListNode(4,new ListNode(5)))));
            ListNode res = new RotateRight().MyMethod(new ListNode(1,new ListNode(2)),1);
            sw.Stop();
            while (res!=null)
            {
                Console.WriteLine(res.val);
                res = res.next;
            }
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        public ListNode MyMethod(ListNode head, int k){
            if (k == 0 || head == null || head.next == null) {
                return head;
            }
            int n = 1;
            ListNode iter = head;
            while (iter.next != null) {
                iter = iter.next;
                ++n;
            }
            int add = n - k % n;
            if (add == n) {
                return head;
            }
            iter.next = head;
            while (add-- > 0) 
                iter = iter.next;
            ListNode ret = iter.next;
            iter.next = null;
            return ret;
        }

        public ListNode Official(ListNode head) {
            return head;
        }
    }
}
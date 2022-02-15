using System;

namespace leetcode.subjects{
    class ReverseList
    {
        public static void Run(){
            // 链表中节点的数目范围是 [0, 5000]
            // -5000 <= Node.val <= 5000
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ListNode head = new ListNode(1,new ListNode(2,new ListNode(3,new ListNode(4,new ListNode(5,new ListNode(6))))));
            ListNode res = new ReverseList().MyMethod(head);
            sw.Stop();
            while (res!=null)
            {
                Console.WriteLine(res.val);
                res = res.next;
            }
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        public ListNode MyMethod(ListNode head){
            return ReverseNode(null,head);
        }

        public ListNode ReverseNode(ListNode pre,ListNode curr)
        {
            if(curr == null){
                return pre;
            }else{
                var next = curr.next;
                curr.next = pre;
                return ReverseNode(curr,next);
            }
        }

        public ListNode Official(ListNode head) {
            return head;
        }
    }
}
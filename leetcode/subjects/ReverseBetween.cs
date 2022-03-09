using System;
using System.Collections.Generic;

namespace leetcode.subjects{
    class ReverseBetween
    {
        public static void Run(){
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ListNode head =new ListNode(6,new ListNode(2));
            var res = new ReverseBetween().Official(head,1,2);
            sw.Stop();
            while (res!=null)
            {
                Console.WriteLine(res.val);
                res = res.next;
            }
            Console.WriteLine(sw.ElapsedTicks/10000d +" ms");
        }

        // 链表中节点数目为 n
        // 1 <= n <= 500
        // -500 <= Node.val <= 500
        // 1 <= left <= right <= n
        public ListNode MyMethod(ListNode head, int left, int right){
            ListNode dummyHead = new ListNode(),curr = dummyHead, tail = null, pre = null;;
            int index = 1;
            dummyHead.next = head;
            while(curr != null && index<left){
                curr = curr.next;
                ++index;
            }
            head = curr;
            curr = curr.next;
            while(curr != null && index <= right){
                var next = curr.next;
                curr.next = pre;
                pre = curr;
                if(index++ == right)tail = next;
                else curr = next;
            }
            head.next.next = tail;
            head.next = curr;
            return dummyHead.next;
        }
        
        public ListNode Official(ListNode head, int left, int right) {
            if (left == right || head == null)
            return head;
            int count = 1;
            ListNode start = head;
            ListNode end = null;
            ListNode start0 = head;
            Stack<ListNode> stack = new Stack<ListNode>();
            while (head != null) {
                if (count < left)
                    start = head;
                else {
                    if (count <= right)
                        stack.Push(head);
                    else {
                        end = head;
                        break;
                    }
                }

                head = head.next;
                count++;
            }
            ListNode start1 = stack.Peek();
            ListNode cur = stack.Pop();
            while (stack.Count>0) {
                cur.next = stack.Peek();
                cur = stack.Pop();
            }
            cur.next = end;
            if (left == 1)
                return start1;
            start.next = start1;
            return start0;
        }
    }
}
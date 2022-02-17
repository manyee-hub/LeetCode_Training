using System;

namespace leetcode.subjects{
    class DeleteDuplicates2
    {
        public static void Run(){
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ListNode head =new ListNode(1);
            var res = new DeleteDuplicates2().MyMethod(head);
            sw.Stop();
            Console.WriteLine(res);
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        // 链表中节点数目在范围 [0, 300] 内
        // -100 <= Node.val <= 100
        // 题目数据保证链表已经按升序 排列
        public ListNode MyMethod(ListNode head){
            ListNode dummyHead = new ListNode(0);
            dummyHead.next = head;
            ListNode curr = dummyHead,next = dummyHead.next;
            int? duplicate = null;
            while(next.next!=null){
                if(next.val == next.next.val){
                    duplicate = next.val;
                }else{
                    curr = next;
                    next = curr.next;
                }
            }
            return dummyHead.next;
        }
        
        public ListNode Official(ListNode head) {
            return head;
        }
    }
}
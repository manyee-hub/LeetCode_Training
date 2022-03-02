using System;

namespace leetcode.subjects{
    class DeleteDuplicates2
    {
        public static void Run(){
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ListNode head =new ListNode(1,new ListNode(2,new ListNode(3,new ListNode(3,new ListNode(4,new ListNode(4,new ListNode(5)))))));
            var res = new DeleteDuplicates2().MyMethod(head);
            sw.Stop();
            while (res!=null)
            {
                Console.WriteLine(res.val);
                res = res.next;
            }
            Console.WriteLine(sw.ElapsedTicks/10000d +" ms");
        }

        // 链表中节点数目在范围 [0, 300] 内
        // -100 <= Node.val <= 100
        // 题目数据保证链表已经按升序 排列
        public ListNode MyMethod(ListNode head){
            if(head == null || head.next == null) return head;
            ListNode dummyHead = new ListNode(0),curr = dummyHead;
            dummyHead.next = head;
            while(curr.next!=null && curr.next.next != null ){
                if(curr.next.val == curr.next.next.val){
                    int duplicate = curr.next.val;
                    while(curr.next!=null && curr.next.val == duplicate){
                        curr.next = curr.next.next;
                    }
                }else
                    curr = curr.next;
            }
            return dummyHead.next;
        }
        
        public ListNode Official(ListNode head) {
            if(head == null || head.next == null)
                return head;
            ListNode next = head.next, newHead = new ListNode(),curr = newHead;
            newHead.next = head;
            bool isCheck = false;
            while(next != null)
            {
                if(curr.next.val != next.val)
                {
                    if(isCheck)
                    {
                        isCheck = false;
                        curr.next = next;
                    }
                    else
                        curr = curr.next;
                }
                else
                    isCheck = true;          
                next = next.next;
            }
            if(isCheck)
                curr.next = next;
            return newHead.next;
        }
    }
}
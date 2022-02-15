using System;

namespace leetcode.subjects{
    class DeleteDuplicates
    {
        public static void Run(){
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ListNode head =new ListNode(1);
            var res = new DeleteDuplicates().MyMethod(head);
            sw.Stop();
            Console.WriteLine(res);
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        public ListNode MyMethod(ListNode head){
            if(head==null) return head;
            ListNode next = head.next,curr = head;
            while(next!=null){
                if(next.val == curr.val){
                    next = next.next;
                    curr.next = next;
                }else{
                    curr = next;
                    next = curr.next;
                }
            }
            return head;
        }
        
        public ListNode Official(ListNode head) {
            return head;
        }
    }
}
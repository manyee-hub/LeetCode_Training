using System;

namespace leetcode.subjects{
    class RemoveElements
    {
        public static void Run(){
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ListNode head = new ListNode(5,new ListNode(5,new ListNode(5,new ListNode(5,new ListNode(5,new ListNode(5))))));
            int target = 5;
            ListNode res = new RemoveElements().MyMethod(head,target);
            sw.Stop();
            while (res!=null)
            {
                Console.WriteLine(res.val);
                res = res.next;
            }
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        public ListNode MyMethod(ListNode head, int val){
            while(head !=null && head.val == val){
                head = head.next;
            }
            var curr = head;
            while(curr != null && curr.next != null ){
                if(curr.next.val == val){
                    curr.next = curr.next.next;
                }else{
                    curr = curr.next;
                }
            }
            return head;
        }

        public ListNode Official(ListNode head) {
            return head;
        }
    }
}
using System;

namespace leetcode.subjects{
    class ReverseKGroup
    {
        public static void Run(){
            // 给你一个链表，每 k 个节点一组进行翻转，请你返回翻转后的链表。
            // k 是一个正整数，它的值小于或等于链表的长度。
            // 如果节点总数不是 k 的整数倍，那么请将最后剩余的节点保持原有顺序。
            // 进阶：
            // 你可以设计一个只使用常数额外空间的算法来解决此问题吗？
            // 你不能只是单纯的改变节点内部的值，而是需要实际进行节点交换。
            // 列表中节点的数量在范围 sz 内
            // 1 <= sz <= 5000
            // 0 <= Node.val <= 1000
            // 1 <= k <= sz
            // 注意事项： 需要保留头节点、尾节点，进行前后组的节点连接
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ListNode head = new ListNode(1,new ListNode(6,new ListNode(7,new ListNode(17,new ListNode(19,new ListNode(42,new ListNode(4,new ListNode(13))))))));
            ListNode res = new ReverseKGroup().MyMethod(head,3);
            sw.Stop();
            while (res!=null)
            {
                Console.WriteLine(res.val);
                res = res.next;
            }
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        public ListNode MyMethod(ListNode head, int k){
            ListNode hair = new ListNode(0), pre = hair;
            hair.next = head;
            while(head != null){
                for (int i = 0; i < k; ++i)
                {
                    
                }
            }
            return hair.next;
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
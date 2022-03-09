using System;

namespace leetcode.subjects{
    class Partition
    {
        public static void Run(){
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ListNode head =new ListNode(6,new ListNode(2,new ListNode(3,new ListNode(3,new ListNode(4,new ListNode(4,new ListNode(5)))))));
            var res = new Partition().Official(head,3);
            sw.Stop();
            while (res!=null)
            {
                Console.WriteLine(res.val);
                res = res.next;
            }
            Console.WriteLine(sw.ElapsedTicks/10000d +" ms");
        }

        // 给你一个链表的头节点 head 和一个特定值 x ，请你对链表进行分隔，使得所有 小于 x 的节点都出现在 大于或等于 x 的节点之前。调整后的数据需要保持原始的先后顺序。
        // 链表中节点的数目在范围 [0, 200] 内
        // -100 <= Node.val <= 100
        // -200 <= x <= 200
        public ListNode MyMethod(ListNode head, int x){
        if(head==null || head.next==null)
            return head;
        ListNode curr = head, minHead = null, maxHead = null, min = null, max = null;
        while(curr!=null){
            var temp =  curr ;
            if(curr.val < x){
                if(minHead==null) minHead = min = temp;
                else min = min.next = temp;
            }else{
                if(maxHead==null) maxHead = max = temp;
                else max = max.next = temp;
            }
            curr = curr.next;
            temp.next = null;
        }
        if(min!=null)min.next = maxHead;
        return minHead??maxHead;
        }
        
        public ListNode Official(ListNode head, int x) {
            ListNode minHead = new ListNode(),maxHead = new ListNode(),min = minHead,max = maxHead;
            while(head!=null){
                if(head.val < x){
                    min = min.next = head;
                }else{
                    max = max.next = head;
                }
                head = head.next;
            }
            min.next = maxHead.next;
            max.next = null;
            return minHead.next;
        }
    }
}
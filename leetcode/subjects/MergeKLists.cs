using System;

namespace leetcode.subjects{
    class MergeKLists
    {
        public static void Run(){
            // k == lists.length
            // 0 <= k <= 10^4
            // 0 <= lists[i].length <= 500
            // -10^4 <= lists[i][j] <= 10^4
            // lists[i] 按 升序 排列
            // lists[i].length 的总和不超过 10^4
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            ListNode item1 = new ListNode(1,new ListNode(6,new ListNode(7,new ListNode(17,new ListNode(19)))));
            ListNode item2 = new ListNode(5,new ListNode(10,new ListNode(11,new ListNode(25))));
            ListNode item3 = new ListNode(3,new ListNode(8,new ListNode(16)));
            ListNode item4 = new ListNode(1,new ListNode(2,new ListNode(9)));
            ListNode item5 = new ListNode(1);
            ListNode item6 = new ListNode(1);
            ListNode[] list = new ListNode[4]{item1,item2,item3,item4};
            ListNode res = new MergeKLists().Official(list);
            sw.Stop();
            while (res!=null)
            {
                Console.WriteLine(res.val);
                res = res.next;
            }
            Console.WriteLine(sw.ElapsedMilliseconds);
        }

        public ListNode MyMethod(ListNode[] lists){
            // 常规思路： 持续循环，每一轮获取到数组中最小数据，使用动态规划(滑动窗口)方式
            int length = lists.Length;
            if(length==0) return null;
            ListNode head = null, curr = head;
            while(true){
                int low = 0;
                for (int fast = 0; fast < length; ++fast)
                {
                    if(lists[fast]!=null){
                        if(lists[low]==null || lists[fast].val < lists[low].val){
                            low = fast;
                        }
                    }
                }
                if(lists[low]==null) {
                    break;
                }else{
                    if(head==null) head = curr = lists[low];
                    else{
                        curr.next = lists[low];
                        curr = curr.next;
                    }
                    lists[low] = lists[low].next;
                }
            }
            return head;
        }

        public ListNode Official(ListNode[] lists) {
            return Merge(lists,0,lists.Length-1);
        }
        
        public ListNode Merge(ListNode[] list, int start, int end)
        {
            if(start == end)
                return list[start];
            if(start > end)
                return null;
            int mid = start + end >>1;
            return MergeTwoList(Merge(list,start,mid), Merge(list,mid+1,end));
        }
        public ListNode MergeTwoList(ListNode l1, ListNode l2) {
            if (l1 == null) {
                return l2;
            } else if (l2 == null) {
                return l1;
            } else if (l1.val < l2.val) {
                l1.next = MergeTwoList(l1.next, l2);
                return l1;
            } else {
                l2.next = MergeTwoList(l1, l2.next);
                return l2;
            }
        }
    }
}
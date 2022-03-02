using System;
using System.Collections.Generic;
using leetcode.subjects;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Partition.Run();
        }

    }
    
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }
}
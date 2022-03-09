using System;
using System.Linq;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            subjects.MaxArea.Run();
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolutions.LinkedListProblems
{
    public class EasyLinkedListProblems
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
                return null;
            ListNode temp = head;
            while(temp != null && temp.next != null)
            {
                if (temp.val == temp.next.val)
                    temp.next = temp.next.next;
                else
                    temp = temp.next;
            }
            return head;
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

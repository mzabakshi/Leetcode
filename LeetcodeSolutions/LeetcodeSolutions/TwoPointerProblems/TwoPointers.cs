using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolutions.TwoPointerProblems
{
    public class TwoPointers
    {
        /// <summary>
        /// Longest Substring Without Repeating Characters
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LengthOfLongestSubstring(string s)
        {
            int left = 0;
            int right = 0;
            int max = 0;

            var hSet = new HashSet<char>();

            while (right < s.Length)
            {

                if (hSet.Contains(s[right]))
                {
                    hSet.Remove(s[left]);
                    left++;
                }
                else
                {
                    hSet.Add(s[right]);
                    right++;
                    max = Math.Max(max, hSet.Count);
                }
            }

            return max;
        }

        /// <summary>
        /// Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsPalindrome(string s)
        {
            if (s == null) return false;
            if (s.Length == 0) return true;

            s = s.ToLower(); // change all to lower case; remember 'toLowerCase()' has a return value
            int i = 0;
            int j = s.Length - 1;

            while (i < j)
            {
                if (!((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= '0' && s[i] <= '9')))
                {
                    i++;
                    continue;
                }

                if (!((s[j] >= 'a' && s[j] <= 'z') || (s[j] >= '0' && s[j] <= '9')))
                {
                    j--;
                    continue;
                }

                if (s[i] == s[j])
                {
                    i++;
                    j--;
                    continue;
                }

                if (s[i] != s[j])
                {
                    return false;
                }
            }
            return true;
            // ALternative approach -- much slower
            //var str = "";
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if ((s[i] >= 48 && s[i] <= 57) || (s[i] >= 65 && s[i] <= 90) || (s[i] >= 97 && s[i] <= 122))
            //        str += s[i];
            //}

            //int left = 0;
            //int right = str.Length - 1;
            //while(left < str.Length/2)
            //{
            //    if (char.ToLower(str[left]) != char.ToLower(str[right])) 
            //        return false;

            //    left++;
            //    right--;
            //}

            //return true;
        }

        /// <summary>
        ///  ALternative approach -- much slower
        ///  Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsPalindrome_Alternative(string s)
        {
            var str = "";
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] >= 48 && s[i] <= 57) || (s[i] >= 65 && s[i] <= 90) || (s[i] >= 97 && s[i] <= 122))
                    str += s[i];
            }

            int left = 0;
            int right = str.Length - 1;
            while (left < str.Length / 2)
            {
                if (char.ToLower(str[left]) != char.ToLower(str[right]))
                    return false;

                left++;
                right--;
            }

            return true;
        }

        /// <summary>
        /// Two Sum II - Input array is sorted
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;

            while (numbers[left] + numbers[right] != target)
            {
                if (numbers[left] + numbers[right] > target)
                    right--;
                else
                    left++;
            }

            return new int[] { ++left, ++right};
        }

        /// <summary>
        /// Move Zeroes
        /// </summary>
        /// <param name="nums"></param>
        public void MoveZeroes(int[] nums)
        {
            if (nums.Length == 0) return;

            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                    nums[index++] = nums[i];
            }
            while (index < nums.Length)
            {
                nums[index++] = 0;
            }
        }

        /// <summary>
        /// Reverse String
        /// </summary>
        /// <param name="s"></param>
        public void ReverseString(char[] s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                var temp = s[left];
                s[left++] = s[right];
                s[right--] = temp;
            }
        }

        /// <summary>
        /// Reverse Vowels of a String
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string ReverseVowels(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            char[] str = s.ToCharArray();

            while (left < right)
            {
                if (Array.IndexOf(vowels, str[left]) == -1)
                    left++;
                if (Array.IndexOf(vowels, str[right]) == -1)
                    right--;

                if (Array.IndexOf(vowels, str[left]) > -1 && Array.IndexOf(vowels, str[right]) > -1)
                {
                    var temp = str[left];
                    str[left++] = str[right];
                    str[right--] = temp;
                }
            }

            return new string(str);
        }

        /// <summary>
        /// Backspace String Compare
        /// </summary>
        /// <param name="S"></param>
        /// <param name="T"></param>
        /// <returns></returns>
        public bool BackspaceCompare(string S, string T)
        {
            return PostBackspaceString(S) == PostBackspaceString(T);
        }

        public string PostBackspaceString(string s)
        {
            string str = "";
            int count = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '#')
                    count++;
                else
                {
                    if (count > 0)
                        count--;
                    else
                        str += s[i];
                }
            }

            return str;
        }

        /// <summary>
        /// 977. Squares of a Sorted Array
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] SortedSquares(int[] nums)
        {
            int index = nums.Length - 1;
            int left = 0;
            int right = nums.Length - 1;
            int[] arr = new int[nums.Length];

            while(left <= right)
            {
                if (Math.Abs(nums[left]) < Math.Abs(nums[right]))
                {
                    arr[index--] = nums[right] * nums[right];
                    right--;
                }
                else
                {
                    arr[index--] = nums[left] * nums[left];
                    left++;
                }
            }
            return arr;
        }

        /// <summary>
        /// Given head, the head of a linked list, determine if the linked list has a cycle in it.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null)
                return false;

            ListNode first = head;
            ListNode second = head.next;
            while (second.next != null && second.next.next != null)
            {
                if (first == second)
                    return true;
                first = first.next;
                second = second.next.next;
            }

            return false;
        }

        /// <summary>
        ///  Remove Nth Node From End of List
        /// </summary>
        /// <param name="head"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode fast = head;
            ListNode slow = head;

            for (int i = 0; i < n; i++)
            {
                fast = fast.next;
            }

            if (fast == null)
                return head.next;

            while (fast.next != null)
            {
                fast = fast.next;
                slow = slow.next;
            }

            slow.next = slow.next.next;

            return head;
        }

        /// <summary>
        /// Given the head of a linked list, rotate the list to the right by k places
        /// </summary>
        /// <param name="head"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        //public ListNode RotateRight(ListNode head, int k)
        //{
        //    ListNode slow = head;
        //    ListNode fast = head.next;

        //    while (fast.next.next != null)
        //    {
        //        fast = fast.next;
        //    }
        //}
    }

    public class ListNode {
         public int val;
         public ListNode next;
         public ListNode(int x) {
             val = x;
             next = null;
         }
    }

}

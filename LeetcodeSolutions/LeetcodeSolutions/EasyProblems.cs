using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolutions
{
    public class EasyProblems
    {
        /// <summary>
        /// Given an array of integers, return indices of the two numbers such that they add up to a specific target.
        /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// Example: Given nums = [2, 7, 11, 15], target = 9, Because nums[0] + nums[1] = 2 + 7 = 9, return [0, 1].
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int compliment = target - nums[i];

                if (dict.ContainsKey(compliment))
                {
                    var index = Array.IndexOf(nums, compliment);
                    return new int[] { index, i };
                }
                else
                {
                    if (!dict.ContainsKey(nums[i]))
                        dict.Add(nums[i], i);
                }
            }

            return new int[] { };
        }

        /// <summary>
        /// Given a 32-bit signed integer, reverse digits of an integer.
        /// Example 1: Input: 123 Output: 321
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int Reverse(int x)
        {
            int rev = 0;

            while (x > 0)
            {
                rev = rev * 10 + x % 10;
                x = x / 10;
            }

            return rev;
            //int number = x;
            //int reverse = 0;
            //int count = 0;
            //if (x < 0)
            //{
            //    count = System.Math.Abs(-x).ToString().Length;
            //}
            //else
            //{
            //    count = x.ToString().Length;
            //}

            //while (count > 0)
            //{
            //    int val = Math.Abs(x) % 10;
            //    try
            //    {
            //        reverse = int.Parse(reverse.ToString() + val.ToString()); 
            //    }
            //    catch (Exception ex)
            //    {
            //        return 0;
            //    }
            //    x = x / 10;
            //    count--;
            //}

            //if (number < 0)
            //    reverse = System.Math.Abs(reverse) * (-1);

            //return reverse;
        }


        /// <summary>
        /// Determine whether an integer is a palindrome. An integer is a palindrome when it reads the same backward as forward. 
        /// Coud you solve it without converting the integer to a string?
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            int result = x;
            int reverse = 0;

            while (result > 0)
            {
                try
                {
                    checked
                    {
                        reverse = reverse * 10 + result % 10;
                        result = result / 10;
                    }
                }
                catch (OverflowException ex)
                {
                    return false;
                }
            }

            if (x == reverse)
                return true;
            else
                return false;
        }

        public bool IsPalindromTakingHalf(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }

            int revNumber = 0;
            while (x > revNumber)
            {
                revNumber = revNumber * 10 + x % 10;
                x = x / 10;
            }

            return x == revNumber || x == revNumber / 10;
        }

        public int RomanToInt(string s)
        {
            int res = 0;

            for (int i = s.Length - 1; i > -1; i--)
            {
                int val = 0;

                switch (s[i])
                {
                    case 'I':
                        if (i < s.Length - 1)
                        {
                            switch (s[i + 1])
                            {
                                case 'V':
                                    val = -1;
                                    break;
                                case 'X':
                                    val = -1;
                                    break;
                                default:
                                    val = 1;
                                    break;
                            }
                        }
                        else
                            val = 1;
                        break;
                    case 'X':
                        if (i < s.Length - 1)
                        {
                            switch (s[i + 1])
                            {
                                case 'L':
                                    val = -10;
                                    break;
                                case 'C':
                                    val = -10;
                                    break;
                                default:
                                    val = 10;
                                    break;
                            }
                        }
                        else val = 10;
                        break;
                    case 'C':
                        if (i < s.Length - 1)
                        {
                            switch (s[i + 1])
                            {
                                case 'D':
                                    val = -100;
                                    break;
                                case 'M':
                                    val = -100;
                                    break;
                                default:
                                    val = 100;
                                    break;
                            }
                        }
                        else
                            val = 100;
                        break;
                    case 'V':
                        val = 5;
                        break;
                    case 'L':
                        val = 50;
                        break;
                    case 'D':
                        val = 500;
                        break;
                    case 'M':
                        val = 1000;
                        break;
                    default:
                        val = 0;
                        break;
                }

                res = res + val;
            }

            return res;
        }

        #region LongestCommonPrefix
        /// <summary>
        /// My own solution
        /// </summary>
        /// <param name="strArray"></param>
        public void LongestCommonPrefix(string[] strArray)
        {
            string prefix = "";
            if (strArray.Length == 0)
                return;
            if (strArray.Length == 1)
                prefix = strArray[0];


            for (int i = 0; i < strArray.Length - 1; i++)
            {
                if (prefix == "")
                    prefix = Prefix(strArray[i], strArray[i + 1]);
                else
                    prefix = Prefix(prefix, strArray[i + 1]);
                if (prefix == "")
                    break;
            }

            Console.WriteLine(prefix);
        }

        private string Prefix(string a, string b)
        {
            string prefix = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (i > b.Length - 1)
                    break;
                if (a[i] == b[i])
                    prefix = prefix + a[i];
                else
                    break;
            }
            return prefix;
        }

        public void FindLongestCommonPrefix(string[] arr)
        {
            string prefix = "";
            if (arr.Length == 0)
                prefix = "";
            prefix = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                while (arr[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix == "")
                        break;
                }
            }

            Console.WriteLine(prefix);
        }

        #endregion

        public bool ValidParentheses(string s)
        {
            int length = s.Length;
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < length; i++)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                    stack.Push(s[i]);
                else if (s[i] == ')')
                {
                    if (stack.Count() == 0 || stack.Pop() != '(')
                        return false;
                }
                else if (s[i] == '}')
                {
                    if (stack.Count() == 0 || stack.Pop() != '{')
                        return false;
                }
                else if (s[i] == ']')
                {
                    if (stack.Count() == 0 || stack.Pop() != '[')
                        return false;
                }
            }

            if (stack.Count() == 0)
                return true;
            else
                return false;
        }

        //public ListNode MergeTwoLinkedLists(ListNode l1, ListNode l2)
        //{
        //    if (l1 == null && l2 == null)
        //        return null;
        //    else if (l1 == null)
        //        return l2;
        //    else if (l2 == null)
        //        return l1;
        //    else
        //    {
        //        if (l1.val < l2.val)
        //        {
        //            l1.next = MergeTwoLinkedLists(l1.next, l2);
        //            return l1;
        //        }
        //        else
        //        {
        //            l2.next = MergeTwoLinkedLists(l1, l2.next);
        //            return l2;
        //        }
        //    }

        //}

        /// <summary>
        /// Given an array nums and a value val, remove all instances of that value in-place and return the new length.
        /// </summary>
        /// <returns></returns>
        public int RemoveElement(int[] nums, int val)
        {
            int i = 0;

            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != val)
                {
                    nums[i] = nums[j];
                    i++;
                }
            }

            return i;
        }

        /// <summary>
        /// Return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
        /// </summary>
        /// <param name="haystack"></param>
        /// <param name="needle"></param>
        /// <returns></returns>
        //public int StrStr(string haystack, string needle)
        //{
        //    if (needle.Length == 0)
        //        return 0; 

        //    return haystack.IndexOf(needle);
        //}

        public int StrStr(string haystack, string needle)
        {
            int index = 0;
            if (needle.Length == 0)
                return index;

            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (haystack.Substring(i, needle.Length).Equals(needle))
                    return i;
            }

            return -1;
        }

        /// <summary>
        /// Given a sorted array and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.
        /// You may assume no duplicates in the array.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int SearchInsert(int[] nums, int target)
        {
            int i = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] == target)
                {
                    i = j;
                    break;
                }
                else if (target < nums[j])
                {
                    i = j;
                    break;
                }
                else
                    i++;
            }
            return i;
        }

        //public int SearchInsert(int[] nums, int target)
        //{
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (nums[i] >= target)
        //            return i;
        //    }
        //    return nums.Length;
        //}

        public int MaxSubArray(int[] nums)
        {
            int max = int.MinValue;
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum = sum + nums[i];
                if (max < sum)
                    max = sum;
                if (sum < 0)
                    sum = 0;
            }
            return max;
        }

        public int LengthOfLastWord(string s)
        {
            if (s.Length == 0)
                return 0;
            int count = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ' && count == 0)
                    continue;

                if (s[i] == ' ')
                    return count;
                count++;
            }

            return count;
        }

        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length <= 1)
                return s.Length;
            int initial = 0;
            int max = 0;
            int count = 1;

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[initial] != s[i + 1])
                    count++;
                else
                {
                    if (max < count)
                        max = count;
                    count = 1;
                    initial++;
                    i = initial++;
                }
            }

            return max;

            //int count = 0;
            //var dict = new Dictionary<char, int>();
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (!dict.ContainsKey(s[i]))
            //    {
            //        dict.Add(s[i], 1);
            //        count++;
            //    }
            //    else
            //    {
            //        if(i != s.Length - 1)
            //            count = 0;
            //    }
            //}

            //return count;
        }

        /// <summary>
        /// Given a non-empty array of digits representing a non-negative integer, plus one to the integer.
        /// The digits are stored such that the most significant digit is at the head of the list, and each element in the array contain a single digit.
        /// You may assume the integer does not contain any leading zero, except the number 0 itself.
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public int[] PlusOne(int[] digits)
        {
            int n = digits.Length;
            digits[n - 1] = digits[n - 1] + 1;
            int carry = digits[n - 1] / 10;
            digits[n - 1] = digits[n - 1] % 10;

            for (int i = n - 2; i >= 0; i--)
            {
                if (carry == 1)
                {
                    digits[i] = digits[i] + 1;
                    carry = digits[i] / 10;
                    digits[i] = digits[i] % 10;
                }
            }

            if (carry == 1)
            {
                Array.Resize(ref digits, n + 1);
                digits[0] = carry;
            }

            return digits;
        }

        /// <summary>
        /// Given two binary strings, return their sum (also a binary string).
        /// The input strings are both non-empty and contains only characters 1 or 0.
        /// Input: a = "11", b = "1"
        /// Output: "100"
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string AddBinary(string a, string b)
        {
            int carry = 0;
            int i = a.Length - 1;
            int j = b.Length - 1;
            string res = "";

            while (i >= 0 || j >= 0 || carry == 1)
            {
                int first = i >= 0 ? a[i] - '0' : 0;
                int second = j >= 0 ? b[j] - '0' : 0;

                int result = first + second + carry;
                carry = result / 2;
                res = result % 2 + res;

                i--;
                j--;
            }

            return res;
        }

        /// <summary>
        /// Compute and return the square root of x, where x is guaranteed to be a non-negative integer.
        /// Since the return type is an integer, the decimal digits are truncated and only the integer part of the result is returned.
        /// Input: 4
        /// Output: 2
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int MySqrt(int x)
        {
            long left = 0;
            long right = x;
            long result = 0;
            while (left <= right)
            {
                long mid = (left + right) / 2;

                if (mid * mid > x)
                    right = mid - 1;
                else if (mid * mid < x)
                {
                    left = mid + 1;
                    result = mid;
                }
                else
                    return (int)mid;
            }

            return (int)result;
        }

        /// <summary>
        /// Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array.
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="m"></param>
        /// <param name="nums2"></param>
        /// <param name="n"></param>
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;
            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[k] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[k] = nums2[j];
                    j--;
                }
                k--;
            }

            while (j >= 0)
            {
                nums1[k--] = nums2[j--];
            }

            for (int c = 0; c < nums1.Length; c++)
            {
                Console.Write(nums1[c] + " ");
            }
        }

        /// <summary>
        /// Pascal's Triangle
        /// Given a non-negative integer numRows, generate the first numRows of Pascal's triangle.
        /// </summary>
        /// <param name="numRows"></param>
        /// <returns></returns>
        public IList<IList<int>> Generate(int numRows)
        {
            var list = new List<IList<int>>();

            for (int i = 0; i < numRows; i++)
            {
                var row = new List<int>();
                if (i == 0)
                    row.Add(1);
                else
                {

                    for (int j = i; j >= 0; j--)
                    {
                        if (j == 0 || j == i)
                            row.Add(1);
                        else
                        {
                            row.Add(list[i - 1][j] + list[i - 1][j - 1]);
                        }
                    }
                }
                list.Add(row);
            }

            return list;
        }

        /// <summary>
        /// Given a non-negative index k where k ≤ 33, return the kth index row of the Pascal's triangle.
        /// Note that the row index starts from 0.
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <returns></returns>
        public IList<int> GetRow(int rowIndex)
        {
            var rows = new List<IList<int>>();

            for (int i = 0; i <= rowIndex; i++)
            {
                var row = new List<int>();
                if (i == 0)
                    row.Add(1);
                else
                {
                    for (int j = i; j >= 0; j--)
                    {
                        if (j == 0 || j == i)
                            row.Add(1);
                        else
                        {
                            row.Add(rows[i - 1][j] + rows[i - 1][j - 1]);
                        }
                    }
                }
                rows.Add(row);
                if (i == rowIndex)
                    break;
            }

            return rows[rowIndex];
        }

        /// <summary>
        /// Say you have an array for which the ith element is the price of a given stock on day i.
        /// If you were only permitted to complete at most one transaction(i.e., buy one and sell one share of the stock), design an algorithm to find the maximum profit.
        /// Note that you cannot sell a stock before you buy one.
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;

            for (int i = 0; i < prices.Length - 1; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    int profit = prices[j] - prices[i];

                    if (profit > maxProfit)
                        maxProfit = profit;
                }
            }

            return maxProfit;
        }

        /// <summary>
        /// Best Time to Buy and Sell Stock II
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int MaxProfitII(int[] prices)
        {
            int maxProfit = 0;

            for (int i = 0; i < prices.Length - 1; i++)
            {
                int profit = 0;
                int sellIndex = 0;
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (prices[j - 1] > prices[j])
                    {
                        break;
                    }

                    int currentProfit = prices[j] - prices[i];
                    if (currentProfit > profit)
                    {
                        profit = currentProfit;
                        sellIndex = j;
                    }
                }
                maxProfit += profit;
                if( sellIndex > 0)
                    i = sellIndex;
            }

            return maxProfit;
        }

        /// <summary>
        /// Given a non-empty array of integers, every element appears twice except for one. Find that single one.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumber(int[] nums)
        {
            int num = 0;


            return num;
        }

        /// <summary>
        /// Given the root of a binary tree, return the inorder traversal of its nodes' values.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> list = new List<int>();
            TraverseInorder(root, list);
            return list;
        }

        private void TraverseInorder(TreeNode root, IList<int> list)
        {

            if (root == null)
                return;
            TraverseInorder(root.left, list);
            list.Add(root.val);
            TraverseInorder(root.right, list);
        }

        /// <summary>
        /// Given the roots of two binary trees p and q, write a function to check if they are the same or not.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;
            else if (p == null || q == null)
                return false;

            if (p.val == q.val)
                return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
            else
                return false;
        }
        /// <summary>
        /// Given the root of a binary tree, return its maximum depth. 
        /// A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            int leftDepth = MaxDepth(root.left);
            int rightDepth = MaxDepth(root.right);

            if (leftDepth > rightDepth)
                return leftDepth + 1;
            else
                return rightDepth + 1;
        }

        public void test(int[] arr)
        {
            int[] a = new int[400];

            for (int i = 0; i < arr.Length; i++)
            {
                a[arr[i]]++;
            }
        }
    }
}

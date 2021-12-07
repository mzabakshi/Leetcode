using LeetcodeSolutions.LinkedListProblems;
using LeetcodeSolutions.TwoPointerProblems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            EasyProblems easy = new EasyProblems();

            //Console.WriteLine(easy.LengthOfLongestSubstring("abcabcbb"));
            //Console.WriteLine(easy.LengthOfLongestSubstring("bbbbb"));
            //Console.WriteLine(easy.LengthOfLongestSubstring("pwwkew"));

            //Console.WriteLine(easy.LengthOfLastWord("t "));

            //var nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            //Console.WriteLine(easy.MaxSubArray(nums));

            //var nums = new int[] { -1 };
            //Console.WriteLine(easy.MaxSubArray(nums));

            //var nums = new int[] { 1, 3, 5, 6 };
            //Console.WriteLine(easy.SearchInsert(nums, 5));
            //var nums2 = new int[] { 1, 3, 5, 6 };
            //Console.WriteLine(easy.SearchInsert(nums2, 2));
            //var nums3 = new int[] { 1, 3, 5, 6 };
            //Console.WriteLine(easy.SearchInsert(nums3, 7));
            //var nums4 = new int[] { 1, 3, 5, 6 };
            //Console.WriteLine(easy.SearchInsert(nums4, 0));

            //Console.WriteLine(easy.StrStr("hello", "ll"));

            //var nums = new int[] { 3, 2, 2, 3, 2 };
            //Console.WriteLine(easy.RemoveElement(nums, 3));

            //ListNode a1 = new ListNode(1);
            //a1.next = new ListNode(2);
            //a1.next.next = new ListNode(4);

            //ListNode b1 = new ListNode(1);
            //b1.next = new ListNode(3);
            //b1.next.next = new ListNode(6);
            //var mergedList  = easy.MergeTwoLinkedLists(a1, b1);
            //LinkedListProblems lp = new LinkedListProblems();
            //lp.PrintList(mergedList);



            //string inputParentheses = "(){}[]";
            //Console.Write(easy.ValidParentheses(inputParentheses));


            //string[] arrStr = new string[] { "flower", "flow", "flight" };
            //easy.LongestCommonPrefix(arrStr);
            //string[] arrStr2 = new string[] { "dog", "racecar", "car" };
            //easy.LongestCommonPrefix(arrStr2);
            //string[] arrStr3 = new string[] { "dog" };
            //easy.LongestCommonPrefix(arrStr3);
            //string[] arrStr4 = new string[] { "aca", "cba" };
            //easy.LongestCommonPrefix(arrStr4);

            //string[] arrStr = new string[] { "flower", "flow", "flight" };
            //easy.FindLongestCommonPrefix(arrStr);
            //string[] arrStr2 = new string[] { "dog", "racecar", "car" };
            //easy.FindLongestCommonPrefix(arrStr2);
            //string[] arrStr3 = new string[] { "dog" };
            //easy.FindLongestCommonPrefix(arrStr3);
            //string[] arrStr4 = new string[] { "aca", "cba" };
            //easy.FindLongestCommonPrefix(arrStr4); 


            //Console.WriteLine("XXIV: " + easy.RomanToInt("XXIV"));
            //Console.WriteLine("III: " + easy.RomanToInt("III"));
            //Console.WriteLine("IV: " + easy.RomanToInt("IV"));
            //Console.WriteLine("IX: " + easy.RomanToInt("IX"));

            //Console.WriteLine("LVIII: " + easy.RomanToInt("LVIII"));
            //Console.WriteLine("MCMXCIV: " + easy.RomanToInt("MCMXCIV"));
            //Console.WriteLine("MMCL: " + easy.RomanToInt("MMCL"));

            #region TwoSum Problem

            //int[] nums = new[] { 2, 7, 11, 15 };
            //int target = 9;

            //int[] nums = new[] { 230, 863, 916, 585, 981, 404, 316, 785, 88, 12, 70, 435, 384, 778, 887, 755, 740, 337, 86, 92, 325, 422, 815, 650, 920, 125, 277, 336, 221, 847, 168, 23, 677, 61, 400, 136, 874, 363, 394, 199, 863, 997, 794, 587, 124, 321, 212, 957, 764, 173, 314, 422, 927, 783, 930, 282, 306, 506, 44, 926, 691, 568, 68, 730, 933, 737, 531, 180, 414, 751, 28, 546, 60, 371, 493, 370, 527, 387, 43, 541, 13, 457, 328, 227, 652, 365, 430, 803, 59, 858, 538, 427, 583, 368, 375, 173, 809, 896, 370, 789 };
            //int target = 542; 

            //int[] result = easy.TwoSum(nums, target);
            //Console.WriteLine("The sum index are: ");
            //for (int i = 0; i < result.Length; i++)
            //{
            //    Console.WriteLine(result[i]);
            //}

            #endregion

            #region Reverse Integer 
            //Console.WriteLine("Reversed Number: " + easy.Reverse(123));
            //Console.WriteLine("Reversed Number: " + easy.Reverse(120));
            //Console.WriteLine("Reversed Number: " + easy.Reverse(-123)); 
            //Console.WriteLine("Reversed Number: " + easy.Reverse(-2147483648));
            #endregion


            //Console.WriteLine("Is number palindrom " + easy.IsPalindrome(-121));
            //Console.WriteLine("Is number palindrom " + easy.IsPalindromTakingHalf(123));

            //LinkedListProblems linkedlist = new LinkedListProblems();
            //ListNode l1 = new ListNode(2);
            //ListNode l12 = new ListNode(4);
            //ListNode l13 = new ListNode(3);
            //l12.next = l13;
            //l1.next = l12;

            //ListNode l2 = new ListNode(5);
            //ListNode l22 = new ListNode(6);
            //ListNode l23 = new ListNode(4);
            //l22.next = l23;
            //l2.next = l22;


            //var resultLinkedList = linkedlist.AddTwoNumbers(l1, l2);

            //easy.PlusOne(new int[] { 4, 3, 2, 1 });

            //Console.WriteLine( easy.AddBinary("11", "1"));
            //Console.WriteLine(easy.AddBinary("1010", "1011"));

            //Console.WriteLine(easy.MySqrt(8));
            //Console.WriteLine(easy.MySqrt(2147395600));

            //easy.Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3);

            //easy.Generate(5);

            //var a = easy.GetRow(3);

            //Console.WriteLine(easy.MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 }));
            //Console.WriteLine(easy.MaxProfit(new int[] { 7, 6, 4, 3, 1 }));

            //Console.WriteLine(easy.MaxProfitII(new int[] { 7, 1, 5, 3, 6, 4 }));
            //Console.WriteLine(easy.MaxProfitII(new int[] { 1, 2, 3, 4, 5 }));
            //Console.WriteLine(easy.MaxProfitII(new int[] { 7, 6, 4, 3, 1 }));

            //EasyLinkedListProblems easyLinkedListProblems = new EasyLinkedListProblems();
            //ListNode head = new ListNode(1);
            //ListNode n1 = new ListNode(1);
            //ListNode n2 = new ListNode(2);
            //ListNode n3 = new ListNode(3);
            //ListNode n4 = new ListNode(3);
            //head.next = n1;
            //n1.next = n2;
            //n2.next = n3;
            //easyLinkedListProblems.DeleteDuplicates(head);

            TwoPointers twoPointer = new TwoPointers();
            //Console.WriteLine(twoPointer.IsPalindrome("A man, a plan, a canal: Panama")); 
            //Console.WriteLine(twoPointer.IsPalindrome("race a car"));

            //TwoPointerProblems.ListNode node = new TwoPointerProblems.ListNode(3);
            //TwoPointerProblems.ListNode node2 = new TwoPointerProblems.ListNode(2);
            //TwoPointerProblems.ListNode node3 = new TwoPointerProblems.ListNode(0);
            //TwoPointerProblems.ListNode node4 = new TwoPointerProblems.ListNode(-4);
            //node.next = node2;
            //node2.next = node3;
            //node3.next = node4;
            //node4.next = node2;
            //Console.WriteLine(twoPointer.HasCycle(node));

            //TwoPointerProblems.ListNode t2node = new TwoPointerProblems.ListNode(1);
            //TwoPointerProblems.ListNode t2node2 = new TwoPointerProblems.ListNode(2);
            //t2node2.next = t2node;
            //t2node.next = t2node2;
            //Console.WriteLine(twoPointer.HasCycle(t2node));

            //Console.WriteLine(twoPointer.HasCycle(null));

            //TwoPointerProblems.ListNode t3node = new TwoPointerProblems.ListNode(1);
            //Console.WriteLine(twoPointer.HasCycle(t3node));

            //var twoSumArr = twoPointer.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            //Console.WriteLine($"[{twoSumArr[0]},{twoSumArr[1]}]");
            //twoSumArr = twoPointer.TwoSum(new int[] { 2, 3, 4 }, 6);
            //Console.WriteLine($"[{twoSumArr[0]},{twoSumArr[1]}]");
            //twoSumArr = twoPointer.TwoSum(new int[] { -1,0 }, -1);
            //Console.WriteLine($"[{twoSumArr[0]},{twoSumArr[1]}]");

            //twoPointer.MoveZeroes(new int[] { 0, 1, 0, 3, 12 });
            //twoPointer.MoveZeroes(new int[] { 0,0,1 });

            //twoPointer.ReverseString(new char[] { 'h', 'e', 'l', 'l', 'o' });
            //twoPointer.ReverseString(new char[] { 'H', 'a', 'n', 'n', 'a', 'h' });

            //foreach (var item in twoPointer.ReverseVowels("hello"))
            //{
            //    Console.Write(item);
            //}
            //Console.WriteLine();
            //foreach (var item in twoPointer.ReverseVowels("leetcode"))
            //{
            //    Console.Write(item);
            //}
            //Console.WriteLine();
            //foreach (var item in twoPointer.ReverseVowels("aA"))
            //{
            //    Console.Write(item);
            //}

            //Console.WriteLine(twoPointer.BackspaceCompare("ab#c", "ad#c"));
            //Console.WriteLine(twoPointer.BackspaceCompare("ab##", "c#d#"));
            //Console.WriteLine(twoPointer.BackspaceCompare("a##c", "#a#c"));
            //Console.WriteLine(twoPointer.BackspaceCompare("a#c", "b"));
            //Console.WriteLine(twoPointer.BackspaceCompare("#", "b"));
            //Console.WriteLine(twoPointer.BackspaceCompare("", ""));


            //Console.WriteLine(twoPointer.IsLongPressedName("alex", "aaleex"));
            //Console.WriteLine(twoPointer.IsLongPressedName("saeed", "ssaaedd"));
            //Console.WriteLine(twoPointer.IsLongPressedName("leelee", "lleeelee"));
            //Console.WriteLine(twoPointer.IsLongPressedName("laiden", "laiden"));

            //twoPointer.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 

            //TwoPointerProblems.ListNode node = new TwoPointerProblems.ListNode(1);
            //TwoPointerProblems.ListNode node2 = new TwoPointerProblems.ListNode(2);
            //TwoPointerProblems.ListNode node3 = new TwoPointerProblems.ListNode(3);
            //TwoPointerProblems.ListNode node4 = new TwoPointerProblems.ListNode(4);
            //TwoPointerProblems.ListNode node5 = new TwoPointerProblems.ListNode(5);
            //node.next = node2;
            //node2.next = node3;
            //node3.next = node4;
            //node4.next = node5;
            //var  a = twoPointer.RemoveNthFromEnd(node, 2);

            //TwoPointerProblems.ListNode node = new TwoPointerProblems.ListNode(1);
            //TwoPointerProblems.ListNode node2 = new TwoPointerProblems.ListNode(2);
            //node.next = node2;
            //twoPointer.RemoveNthFromEnd(node, 1);

            //MediumProblems mediumProblems = new MediumProblems();
            //Console.WriteLine(mediumProblems.Divide(10, 3)); 
            //Console.WriteLine(mediumProblems.Divide(-2147483648, -1)); //this condition fails

            //Console.WriteLine();

            //TreeNode t1 = new TreeNode(1);
            //TreeNode t2 = new TreeNode(2);
            //TreeNode t3 = new TreeNode(3);
            //t2.left = t3;
            //t1.right = t2;
            //var inorderList = easy.InorderTraversal(t1);
            //foreach (var item in inorderList)
            //{
            //    Console.WriteLine(item);
            //}

            //TreeNode t12 = new TreeNode(1);
            //var inorderList2 = easy.InorderTraversal(t12);
            //foreach (var item in inorderList2)
            //{
            //    Console.WriteLine(item);
            //}

            //var inorderList2 = easy.InorderTraversal(null);
            //foreach (var item in inorderList2)
            //{
            //    Console.WriteLine(item);
            //}

            //TreeNode t14 = new TreeNode(1, null, new TreeNode(2));
            //var inorderList = easy.InorderTraversal(t14);
            //foreach (var item in inorderList)
            //{
            //    Console.WriteLine(item);
            //}

            //TreeNode p = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            //TreeNode q = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            //TreeNode p = new TreeNode(1, new TreeNode(2));
            //TreeNode q = new TreeNode(1, null, new TreeNode(2));
            //TreeNode p = new TreeNode(1, new TreeNode(2), new TreeNode(1));
            //TreeNode q = new TreeNode(1, new TreeNode(1), new TreeNode(2));

            //TreeNode p = new TreeNode(1, new TreeNode(1));
            //TreeNode q = new TreeNode(1, null, new TreeNode(1));
            //Console.WriteLine(easy.IsSameTree(p, q));

            //easy.test(new int[] { 2, 4, 5, 1, 2, 3, 4, 4, 4, 4, 300, 99, 300, 300 });

            MediumProblems m = new MediumProblems();
            m.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });

            Console.ReadLine();
        }
    }
}

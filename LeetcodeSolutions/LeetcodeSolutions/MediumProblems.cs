using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolutions
{
    public class MediumProblems
    {
        // Fails for certain conditions
        public int Divide(int dividend, int divisor)
        {
            //Base Cases
            if (divisor == 1)
            {
                return dividend;
            }
            if (dividend == int.MinValue && divisor == -1)
            {
                return int.MinValue;
            }


            int result = 0;
            int a = dividend < 0 ? -dividend : dividend;
            int b = divisor < 0 ? -divisor : divisor;

            while (a - b >= 0)
            {
                int x = 0;
                while (a - (b << x) >= 0)
                { 
                    x++;
                }
                x--;

                result += 1 << x;
                a -= b << x;      
            }

            return (dividend >= 0) == (divisor >= 0) ? result : -result;
        }

        //Given an integer array nums, return all the triplets[nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
        //Notice that the solution set must not contain duplicate triplets.
        public IList<IList<int>> ThreeSum_VeryExpensive_BruteForced_Solution(int[] nums)
        {
            var list = new List<IList<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    for (int k = 0; k < nums.Length; k++)
                    {
                        if(i != j && i != k && j != k)
                        {
                            if (nums[i] + nums[k] + nums[j] == 0)
                            {
                                var tempList = new List<int>();
                                tempList.Add(nums[i]);
                                tempList.Add(nums[j]);
                                tempList.Add(nums[k]);
                                tempList.Sort();
                                bool exist = false;
                                foreach (var item in list)
                                {
                                    if (item[0] == tempList[0] && item[1] == tempList[1] && item[2] == tempList[2])
                                    {
                                        exist = true;
                                        break;
                                    }
                                }
                                if(!exist)
                                    list.Add(tempList);  
                            }
                        }
                    }
                }
            }

            return list;
        }

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var list = new List<IList<int>>();

            for (int i = 0; i < nums.Length - 1; i++)
            {
                var hashSet = new HashSet<int>();
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int sum = (nums[i] + nums[j]) * -1;
                    if (hashSet.Contains(sum))
                    {
                        int[] arr = new int[] { nums[i], nums[j], sum };
                        list.Add(arr);
                    }
                    else
                        hashSet.Add(nums[j]);
                }
            }

            return list;

        }
    }
}

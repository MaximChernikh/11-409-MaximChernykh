﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Переворачивает массив
namespace _11409_MaximChernykh.ReverseArrayNamespace
{
    internal class ReversingArray
    {
        public int[] ReverseArray()
        {
            int[] nums = new int[10];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
            }

            for (int i = nums.Length - 1; i > -1; i -= 1)
            {
                nums[nums.Length - 1 - i] = i;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(nums[i]);
            }
            return nums;
        }
    }
}

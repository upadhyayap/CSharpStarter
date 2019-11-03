using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpStarter.src.main.Array
{
    class ArrayTest
    {
        public void printArray()
        {
            int[] nums = new int[10];

            for(int i = 0; i <nums.Length; i++)
            {
                Console.WriteLine("Value is : {0}", i);
            }
        }
    }
}

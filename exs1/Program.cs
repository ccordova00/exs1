using System;
using System.Linq;
using System.Collections.Generic;

namespace exs1
{
    class Program
    {
        static void Main(string[] args)
        {
            // single dimensional array
            int [] array1 = { 1, 2, 3, 3, 5, 6, 7, 8, 3, 2, 3, 5 };
            // multidimensional array
            int[,] array2 = new int[10, 10];
            
            Console.WriteLine("Highest number: {0}", array1.Max());
            int half = array1.Length /2;

            Console.WriteLine("Midpoint of array. point:{0}, value:{1}", half, array1[half]);

            //finding first repeating value

            for (int i = 0; i < array1.Length; i++)
            {
                bool found = false; 
                Console.WriteLine("Testing " + array1[i]);

                for(int j = i + 1; j < array1.Length; j++)
                {
                    Console.WriteLine("Testing {0} with {1}", array1[i], array1[j]);
                    if (array1[i] == array1[j])
                    {
                       Console.WriteLine("Eureka! {0} and {1} are equal!", array1[i], array1[j]);
                        found = true;
                        break;
                    }
                }
                if (found)
                    break;
            }

            //accessing items in a 2d array
            int row = 0;
            int col = 0;
            for (; row < 10; row++)
            {
                array2[row,col] = row;
                for(; col < 10; col++)
                {
                    Console.WriteLine("row = {0} col = {1}", row, col);
                    array2[row, col] = col;
                }
                col = 0;
            }
        
        Console.ReadLine();
        }
    }
}

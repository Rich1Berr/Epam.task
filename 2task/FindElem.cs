using System;

namespace FindElement
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Console.Write("Enter array demention:");    
            byte length_arr = byte.Parse(Console.ReadLine());
            if (length_arr <= 0) 
            {
                Console.WriteLine("Wrong length");
                return;
            }
            int[] array = new int[length_arr];

            Console.WriteLine("Enter elemets mas:");
            try
            {
                for (byte i = 0; i < length_arr; i++)
                {
                    array[i] = Int32.Parse(Console.ReadLine());
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }

            Console.Write("Enter the number to find:");
            int number_for_find = int.Parse(Console.ReadLine());

            ArraySort(ref array, length_arr);

            FindElementArray(array, length_arr, number_for_find);
        }

        static void ArraySort(ref int[] array, byte length_arr)
        {
            Array.Sort(array);
        }

        public static void FindElementArray(int[] array, byte length_arr, int number_for_find)
        {
            foreach (var number in array)
            {
                if (number == number_for_find)
                {
                    Console.WriteLine("Yes");
                    return;
                }
            }
            Console.WriteLine("No");
        }
        
        
    }
}
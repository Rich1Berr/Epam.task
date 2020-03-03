using System;

namespace SortArray
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter array demention:");    // Ввод размерности
            byte length_arr = byte.Parse(Console.ReadLine());
            if (length_arr <= 0) 
            {                     
                Console.WriteLine("Wrong length");       //Вывод сообщения об ошибке
                return;
            }
            int[] array = new int[length_arr]; 
            
            Console.WriteLine("Enter elemets mas:");    //Ввод элементов массива
            try
            {
                for (byte i = 0; i < length_arr; i++)
                {
                    array[i] = Int32.Parse(Console.ReadLine());
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }

            Console.WriteLine("Before sort:");              //Вывод до сорт.
            DisplayValues(array, length_arr);
            
            ArraySort(ref array, length_arr);

            Console.WriteLine("After sort:");              //Вывод после сорт.
            DisplayValues(array, length_arr);
        }

        static void ArraySort(ref int[] array, byte length_arr)
        {
            Array.Sort(array);                            //Метод сортировки 
        }

        public static void DisplayValues(int[] array, byte length_arr)
        {
            foreach (var number in array)
            {
                Console.WriteLine(number);
            }
        }
    }
}
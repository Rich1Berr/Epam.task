using System;



namespace WordFinder
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            sbyte count_word;

            Console.Write("Введите строку: "); 
            string str = Console.ReadLine();

            string[] str_split = str.Split();

            string[] new_str = new string[str_split.Length];
            int count_for_new_str = 0;

            for (int i = 0; i < str_split.Length; i++)
            {
                count_word = 0;
                for (int j = 0; j < str_split.Length; j++)
                {
                    if (str_split[i] == str_split[j])
                    {
                        count_word++;
                    }
                }

                if (count_word == 1)
                {
                    new_str[count_for_new_str++] = str_split[i];
                }
                
            }

            foreach (var element in new_str)
            {
                Console.WriteLine(element);
            }

        }
    }
}
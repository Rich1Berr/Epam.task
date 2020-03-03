using System;

class Factorial
{
    public static int Main()
    {
        Console.Write("Enter number : ");         //Ввод числа
        sbyte num = sbyte.Parse(Console.ReadLine());
        long factorial = 1;         

        if (num < 0) { Console.Write("Wrong number"); return 0; }   //Условие для отрицательных чисел
       
        for (sbyte i = 2; i <= num; i++)
        {
            factorial *= i;     //подсчёт факториала
        }

        Console.Write("{0}! = {1}",num, factorial);   //Вывод заданного числа и результата
        return 0;
     
    }
}
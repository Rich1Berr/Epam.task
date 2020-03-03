using System;
using System.Collections.Generic;
using System.Linq;

namespace WriteSequence
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Stack<char> stack_parenthesis = new Stack<char>();
            
            Console.Write("Enter the text: ");
            string text = Console.ReadLine();
            
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '(' || text[i] == '[' || text[i] == '{') { stack_parenthesis.Push(text[i]); }

                if (text[i] == ')' || text[i] == ']' || text[i] == '}')
                {
                    if (stack_parenthesis.Count == 0) {
                        Console.WriteLine("Wrong Sequence");
                        return;
                    }
                    char symbol = stack_parenthesis.Peek();
                    if (text[i] == ')' && symbol == '(' ||
                        text[i] == ']' && symbol == '[' ||
                        text[i] == '}' && symbol == '{'   ) { stack_parenthesis.Pop(); }
                    else { return; }
                }
            }
            
            if (stack_parenthesis.Count == 0) { Console.WriteLine("Write sequence"); }
            else { Console.WriteLine("Wrong Sequence"); }
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;

namespace AADS_LR3_Task2
{
    internal class Program
    {
        static Stack<int> CreateStackFromLines(string filePath)
        {
            Stack<int> stack = new Stack<int>();

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                stack.Push(line.Length);
            }
            return stack;
        }
        static void ClearStack(Stack<int> stack)
        {
            stack.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Стек очищено.");
            Console.ResetColor();
        }
        static void PushElement(Stack<int> stack, int element)
        {
            stack.Push(element);
            Console.WriteLine($"Елемент {element} додано до стека.");
        }
        static int PopElement(Stack<int> stack)
        {
            if (stack.Count > 0)
            {
                int removedElement = stack.Pop();
                Console.WriteLine($"Елемент {removedElement} видалено зi стека.");
                return removedElement;
            }
            else
            {
                Console.WriteLine("Стек порожнiй.");
                return -1; 
            }
        }
        static void PrintStack(Stack<int> stack)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Вмiст стека:");
            Console.ResetColor();
            foreach (int length in stack)
            {
                Console.WriteLine(length);
            }
        }
        static void FindShortestLine(Stack<int> stack, string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            int shortestLength = int.MaxValue;
            int shortestIndex = -1;

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Length < shortestLength)
                {
                    shortestLength = lines[i].Length;
                    shortestIndex = i + 1;  
                }
            }
            Console.WriteLine($"Номер найкоротшого рядка: {shortestIndex}");
            Console.WriteLine($"Довжина найкоротшого рядка: {shortestLength}");
        }
        static void Main(string[] args)
        {
            string filePath = @"C:\\Users\\Анастасія\\source\\repos\\AADS_LR3_Task2\\AADS_LR3_Task2\file.txt"; 

            Stack<int> stack = CreateStackFromLines(filePath);

            PrintStack(stack);

            FindShortestLine(stack, filePath);

            ClearStack(stack);
        }
    }
}

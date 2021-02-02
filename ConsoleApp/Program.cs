using DataStructures;
using System;


namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            Stack<char> stack = new(0);
            //CharSequence(stack);
            Console.WriteLine(CheckIfPalindrome(stack));
        }

        private static void CharSequence(Stack<char> stack)
        {
            stack.Push(stack, 'h');
            stack.Push(stack, 'e');
            stack.Push(stack, 'l');
            stack.Push(stack, 'l');
            stack.Push(stack, 'o');
            for(int i = stack.Count - 1; i >= 0; i--)
            {
                Console.Write(stack.Items[i]);
            }
        }

        private static bool CheckIfPalindrome(Stack<char> stack)
        {
            stack.Push(stack, 'r');
            stack.Push(stack, 'e');
            stack.Push(stack, 'j');
            stack.Push(stack, 'e');
            stack.Push(stack, 'r');

            int j = stack.Count - 1;
            for(int i = 0; i < stack.Count - 1; i++)
            {
                if(stack.Items[i] != stack.Items[j])
                {
                    return false;
                }
                j--;
            }
            return true;
        }
    }
}   
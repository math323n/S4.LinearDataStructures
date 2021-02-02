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


        // unoptimized code
        public static void TowerOfHanoi(Stack<char> stack)
        {
            Move(stack.Count, 'A', 'C', 'B');
        }

        public static void Move(int n, char from_rod, char to_rod, char aux_rod)
        {
            if(n == 1)
            {
                Console.WriteLine("Move disk 1 from rod " +
                                  from_rod + " to rod " + to_rod);
                return;
            }
            Move(n - 1, from_rod, aux_rod, to_rod);
            Console.WriteLine("Move disk " + n + " from rod " +
            from_rod + " to rod " + to_rod);
            Move(n - 1, aux_rod, to_rod, from_rod);
        }
    }
}   
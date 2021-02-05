using DataStructures;
using System;
using System.Threading;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            Stack<char> stack = new(0);
            //CharSequence(stack);
            for(int i = 0;  i >= 0; i++)
            {
                Console.WriteLine(CheckIfPalindrome(stack));
            }
                

            // TowerOfHanoi(stack);
            Queue<char> myQueue = new(0);
            PrintQueue(myQueue);

        }

        private static void CharSequence(Stack<char> stack)
        {
            stack.Push('h');
            stack.Push('e');
            stack.Push( 'l');
            stack.Push('l');
            stack.Push('o');
            for(int i = stack.Count - 1; i >= 0; i--)
            {
                Console.Write(stack.Items[i]);
            }
        }

        private static void PrintQueue(Queue<char> queue)
        {

            queue.Add('F');
            queue.Add('I');
            queue.Add('L');
            queue.Add('O'); 
            queue.Inverse();
            foreach(char c in queue.Items)
            {
                Console.Write(c);
                Thread.Sleep(500);
            }
        }

        private static bool CheckIfPalindrome(Stack<char> stack)
        {
            stack.Push('r');
            stack.Push('e');
            stack.Push('j');
            stack.Push('e');
            stack.Push('r');

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
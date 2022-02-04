using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the stack and queue programs");
            Console.WriteLine("Stack Operations");
            Console.WriteLine("\n1.Push operation");
            Console.WriteLine("\n2.Pop operation");
            Console.WriteLine("\n3.Peek operation");
            Console.WriteLine("\n4.isEmpty operation");

            //Creating node a top
            int num = Convert.ToInt32(Console.ReadLine());
            Stack stack = new Stack();
            switch (num)
            {
                case 1:
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.Display();
                    break;
                case 2:
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.Pop();
                    stack.Display();
                    break;
                case 3:
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.Peek();
                    stack.Display();
                    break;
                case 4:
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.IsEmpty();
                    stack.Display();
                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;
            }
            Console.ReadLine();
        }
    }

    
}
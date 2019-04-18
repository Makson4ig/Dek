using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Deque<string> usersDeck = new Deque<string>();
            string s = Console.ReadLine();
            //EAs+Y+QUE**+st+*+IO*n++*
            foreach (char c in s)
            {
                if (Regex.IsMatch(c.ToString(), @"[A-Z]"))
                {
                    usersDeck.AddFirst(c.ToString());
                }
                else if (Regex.IsMatch(c.ToString(), @"[a-z]"))
                {
                    usersDeck.AddLast(c.ToString()); 
                }
                else if (c.ToString() == "+")
                {
                    usersDeck.RemoveFirst();
                }
                else if (c.ToString() == "*")
                {
                    usersDeck.RemoveLast();
                }
            }

            foreach (string i in usersDeck)
                Console.WriteLine(i);
            Console.WriteLine("Выполнено!");
            Console.ReadKey();
        }
    }

    public class DoublyNode<T>
    {
        public DoublyNode(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public DoublyNode<T> Previous { get; set; }
        public DoublyNode<T> Next { get; set; }
    }
}

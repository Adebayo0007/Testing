using System;

namespace num1
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write($"enter your name : ");
            string user = Console.ReadLine();
           UserName(user);
        }
        public static void UserName(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}

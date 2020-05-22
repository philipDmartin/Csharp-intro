using System;

namespace Intro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1.
            //refrencing other classes
            var c1 = new MyClass();
            Console.WriteLine($"Hello World! {c1.ReturnMessage()}");

            //2.
            //readline to hold users response
            Console.Write("What is your first name? ");
            string name = Console.ReadLine();

            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine();

            Console.Write("Where do you live?");
            string address = Console.ReadLine();

            Console.WriteLine($"Hello, {name} {lastName}! I'm glad to meet you. {address} is an awsome place to live!");
        }
    }
}

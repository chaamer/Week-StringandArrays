using System;

namespace FruitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruit= new string[5] { "apple", "banana", "lemon", "apple", "orange" };

            //Console.WriteLine(fruit[0]);
            //Console.WriteLine(fruit[1]);

            //Console.WriteLine("Enter number:");
            //int userNumber = Convert.ToInt32(Console.ReadLine());
           
            Random rnd = new Random();
            int userNumber = rnd.Next(0, fruit.Length);

            Console.WriteLine($"Today you will have {fruit[userNumber]}");

        }
    }
}

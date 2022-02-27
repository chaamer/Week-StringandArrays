using System;

namespace Helloworldreversed
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kirjutada luase Hello world tagurpidi

            Console.WriteLine("Hello world");
            string Name = "hello world";

            for (int i = Name.Length - 1; i >= 0; i--)
            {
                Console.Write(Name[i]);
            }
        }
    }
}

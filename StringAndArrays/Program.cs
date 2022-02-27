using System;

namespace StringAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sisesta nimi ning siis kuvatakse selle pikkus

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();

            int firstNameLenght = firstName.Length;
            Console.WriteLine($"Sinu eesnimes on {firstName.Length} tähte.");
        }
    }
}

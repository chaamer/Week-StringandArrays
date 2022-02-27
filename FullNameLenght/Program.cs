using System;

namespace FullNameLenght
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sisesta ees ja prenime ning siis kuvatakse kumb on pikkem
            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Sisesta perenimi:");
            string lastName = Console.ReadLine();

            int firstNameLenght = firstName.Length;
            Console.WriteLine($"Sinu eesnimes on {firstName.Length} tähte.");

            int lastNameLenght = lastName.Length;
            Console.WriteLine($"Sinu perenimes on {lastName.Length} tähte.");

            if (firstNameLenght < lastNameLenght )
            {
                Console.WriteLine("Perenimi on pikkem");
                
            }
            else
            {
                
                Console.WriteLine("Eesnimi on pikkem");
            }
        }
    }
}

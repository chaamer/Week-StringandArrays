using System;

namespace CaracterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sisesta ees - ja perenimi
            //Kuvatakse, mitu 'a' tähte nimes on

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine().ToLower();
            Console.WriteLine("Sisesta perenimi:");
            string lastName = Console.ReadLine().ToLower();

            string fullName = $"{firstName}{lastName}";

            int aCounter = 0;

            for(int i = 0; i < fullName.Length; i++)
            {
                if (fullName [i] == 'a')
                {
                    aCounter++;
                }
                Console.WriteLine($"Sinu nimes on {aCounter} 'a' tähte");
            }
        }
    }
}

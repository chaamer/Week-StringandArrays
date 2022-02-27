using System;

namespace Dontpanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //o tähendab asendatakse 0-ga
            //a tähed 4-ga

            string Name = "Don't Panic";

            /*for(int i = 0; i < helloW.Lenght; i++)
            {
                helloW[i] = "*"
            }*/

            Name = Name.Replace('o', '0');
            Name = Name.Replace('a', '4');
            Console.WriteLine(Name);
        }

    }
}

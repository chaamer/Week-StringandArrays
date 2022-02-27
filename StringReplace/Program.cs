using System;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kõik "o" tähed asendatakse tärniga

            string helloW = "Hello World!";

            /*for(int i = 0; i < helloW.Lenght; i++)
            {
                helloW[i] = "*"
            }*/

            helloW = helloW.Replace('o', '*');
                Console.WriteLine( helloW);
        }
    }
}

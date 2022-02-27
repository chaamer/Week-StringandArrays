using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {

            //Mitu HOL tähte on sõnas Hello world

            Console.WriteLine("Hello World");
            string Name = "hello world";


            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for (int i = 0; i < Name.Length; i++)
            {
                if (Name[i] == 'h')
                {
                    hCounter++;
                }
                
            }



            for (int i = 0; i < Name.Length; i++)
            {
                if (Name[i] == 'o')
                {
                    oCounter++;
                }

            }

            for (int i = 0; i < Name.Length; i++)
            {
                if (Name[i] == 'l')
                {
                    lCounter++;
                }

            }

            Console.WriteLine($"Sõnas 'Hello World' on {oCounter} 'o' täht(e), {hCounter} 'h' täht(e) ning {lCounter} 'l' täht(e).");
        }
    }
}

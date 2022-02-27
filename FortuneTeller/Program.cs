using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ennustab, mis tulevik toob homme

            string[] predictions = { "win a million", "love", "buy stuff", "join club" };

            Random rnd = new Random();
            int userNumber = rnd.Next(0, predictions.Length);

            Console.WriteLine($"Today you will {predictions[userNumber]}");
        }
    }
}

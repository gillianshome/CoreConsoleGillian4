using System;
using System.Threading;

namespace CoreConsoleGillian
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 10)
            {
                Thread.Sleep(2000);
                Console.WriteLine(GetLetter());
                i++;
            }
        }

        private static char GetLetter()
        {
            const string chars = "1234567890qwertyuiopasdfghjklzxcvbnm!\"£$%^&*()";
            var rand = new Random();
            var num = rand.Next(0, chars.Length - 1);
            return chars[num];
        }
    }
}

using System;

namespace Uppgift_5._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nummer = new int[5];
            Random rnd = new Random();
            for (int i = 0; i < nummer.Length; i++)
            {
                nummer[i] = rnd.Next(10, 99);
            }
            for(int i = 0;i < nummer.Length;i++)
            {
                PrintNumber(nummer[i]);
                if(nummer.Length - 1 != i)
                    Task.Delay(1500).Wait();

            }
        }

        static void PrintNumber(int num)
        {
            var text = num.ToString();
            for (int i = 0; i < text.Length; i++)
            {
                var t = i != text.Length - 1 ? text[i].ToString() : $"{text[i]}\n";
                Console.Write(t);
                Task.Delay(500).Wait();
            }
        }
    }
}
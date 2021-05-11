using System;

namespace vetor2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numero = null;
            numero = new int[15];

            for (var i = 0; i < 15; i++)
            {
                Console.WriteLine($"Digite o numero {(i + 1)}° número");
                numero[i] = int.Parse(Console.ReadLine());
            }

            for (var j = 14; j >= 0; j--)
            {
                Console.WriteLine(numero[j]);
            }
        }
    }
}

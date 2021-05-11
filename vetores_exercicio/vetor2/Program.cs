using System;

namespace vetor2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numero = new int[3];
           
            Console.WriteLine($"Digite {numero.Length} números");

            for (var i = 0; i < numero.Length; i++)
            {
                Console.WriteLine($"Digite o {(i + 1)}° número");
                numero[i] = int.Parse(Console.ReadLine());
            }

            for (var i = (numero.Length - 1); i >= 0; i--)
            {
                Console.WriteLine($"\n{numero[i]}");
            }
        }
    }
}

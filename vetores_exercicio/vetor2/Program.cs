using System;

namespace vetor2
{
    class Program
    {
        static void Main(string[] args)
        {
        int[] numeros;
        numeros = new int[14];

            for ( int i = 14; i <= 14; i--)
            {
                 Console.WriteLine($"Digite o {i + 1}° numero");
                 numeros[i] = int.Parse(Console.ReadLine()); 
              
            }

              // Console.WriteLine($"{numeros}");
        }
    }
}

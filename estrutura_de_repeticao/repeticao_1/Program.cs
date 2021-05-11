using System;

namespace repeticao_1
{
    class Program
    {
        static void Main(string[] args)
        {
        int[] numeros = new int[10];

        Console.WriteLine($"Digite {numeros.Length} valores");
		
		for (int i= 0;  i< numeros.Length; i++)
		{
			Console.Write($"Digite {(i+1)}° número: ");
			numeros[i] = int.Parse(Console.ReadLine());
		}
		
        Array.Sort(numeros);
        Console.WriteLine($"O maior número é {numeros [(numeros.Length - 1)]} e o menor é {numeros [0]}");

        }
    }
}

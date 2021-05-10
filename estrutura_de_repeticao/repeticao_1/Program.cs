using System;

namespace repeticao_1
{
    class Program
    {
        static void Main(string[] args)
        {
       

     int[] numeros = new int[10];
		
		for (int i=0;  i<10; i++)
		{
			Console.Write($"Digite {(i+1)}° número: ");
			numeros[i] = Convert.ToInt32(Console.ReadLine());
		}
		
        Array.Sort(numeros);
        Console.WriteLine($"O maior número é {numeros [0]} e o menor é {numeros [9]}");
		//foreach ( numeros [0] && numeros [10]) Console.WriteLine(p);

    
        

        }
    }
}

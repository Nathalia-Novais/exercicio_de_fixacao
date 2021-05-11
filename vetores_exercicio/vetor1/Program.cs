using System;

namespace vetor1
{
    class Program
    {
        static void Main(string[] args)
        {
           string [] nome = new string [10];
           
           Console.WriteLine($"Digite o nome de {nome.Length} pessoas");
		
	     	for (int i=0;  i<nome.Length ; i++)
		{
			Console.Write($"Digite o {(i+1)}° nome: ");
			nome [i] = Console.ReadLine();
		}

        Console.WriteLine("Qual o nome você deseja procurar?");
        string nomelista = Console.ReadLine();
        bool encontrado = false;


        foreach (var item in nome)
        {
            if ( item == nomelista)
            {
                encontrado = true;
            }
        }

            if (encontrado)
            {
                 Console.WriteLine("Achei!");
            }
            else
            {
                 Console.WriteLine("Desculpe não achei");  
            }

             
             

           
        }
    }
}

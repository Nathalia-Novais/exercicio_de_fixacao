using System;

namespace vetor1
{
    class Program
    {
        static void Main(string[] args)
        {
           string [] nome = new string [10];
           
		
	     	for (int i=0;  i<10; i++)
		{
			Console.Write($"Digite o {(i+1)}° nome: ");
			nome [i] = Console.ReadLine();
		}

        Console.WriteLine("Qual o nome você deseja procurar?");
         string nomelista = Console.ReadLine();

        foreach (var item in nome)
        {
            if ( item == nomelista)
            {
                Console.WriteLine("Achei!");
            }
          // else
          //  {
          //   Console.WriteLine("Desculpe não achei");
           // }
        }
        }
    }
}

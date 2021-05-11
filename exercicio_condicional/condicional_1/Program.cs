using System;

namespace condicional_1
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int anoatual = DateTime.Now.Year;

            Console.WriteLine("Qual é o ano do seu nascimento?");
            int nascimento = int.Parse(Console.ReadLine());

            int idade  = anoatual - nascimento;

            if (idade < 16)
            {
                  Console.WriteLine("Você não tem idade para votar ainda!");
            
            }else if (idade >=16 && idade <18)
            {
                 Console.WriteLine("Você já pode votar!");
          
            }else
            {
                  Console.WriteLine("Você é obrigado a votar!");
            }

        }
    }
}

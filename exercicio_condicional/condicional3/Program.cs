using System;

namespace condicional3
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Qual o nome do seu produto?");
             string nome = Console.ReadLine();

             Console.WriteLine("Qual é a quantidade de " + nome + " você tem?");
             int quantidade = int.Parse(Console.ReadLine());

             Console.WriteLine("Quanto custa o preço unitário do seu produto?" );
             double preco = double.Parse(Console.ReadLine());
             
             Console.WriteLine($"o valor total que você ira pagar é de: R${(quantidade * preco).ToString("N2")}" );

             double total = quantidade * preco;

             if (quantidade <=5 )
             {
                double desconto2 = total * 0.98; 
                Console.WriteLine("O total que você ira pagar com desconto: " + desconto2 );
                
                }
            
             else if (quantidade >5 && quantidade <10)
             {
                double desconto3 = total * 0.97;
                Console.WriteLine("O total que você ira pagar com desconto: " + desconto3 );
             }
              else 
             {
                double desconto5 = total * 0.95;
                Console.WriteLine("O total que você ira pagar com desconto: " + desconto5 );
             }
            

        }
    }
}

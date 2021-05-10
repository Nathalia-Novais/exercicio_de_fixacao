using System;

namespace condicional2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o tipo de combustivel você ira usar?\n Gasolina 'G' Álcool 'A'");
            string tipocombustivel =(Console.ReadLine().ToLower());

            Console.WriteLine("Quantos litros?");
            double litros = double.Parse(Console.ReadLine());

            //gasolina

             double gasolinapreco = 0;

            if (tipocombustivel == "g")
            {
                gasolinapreco = litros * 5.30;

             if (litros <20){

               double desconto4 = gasolinapreco * 0.96;
               Console.WriteLine("você vai pagar:" + desconto4 + " reais");

              } else
              {
                   double desconto6 = gasolinapreco * 0.94;
                   Console.WriteLine("você vai pagar:" + desconto6 + " reais");
              }

            }

            //alcool

            double alcoolpreco = 0;

            if (tipocombustivel == "a")
            {
                alcoolpreco = litros * 4.90;

             if (litros <=20){

               double desconto3 = alcoolpreco * 0.97;
               Console.WriteLine("você vai pagar:" + desconto3 + " reais");

              } else
              {
                   double desconto5 = alcoolpreco * 0.95;
                   Console.WriteLine("você vai pagar:" + desconto5 + " reais");
              }

            } 
             
            

              

            

            
        }
    }
}

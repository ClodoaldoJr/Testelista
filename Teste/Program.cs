using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {

            //Variaveis

            string[] cardapio = new string[10] { "Chopp", "Churrasquinho", "Costela", "Hamburguer", "Refrigerante", "Salame", "Pizza", "Batata-Frita", "Vodka", "Cachaça" };
            int[] precos = new int[10] { 10, 5, 20, 20, 6, 12, 40, 25, 10, 3 };







            int i, choice, sum = 0;
            string input = "";
            string[] products = new string[8] { "Pão", "Leite", "Refrigerante", "Carne", "Café", "Suco", "Sal", "Maça" };
            int[] prices = new int[8] { 1, 2, 2, 5, 4, 6, 3, 10 };


            Console.WriteLine("Role com a rapaziada");
            for (i = 0; i < cardapio.Length; i++)
            {

                Console.WriteLine((i + 1) + ". " + cardapio[i] + " - R$ " + precos[i]);
            }

            while (sum < 20)
            {
                Console.WriteLine(sum);
                sum++;
            }


            //while (!input.ToLower().Equals("p"))
            //{
            //    input = Console.ReadLine();
            //    if (Int32.TryParse(input, out choice))
            //    {
            //        choice = choice - 1;
            //        if (choice >= 0 && choice < products.Length)
            //        {
            //            Console.WriteLine("Adding " + products[choice] + " to the list.");
            //            sum += prices[choice];
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid input, please enter a number between 1-7.");
            //        }
            //    }
            //    else if (input.ToLower().Equals("p"))
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input, please enter a number between 1-7 or P to exit.");
            //    }
            //}

            Console.WriteLine("The final cost of the products is $" + sum);
            Console.ReadLine();
        }
    }
}

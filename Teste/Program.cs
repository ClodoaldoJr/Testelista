using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, choice, sum = 0;
            string input = "";
            string[] products = new string[7] { "Pão", "Leite", "Refrigerante", "Carne", "Café", "Suco", "Açucar" };
            int[] prices = new int[7] { 1, 2, 2, 5, 4, 6, 3 };

            Console.WriteLine("This is a list of shop products:");
            for (i = 0; i < products.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + products[i]);
            }
            while (!input.ToLower().Equals("p"))
            {
                input = Console.ReadLine();
                if (Int32.TryParse(input, out choice))
                {
                    choice = choice - 1;
                    if (choice >= 0 && choice < products.Length)
                    {
                        Console.WriteLine("Adding " + products[choice] + " to the list.");
                        sum += prices[choice];
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please enter a number between 1-7.");
                    }
                }
                else if (input.ToLower().Equals("p"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a number between 1-7 or P to exit.");
                }
            }

            Console.WriteLine("The final cost of the products is $" + sum);
            Console.ReadLine();
        }
    }
}

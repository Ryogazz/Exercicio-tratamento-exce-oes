using Exercicios_tratamento_exceçoes.Entities;
using Exercicios_tratamento_exceçoes.Entities.Exeception;
using System;
using System.Globalization;

namespace Exercicios_tratamento_exceçoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialB = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawL = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, initialB, withdrawL);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                account.Withdraw(withdraw);
                Console.WriteLine("New balance: " + account.Balance.ToString("f2",CultureInfo.InvariantCulture));

            }
            catch(DomainExcepitions e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}

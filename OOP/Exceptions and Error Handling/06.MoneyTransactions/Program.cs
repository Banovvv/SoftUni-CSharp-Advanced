using _06.MoneyTransactions.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.MoneyTransactions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bankAccountArgs = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);
            IList<BankAccount> bankAccounts = new List<BankAccount>();

            foreach (string bankAccountArg in bankAccountArgs)
            {
                string[] accountParams = bankAccountArg.Split('-', StringSplitOptions.RemoveEmptyEntries);
                int id = int.Parse(accountParams[0]);
                decimal amount = decimal.Parse(accountParams[1]);

                bankAccounts.Add(new BankAccount(id, amount));
            }

            while (true)
            {
                string commandParams = Console.ReadLine();

                if (commandParams == "End")
                {
                    break;
                }

                string[] commandArgs = commandParams.Split();

                string command = commandArgs[0];
                int id = int.Parse(commandArgs[1]);
                decimal amount = decimal.Parse(commandArgs[2]);

                try
                {
                    if (command == "Deposit")
                    {
                        Deposit(bankAccounts, id, amount);
                    }
                    else if (command == "Withdraw")
                    {
                        Withdraw(bankAccounts, id, amount);
                    }
                    else
                    {
                        throw new ArgumentException("Invalid command!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Enter another command");
                }
            }
        }

        private static void Withdraw(IList<BankAccount> bankAccounts, int id, decimal amount)
        {
            BankAccount currentAccount = bankAccounts.Where(x => x.ID == id).FirstOrDefault();

            if (currentAccount == null)
            {
                throw new ArgumentException("Invalid account!");
            }

            if (currentAccount.Balance - amount < 0)
            {
                throw new ArgumentException("Insufficient balance!");
            }

            currentAccount.Balance -= amount;

            Console.WriteLine($"Account {id} has new balance: {currentAccount.Balance}");
        }

        private static void Deposit(IList<BankAccount> bankAccounts, int id, decimal amount)
        {
            BankAccount currentAccount = bankAccounts.Where(x => x.ID == id).FirstOrDefault();

            if (currentAccount == null)
            {
                throw new ArgumentException("Invalid account!");
            }

            currentAccount.Balance += amount;

            Console.WriteLine($"Account {id} has new balance: {currentAccount.Balance}");
        }
    }
}

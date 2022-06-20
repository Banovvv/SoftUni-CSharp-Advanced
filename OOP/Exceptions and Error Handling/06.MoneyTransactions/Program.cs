using _06.MoneyTransactions.Models;
using System;
using System.Collections.Generic;

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
                decimal amount = decimal.Parse(accountParams[1]);

                bankAccounts.Add(new BankAccount(amount));
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
                int accountNumber = int.Parse(commandArgs[1]);
                decimal amount = decimal.Parse(commandArgs[2]);

                try
                {
                    if (command == "Deposit")
                    {
                        Deposit(bankAccounts, accountNumber, amount);
                    }
                    else if (command == "Withdraw")
                    {
                        Withdraw(bankAccounts, accountNumber, amount);
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

        private static void Withdraw(IList<BankAccount> bankAccounts, int accountNumber, decimal amount)
        {
            if (accountNumber < 1 || accountNumber > bankAccounts.Count)
            {
                throw new ArgumentException("Invalid account!");
            }

            if(bankAccounts[accountNumber - 1].Balance - amount < 0)
            {
                throw new ArgumentException("Insufficient balance!");
            }

            bankAccounts[accountNumber - 1].Balance -= amount;

            Console.WriteLine($"Account {accountNumber} has new balance: {bankAccounts[accountNumber - 1].Balance}");
        }

        private static void Deposit(IList<BankAccount> bankAccounts, int accountNumber, decimal amount)
        {
            if(accountNumber < 1 || accountNumber > bankAccounts.Count)
            {
                throw new ArgumentException("Invalid account!");
            }

            bankAccounts[accountNumber - 1].Balance += amount;

            Console.WriteLine($"Account {accountNumber} has new balance: {bankAccounts[accountNumber - 1].Balance}");
        }
    }
}

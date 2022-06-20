namespace _06.MoneyTransactions.Models
{
    public class BankAccount
    {
        public BankAccount(decimal balance)
        {
            Balance = balance;
        }

        public decimal Balance { get; set; }
    }
}

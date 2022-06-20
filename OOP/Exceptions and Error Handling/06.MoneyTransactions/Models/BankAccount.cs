namespace _06.MoneyTransactions.Models
{
    public class BankAccount
    {
        public BankAccount(int id, decimal balance)
        {
            ID = id;    
            Balance = balance;
        }

        public int ID { get; set; }
        public decimal Balance { get; set; }
    }
}

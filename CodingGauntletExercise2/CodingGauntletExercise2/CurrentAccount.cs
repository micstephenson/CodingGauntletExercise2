
namespace CodingGauntletExercise2;
internal class CurrentAccount : BaseBankAccount
{
    public double OverdraftLimit { get; set; }
    public double Balance { get; set; }

    public CurrentAccount(double balance, double overdraftLimit)
    {
        OverdraftLimit = overdraftLimit;
        Balance = balance;
    }
    public void Withdraw(double amount)
    {
        if (Balance - amount < -OverdraftLimit)
        {
            Console.WriteLine("Withdrawal exceeds overdraft limit.");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawal of {amount:C} successful. New balance: {Balance:C}");
        }
    }

    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited {amount:C}. New balance: {Balance:C}");
    }

    public void MoveToSavings(double amount, SavingsAccount savingsAccount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            savingsAccount.Balance += amount;
            Console.WriteLine($"Transferred {amount:C} to savings account. New current balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Insufficient funds in current account.");
        }
    }

    public void GetBalance()
    {
        Console.WriteLine($"Current Balance: £{Balance}");
    }
}


namespace CodingGauntletExercise2;
internal class SavingsAccount : BaseBankAccount
{
    public double InterestRate { get; set; }
    public double Balance { get; set; }

    public SavingsAccount(double balance, double interestRate)
    {
        InterestRate = interestRate;
        Balance = balance;
    }

    public void ApplyInterest()
    {
        Balance += Balance * InterestRate;
        Console.WriteLine($"New Balance after applying interest: {Balance:C}");
    }

    public void WithdrawToCurrent(double amount, CurrentAccount currentAccount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            currentAccount.Balance += amount;
            Console.WriteLine($"Transferred {amount:C} to current account. New savings balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Insufficient funds in savings account.");
        }
    }

    public void GetBalance()
    {
        Console.WriteLine($"Current Balance: £{Balance}");
    }
}

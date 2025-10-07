namespace CodingGauntletExercise2;

internal class BaseBankAccount
{
    public string AccountName { get; set; }
    public double Balance { get; set; }

    // should this be have a parameter that specifies whether they want to get the balance from savings or current?
    public string GetAccountName()
    {
        Console.WriteLine($"Account Name: {AccountName}");
        return AccountName;
    }

    public double GetBalance()
    {
        Console.WriteLine($"Balance: {Balance:C}");
        return Balance;
    }
}

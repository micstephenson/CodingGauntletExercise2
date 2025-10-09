namespace CodingGauntletExercise2;
internal class SavingsAccount : BaseBankAccount
{
    public static BaseBankAccount CreateAccount(string accountName, double balance)
    {
        return new SavingsAccount
        {
            AccountName = accountName,
            Balance = balance
        };
    }
}
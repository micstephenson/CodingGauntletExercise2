namespace CodingGauntletExercise2;
internal class CurrentAccount : BaseBankAccount
{
    public static BaseBankAccount CreateAccount(string accountName, double balance)
    {
        return new CurrentAccount
        {
            AccountName = accountName,
            Balance = balance
        };
    }
}
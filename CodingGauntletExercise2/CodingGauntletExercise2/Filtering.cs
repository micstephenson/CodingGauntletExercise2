namespace CodingGauntletExercise2;

internal class Filtering
{
    public static List<BaseBankAccount> GreaterThan(List<BaseBankAccount> accounts, int amount)
    {
        return accounts.Where(account => account.Balance > amount).ToList();
    }

    public static List<BaseBankAccount> LessThan(List<BaseBankAccount> accounts, int amount)
    {
        return accounts.Where(account => account.Balance < amount).ToList();
    }

    public static BaseBankAccount FirstOrDefault(List<BaseBankAccount> accounts, int amount)
    {
        return accounts.FirstOrDefault(account => account.Balance < amount);
    }
}
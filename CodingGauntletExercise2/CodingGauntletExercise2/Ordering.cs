namespace CodingGauntletExercise2;

internal class Ordering
{
    public static List<BaseBankAccount> Ascending(List<BaseBankAccount> accounts, string titleText)
    {
        var orderedAccounts = accounts.OrderBy(account => account.Balance).ToList();
        Console.WriteLine($"----------{titleText}----------------");
        Console.WriteLine("(----------Ordered Desc----------------)");
        foreach (var account in orderedAccounts)
        {
            Console.WriteLine($"{account.AccountName}: {account.Balance}\n");
        }
        Console.WriteLine("----------end----------------\n");
        return orderedAccounts;
    }
    public static List<BaseBankAccount> Descending(List<BaseBankAccount> accounts, string titleText)
    {
        var orderedAccounts = accounts.OrderByDescending(account => account.Balance).ToList();
        Console.WriteLine($"----------{titleText}----------------");
        Console.WriteLine("(----------Ordered Asc----------------)");
        foreach (var account in orderedAccounts)
        {
            Console.WriteLine($"{account.AccountName}: {account.Balance}\n");
        }
        Console.WriteLine("----------end----------------\n");
        return orderedAccounts;
    }
}

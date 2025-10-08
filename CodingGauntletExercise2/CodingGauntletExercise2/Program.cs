using CodingGauntletExercise2;

class Program
{
    static void Main(string[] args)
    {
        List<BaseBankAccount> accounts = new List<BaseBankAccount>();

        var CurrentAccount = new CurrentAccount();
        CurrentAccount.AccountName = "CurrentAccount1";
        CurrentAccount.Balance = 2400.19;
        accounts.Add(CurrentAccount);

        var CurrentAccount2 = new CurrentAccount();
        CurrentAccount2.AccountName = "CurrentAccount2";
        CurrentAccount2.Balance = 1200.59;
        accounts.Add(CurrentAccount2);

        var SavingsAccount = new SavingsAccount();
        SavingsAccount.AccountName = "SavingsAccount1";
        SavingsAccount.Balance = 2300.71;
        accounts.Add(SavingsAccount);

        var SavingsAccount2 = new SavingsAccount();
        SavingsAccount2.AccountName = "SavingsAccount2";
        SavingsAccount2.Balance = 9100.28;
        accounts.Add(SavingsAccount2);

        var filteredAccountsGreaterThan2000 = accounts.Where(account => account.Balance > 2000).ToList();
        var filteredAccountsLessThan2000 = accounts.Where(account => account.Balance < 2000).ToList();
        var filteredAccountsFirstOrDefault = accounts.FirstOrDefault(account => account.Balance < 2000);

        //Greater Than 2000

        var filteredAccountsGreaterThan2000Asc = filteredAccountsGreaterThan2000.OrderBy(account => account.Balance);
        var filteredAccountsGreaterThan2000Dec = filteredAccountsGreaterThan2000.OrderByDescending(account => account.Balance);

        Console.WriteLine("----------Greater Than 2000----------------");
        Console.WriteLine("(----------Ordered Desc----------------);");
        foreach (var account in filteredAccountsGreaterThan2000Dec)
        {
            Console.WriteLine($"{account.AccountName}: {account.Balance}");
            Console.WriteLine();
        }
        Console.WriteLine("----------end----------------");
        Console.WriteLine();

        Console.WriteLine("(----------Ordered Asc----------------);");
        foreach (var account in filteredAccountsGreaterThan2000Asc)
        {
            Console.WriteLine($"{account.AccountName}: {account.Balance}");
            Console.WriteLine();
        }
        Console.WriteLine("----------end----------------");
        Console.WriteLine();


        //Less Than 2000
        var filteredAccountsLessThan2000Asc = filteredAccountsLessThan2000.OrderBy(account => account.Balance);
        var filteredAccountsLessThan2000Dec = filteredAccountsLessThan2000.OrderByDescending(account => account.Balance);

        Console.WriteLine("----------Less Than 2000----------------");
        Console.WriteLine("(----------Ordered Desc----------------);");
        foreach (var account in filteredAccountsLessThan2000Dec)
        {
            Console.WriteLine($"{account.AccountName}: {account.Balance}");
            Console.WriteLine();
        }
        Console.WriteLine("----------end----------------");
        Console.WriteLine();

        Console.WriteLine("(----------Ordered Asc----------------);");
        foreach (var account in filteredAccountsLessThan2000Asc)
        {
            Console.WriteLine($"{account.AccountName}: {account.Balance}");
            Console.WriteLine();
        }
        Console.WriteLine("----------end----------------");

        foreach (var account in accounts)
        {
            account.GetAccountName();
            account.GetBalance();
            Console.WriteLine();
        }
    }

}
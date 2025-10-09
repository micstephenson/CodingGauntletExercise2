using CodingGauntletExercise2;

class Program
{
    static void Main(string[] args)
    {
        List<BaseBankAccount> accounts = new List<BaseBankAccount>();

        accounts.Add(CurrentAccount.CreateAccount("CurrentAccount1", 2409.19));
        accounts.Add(CurrentAccount.CreateAccount("CurrentAccount2", 1200.59));
        accounts.Add(SavingsAccount.CreateAccount("SavingsAccount1", 2300.71));
        accounts.Add(SavingsAccount.CreateAccount("SavingsAccount2", 9100.28));

        var filteredAccountsGreaterThan2000 = Filtering.GreaterThan(accounts, 2000);
        var filteredAccountsLessThan2000 = Filtering.LessThan(accounts, 2000);
        var filteredAccountsFirstOrDefault = Filtering.FirstOrDefault(accounts, 2000);


        string titleText = "Greater Than 2000";
        var filteredAccountsGreaterThan2000Asc = Ordering.Ascending(filteredAccountsGreaterThan2000, titleText);
        var filteredAccountsGreaterThan2000Dec = Ordering.Descending(filteredAccountsGreaterThan2000, titleText);

        string titleText2 = "Less Than 2000";
        var filteredAccountsLessThan2000Asc = Ordering.Ascending(filteredAccountsLessThan2000, titleText2);
        var filteredAccountsLessThan2000Dec = Ordering.Descending(filteredAccountsLessThan2000, titleText2);

        foreach (var account in accounts)
        {
            account.GetAccountName();
            account.GetBalance();
            Console.WriteLine();
        }
    }

}
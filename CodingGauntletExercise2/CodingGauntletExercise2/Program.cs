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

        foreach (var account in accounts)
        {
            account.GetAccountName();
            account.GetBalance();
            Console.WriteLine();
        }
    }

}
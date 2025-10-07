using CodingGauntletExercise2;

class Program
{
    static void Main(string[] args)
    {
        BaseBankAccount account1 = new BaseBankAccount("Mic", 1234.0, "Mic@email.com", 123456);
        BaseBankAccount account2 = new BaseBankAccount("Oli", 2345.0, "Oli@email.com", 234567);
        BaseBankAccount account3 = new BaseBankAccount("Ben", 3456.0, "Ben@email.com", 345678);

        var accounts = new List<BaseBankAccount> { account1, account2, account3 };

        for (int i = 0; i < accounts.Count; i++)
        {
            accounts[i].PersonalDetails();
        }
    }
}
namespace CodingGauntletExercise2;

internal class BaseBankAccount
{
    public string Name { get; set; }
    public double Balance { get; set; }
    public string Email { get; set; }
    public int CustomerNumber { get; set; }

    public BaseBankAccount(string name, double balance, string email, int customerNumber)
    {
        Name = name;
        Balance = balance;
        Email = email;
        CustomerNumber = customerNumber;
    }

    public void PersonalDetails()
    {
        Console.WriteLine($"Account Holder: {Name}, Email: {Email}");
    }

    // should this be have a parameter tat specifies whether they want to get the balance from savings or current?
    public void GetBalance()
    {
        Console.WriteLine($"Current Balance: {Balance:C}");
    }
}

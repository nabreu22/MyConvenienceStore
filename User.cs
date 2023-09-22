using System;

class User
{
    //attribute

    public string UserName { get; set; }
    public decimal UserBalance { get; set; }

    //method
    public User(string userName, decimal userBalance)
    {
        UserName = userName;
        UserBalance = userBalance;
    }

    public void ShowUserBalance()
    {
        Console.WriteLine($"Hello, {UserName}! Your balance is: {UserBalance}!");
    }

    public bool DeductFromBalance(decimal amount)
    {
        if (UserBalance >= amount)
        {
            UserBalance -= amount;
            return true;
        }
        return false;
    }

}
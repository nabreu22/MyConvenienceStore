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

    //deduzir balance aqui

}
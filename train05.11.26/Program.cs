BankAccount gena = new BankAccount("Geo");
BankAccount sena = new BankAccount("senna");
gena.Deposit(50);
sena.Deposit(100);

Console.WriteLine(gena.Transfer(sena, 30));   // True
Console.WriteLine(gena.Balance);              // 20
Console.WriteLine(sena.Balance);              // 130
Console.WriteLine(gena.Transfer(sena, 100));  // False
Console.WriteLine(gena.Balance);              // 20, не изменился
Console.WriteLine(sena.Balance);              // 130, не изменился


class BankAccount
{
    public string Owner { get; private set; }
    public decimal Balance { get; private set; }

    public BankAccount(string owner)
    {
        if (string.IsNullOrWhiteSpace(owner))
        {
            throw new  ArgumentException(nameof(owner));
        }
        Owner = owner;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException(nameof(amount));
        }
        Balance += amount;
    }

    public bool Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException(nameof(amount));
        }
        else if (Balance < amount)
        {
            return false;
        }
        Balance -= amount;
        return true;
    }

    public bool Transfer(BankAccount target, decimal amount)
    {
        var success = Withdraw(amount);
        if (!success)
        {
            return false;
        }
        target.Deposit(amount);
        return true;
    }
}
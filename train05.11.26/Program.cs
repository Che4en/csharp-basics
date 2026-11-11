var bread = new Product("Bread",50);
bread.Restock(10);

var anna = new Customer("Anna");
anna.AddMoney(200);

Console.WriteLine(anna.Buy(bread, 3));
Console.WriteLine(anna.Balance);
Console.WriteLine(bread.Stock);

Console.WriteLine(anna.Buy(bread, 2));
Console.WriteLine(anna.Balance);
Console.WriteLine(bread.Stock);

var boris = new Customer("Boris");
boris.AddMoney(5000);
Console.WriteLine(boris.Buy(bread, 30));
Console.WriteLine(boris.Balance);
Console.WriteLine(bread.Stock);

Console.WriteLine(boris.Buy(bread, 7));
Console.WriteLine(bread.Stock);
Console.WriteLine(boris.Balance);


class Product(string name, decimal price)
{
    public string Name { get; private set; } = name;
    public decimal Price { get; private set; } = price;
    public int Stock { get; private set; } = 0;

    public bool TryTake(int count)
    {
        if (count <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count)); 
        }

        if(Stock < count)
        {
            return false;
        }
        Stock -= count;
        return true;
    }

    public void Restock(int count)
    {
        if (count<=0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        Stock += count;
    }
}

class Customer
{
    public string Name { get; private set; }
    public decimal Balance { get; private set; }

    public Customer(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentNullException(nameof(name));
        }
        Name = name;
    }
    
    public void AddMoney(decimal money)
    {
        if (money<=0)
        {
            throw new ArgumentOutOfRangeException(nameof(money));
        }
        Balance += money;

    }
    
    
    public bool Buy(Product product, int count)
    {
        if (product == null)
        {
            throw new ArgumentNullException(nameof(product));
        }
        var result = product.Price * count;
        if (result > Balance)
        {
            return false;
        }
        if (!product.TryTake(count))
        {
            return false;
        }
        Balance -= result;
        return true;
    }
    
}
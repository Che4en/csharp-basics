var sword = new Weapon("Sword", 30);
var dagger = new Weapon("Dagger", 10);

var first = new Player("anna", 100, sword);
var second = new Player("boris", 100, dagger);

first.Attack(second);
Console.WriteLine(second.Health);   

first.Equip(dagger);
first.Attack(second);
Console.WriteLine(second.Health);

Console.WriteLine(first.IsAlive()); 
first.TakeDamage(10);
Console.WriteLine(first.Health);   

// first.Attack(second);
// Console.WriteLine(second.Health);   
// first.Attack(second);
// Console.WriteLine(second.Health);   
// Console.WriteLine(second.IsAlive());
// Console.WriteLine(second.Attack(first));

while (first.IsAlive() && second.IsAlive() )
{
    first.Attack(second);   
    Console.WriteLine($"{first.Name} hits {second.Name}, {second.Name} has {second.Health} health left");
    if (second.IsAlive())
    {
        second.Attack(first);   
        Console.WriteLine($"{second.Name} hits {first.Name}, {first.Name} has {first.Health} health left");
    }
}
if (first.IsAlive())
{
    Console.WriteLine($"{first.Name} wins");
}
else
{
    Console.WriteLine($"{second.Name} wins");
}

class Player(string name, int health, Weapon weapon)
{
    public string Name { get; } = name;
    public int Health { get; private set; } = health;
    
    public Weapon Weapon{ get; private set; } = weapon;
    
    public bool IsAlive()
    {
        return Health > 0;
    }
    
    public void TakeDamage(int amount)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(amount);

        Health -= amount;

        if (Health < 0)
        {
            Health = 0;
        }
    }

    public bool Attack(Player target)
    {
        if(IsAlive())
        {
            target.TakeDamage(Weapon.Damage);
            return true;
        }

        return false;
    }
    
    public void Equip(Weapon newWeapon)
    {
        if (newWeapon == null)
        {
            throw new ArgumentNullException();
        }
        Weapon = newWeapon;
    }
}

class  Weapon(string name, int damage)
{
    public string Name { get; } = name;
    public int Damage { get; } = damage;
}
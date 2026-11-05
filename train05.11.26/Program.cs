int Max(int[] a)
{
    
    var max = a[0];

    for (var i =1 ; i < a.Length; i++)
    {
    
        if  (a[i] > max)
        {
            max = a[i];
        }
    }
    return max;
}

int[] a = [1,1,3,4,5,6,67,0];
var result = Max(a);
Console.WriteLine(result);

void PrintEven(int[] a)
{
    for (var i = 0; i < a.Length; i++)
    {
        if (a[i] % 2 == 0)
        {
            Console.WriteLine(a[i]);
        }
    }
}
PrintEven(a);

void PrintEvenNumbers()
{
    for (var i = 0; i <= 20; i+=2)
    {
        Console.WriteLine(i);
    }
    
    // for(var i = 0; i<= 20; i++)
    // {
    //     if (i % 2 == 0)
    //     {
    //         Console.WriteLine(i);
    //     }
    // }
}
PrintEvenNumbers();
int[] numbers = [1, 1, 3, 4, 5, 6, 67, 0];

Console.WriteLine(Max(numbers));
PrintEven(numbers);
PrintEvenNumbers();
Console.WriteLine(SumNumbers(numbers));
Console.WriteLine(CountGreater(numbers, 4));
Console.WriteLine(ReverseString("abc"));
Console.WriteLine(Min(numbers));
int Max(int[] values)
{
    var max = values[0];

    for (var i = 1; i < values.Length; i++)
    {
        if (values[i] > max)
        {
            max = values[i];
        }
    }

    return max;
}

void PrintEven(int[] values)
{
    foreach (var value in values)
    {
        if (value % 2 == 0)
        {
            Console.WriteLine(value);
        }
    }
}

void PrintEvenNumbers()
{
    for (var i = 0; i <= 20; i += 2)
    {
        Console.WriteLine(i);
    }
}

int SumNumbers(int[] values)
{
    var sum = 0;

    foreach (var value in values)
    {
        sum += value;
    }

    return sum;
}

int CountGreater(int[] values, int x)
{
    var count = 0;

    foreach (var value in values)
    {
        if (value > x)
        {
            count++;
        }
    }

    return count;
}

string ReverseString(string s)
{
    var result = "";

    for (var i = s.Length - 1; i >= 0; i--)
    {
        result += s[i];
    }

    return result;
}

int Min(int[] numbers)
{
    var min = numbers[0];

    for (var i = 0; i < numbers.Length; i++)
    {
        if (min > numbers[i])
        {
            min = numbers[i];
        }
    }
    return min;
}

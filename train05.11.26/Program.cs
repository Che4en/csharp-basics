void FizzBuzz()
{
    for (int i = 1; i <= 30; i++)
    {
        if (i % 3 == 0 && i % 5 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (i % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (i%5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(i);
        }
    }
}
FizzBuzz();

string ReverseString(string s)
{
    var result = "";
    for (var i = s.Length-1; i>=0; i--)
    {
        result+=s[i];
    }

    return result;
}

bool IsPalindrome(string s)
{
    var lower = s.ToLower();
    var reversed = ReverseString(lower);
    return reversed == lower;
}
Console.WriteLine(IsPalindrome("Level"));
Console.WriteLine(IsPalindrome(""));
Console.WriteLine(IsPalindrome("l"));


int CountChar(string s, char target)
{
    var count = 0;
    foreach (var c in s)
    {
        if (c == target) count += 1;
    }
    return count;
}
Console.WriteLine(CountChar("level" ,'e'));

int FindIndex(int[] a, int t)
{
    for (int i = 0; i<a.Length; i++)
    {
        if (a[i] == t)
        {
            return i;
        }
    }

    return -1;
}
Console.WriteLine(FindIndex([4, 8, 15, 8], 8));
Console.WriteLine(FindIndex([4, 8, 15, 8], 4));
Console.WriteLine(FindIndex([4, 8, 15, 8], 99));
Console.WriteLine(FindIndex([], 2));
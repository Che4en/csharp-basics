int[] a = {1,3,4,5,6,6,2,3,0 };
var evens = GetEvens(a);
Console.WriteLine(string.Join(" ", evens));
List<int> GetEvens(int[] numbers)
{
    var result = new List<int>();

    foreach (var number in numbers )
    {
        if (number%2==0)
        {
            result.Add(number);
        }
    }
    return result;
    
}

int Sumlist(List<int> list)
{
    var sumlist = 0;
    foreach (var value in list)
    {
        sumlist += value;
    }

    return sumlist;
}

List<int> list = [ 1, 2, 3, 4, 5, 6, 7 ];
var sumResult = Sumlist(list);
Console.WriteLine(sumResult);

List<string> FilterByLetter(List<string> words, char letter)
{
    var result = new List<string>();
    for (int i = 0; i < words.Count; i++)
    {
        if (words[i].Trim().ToLower().StartsWith(char.ToLower(letter)))
        {
            result.Add(words[i]);
        }
    }
    return result;
}

var fruits = new List<string> { "apple", "banana", "avocado" };
var fruit = FilterByLetter(fruits, 'a');
Console.WriteLine(string.Join(", ", fruit));


var minusNumbres = new List<int> {1,4,65,7,8,-1,-3,-1};
var minusResult = RemoveNegatives(minusNumbres);
Console.WriteLine(string.Join(" ", minusResult));
List<int> RemoveNegatives(List<int> values)
{
    var result = new List<int>();

    foreach (var value in values)
    {
        if (value>=0)
        {
            result.Add(value);
        }
    }
    return result;

}
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
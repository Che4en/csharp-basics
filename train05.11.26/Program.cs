using System.Security.AccessControl;

int[] numbers = [1, 3, 5, 6, 87];
int[] numbers2 = [1];
int[] numbers3 = [];
int[] numbers4 = [124, 14];

Console.WriteLine(IsSorted(numbers));
Console.WriteLine(IsSorted(numbers2));
Console.WriteLine(IsSorted(numbers3));
Console.WriteLine(IsSorted(numbers4));

bool IsSorted(int[] a)
{
    for (var i = 0; i < a.Length - 1; i++)
    {
        if (a[i]>a[i+1])
        {
            return false;
        }
    }

    return true;
}

var s = "banana";
Console.WriteLine(RemoveChar(s,'a'));

string RemoveChar(string s, char target)
{
    var result = "";
    foreach (var letter in s)
    {
        if (letter!=target)
        {
            result += letter;
        }
    }
    return result;
}

var gena = new TodoItem("Exam");
Console.WriteLine(gena.IsDone);
gena.Complete();
Console.WriteLine(gena.IsDone);


var list = new TodoList();
var a = new TodoItem("Exam");
var b = new TodoItem("Gym");
list.Add(a);
list.Add(b);

a.Complete();
Console.WriteLine(list.CountDone());

var found = list.FindByTitle("Gym");
Console.WriteLine(found?.Title);
Console.WriteLine(list.FindByTitle("Nothing") == null);



class  TodoItem
{
    public string Title { get; set; }
    public bool IsDone { get; private set; }
    
    public TodoItem(string title)
    {
        if (string.IsNullOrWhiteSpace(title))
        {
            throw new ArgumentException(nameof(title));
        }
        Title = title;
    }
    
    public void Complete()
    {
        if(IsDone)
        {
            throw new InvalidOperationException();
        }
        IsDone = true;
    }
}   


class TodoList
{

    private List<TodoItem> _item = new List<TodoItem>();

    public void Add(TodoItem item)
    {
        if(item==null){
            throw new ArgumentNullException(nameof(item));
        }
        _item.Add(item);
    }

    public int CountDone()
    {
        var count = 0;
        foreach (var item in _item)
        {
            if (item.IsDone)
            {
                count++;
            }
        }

        return count;
    }

    public TodoItem? FindByTitle(string title)
    {
        foreach (var item in  _item)
        {
            if (item.Title == title)
            {
                return item;
            }
        }

        return null;
    }
}

// Generic
/*
-Class
-Struct
-Methods
-Interface
-Delegate
-Collections
*/

Some<List<int>> some = new();
some.Value = [];
//some.Foo();
some.Bar(2, 3.05);

// Generic class
class Some<T> where T: class, IEnumerable<int>
{
    public T Value { get; set; }
    public void Foo()
    {
        Console.WriteLine(Value.GetType());
    }
    // Generic methods
    public T2 Bar<T1, T2>(T2 left, T1 right)
    {
        Console.WriteLine(left.GetType());
        Console.WriteLine(right.GetType());
        return left;
    }
    
}

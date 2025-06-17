// IDisposable
//MyClass my = new();
//try
//{
//    my.Foo();

//}
//finally
//{
//    my.Dispose();
//}

// using(){} - syntax sugar
using (MyClass my = new())
{
    my.Foo();
}

//using MyClass my = new();
//my.Foo();
class MyClass : IDisposable
{
    private bool _isDisposed = false;
    public MyClass()
    {
        Console.WriteLine("Constructor ...");
    }

    public void Foo()
    {
        Console.WriteLine("Some supper pupper mupper magic code...");
        throw new Exception();
    }
    private void Cleaning(bool disposing)
    {
        if (!_isDisposed)
        {
            if (disposing)
            {
                Console.WriteLine("Managed resources are cleaned");
            }
            Console.WriteLine("Unmanaged resources are cleaned");
            _isDisposed = true;
        }
    }

    public void Dispose()
    {
        Cleaning(true);
        GC.SuppressFinalize(this);
    }

    // finalizer
    ~MyClass()
    {
        Cleaning(false);
    }

}


abstract class Logistic
{
    public abstract ITransport CreateTransport();
    public void Delivery()
    {
        Console.WriteLine("Logistic Delivery");
    }
}


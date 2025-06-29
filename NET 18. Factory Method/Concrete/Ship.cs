class Ship : ITransport
{
    public void Deliver(string productName)
    {
        Console.WriteLine($"Deliver {productName} by sea in containers");
    }
}


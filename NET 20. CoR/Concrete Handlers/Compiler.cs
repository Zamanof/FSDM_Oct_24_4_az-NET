// Chain of Responsibility

class Compiler : CompilerCoR
{
    public override void Handle()
    {
        Console.WriteLine("Compile");
        Next?.Handle();
    }
}

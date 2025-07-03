// Chain of Responsibility

class LexicalAnalyzer : CompilerCoR
{
    public override void Handle()
    {
        return;
        Console.WriteLine("Lexical Analyzer" );
        Next?.Handle();
    }
}

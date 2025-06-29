class SeaLogistic : Logistic
{
    public override ITransport CreateTransport()
    {
        return new Ship();
    }
}


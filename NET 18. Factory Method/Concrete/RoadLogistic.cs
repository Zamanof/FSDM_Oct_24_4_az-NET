
class RoadLogistic : Logistic
{
    public override ITransport CreateTransport()
    {
        return new Truck();
    }
}


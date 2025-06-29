// Factory Method

Logistic logistic = new RoadLogistic();
DeliverProducts(logistic, "Charcoal");
DeliverProducts(new SeaLogistic(), "M&M's");

void DeliverProducts(Logistic logistic, string productName)
{
    ITransport transport = logistic.CreateTransport();
    transport.Deliver(productName);
}

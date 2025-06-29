class Master // Director
{
    private IBuilder _builder;

    public Master(IBuilder builder)
    {
        _builder = builder;
    }
    public void ChangeBuilder(IBuilder builder) => _builder = builder;

    public House Make(string type)
    {
        _builder.Reset();
        switch (type)
        {
            case "A":
                _builder.House.Name = "A type House";
                return _builder
                               .BuildRoof()
                               .BuildWindow()
                               .BuildWall()
                               .BuildGarden()
                               .GetHouse();
            case "B":
                _builder.House.Name = "B type House";
                return _builder
                               
                               .BuildWindow()
                               .BuildWall()
                               .BuildWall()
                               .BuildWall()
                               .BuildWall()
                               .BuildGarden()
                               .BuildGarage()
                               .GetHouse();
            case "C":
                _builder.House.Name = "C type House";
                return _builder

                               .BuildWindow()
                               .GetHouse();

            default:
                throw new Exception("Wrong House type");
        }
    }
}


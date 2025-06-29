class StoneBuilder : IBuilder
{

    public House House { get; set; } = new House { Name = "Stone House" };

    public IBuilder BuildDoor()
    {
        House.Door = 1;
        return this;
    }

    public IBuilder BuildGarage()
    {
        House.Garage = 1;
        return this;
    }

    public IBuilder BuildGarden()
    {
        House.Garden = 1;
        return this;
    }

    public IBuilder BuildPool()
    {
        House.Pool = 1;
        return this;
    }

    public IBuilder BuildRoof()
    {
        House.HasRoof = true;
        return this;
    }

    public IBuilder BuildWall()
    {
        House.Wall++;
        return this;
    }

    public IBuilder BuildWindow()
    {
        House.Window = 2;
        return this; ;
    }

    public House GetHouse() => House;

    public IBuilder Reset()
    {
        House = new();
        return this;
    }
}

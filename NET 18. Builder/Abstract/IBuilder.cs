interface IBuilder
{
    public House House { get; set; }
    IBuilder BuildWall();
    IBuilder BuildDoor();
    IBuilder BuildWindow();
    IBuilder BuildGarage();
    IBuilder BuildGarden();
    IBuilder BuildPool();
    IBuilder BuildRoof();
    IBuilder Reset();
    House GetHouse();// Build
}

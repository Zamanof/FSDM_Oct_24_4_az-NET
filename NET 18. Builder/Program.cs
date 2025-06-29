// Product
// Builder
// Builder: Concrete
// Director

IBuilder builder = new WoodBuilder();

//var stoneHouse = builder
//                        .BuildWall()
//                        .BuildWall()
//                        .BuildWall()
//                        .BuildWindow()
//                        .BuildRoof()
//                        .GetHouse();

//Console.WriteLine(stoneHouse);

Master master = new(builder);
House house = master.Make("C");
Console.WriteLine(house);
master.ChangeBuilder(new StoneBuilder());
house = master.Make("A");
Console.WriteLine(house);



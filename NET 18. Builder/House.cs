// Product
// Builder
// Builder: Concrete
// Director

class House
{
    public string Name { get; set; }
    public int Wall { get; set; }
    public int Door { get; set; }
    public int Window { get; set; }
    public int Pool { get; set; }
    public int Garage { get; set; }
    public int Garden { get; set; }
    public bool HasRoof { get; set; }

    public override string ToString()
    {
        return @$"
Name:       {Name}
Walls:      {Wall}
Doors:      {Door}
Windows:    {Window}
Garage:     {Garage}
Pool:       {Pool}
Garden:     {Garden}
Roof:       {(HasRoof? "Has roof": "Without roof")}

";
    }
}

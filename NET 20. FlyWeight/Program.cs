// FlyWeight pattern

List<UnitFlyWeight> units = new List<UnitFlyWeight>();
FlyWeightFactory factory = new();
for (int i = 0; i < 1000000; i++)
{
    //Archer unitArcher = new Archer();
    //Warriror unitWarrior = new Warriror();

    UnitFlyWeight unitArcher = factory.GetUnit("Archer");
    UnitFlyWeight unitWarrior = factory.GetUnit("Warrior");

    Console.WriteLine(unitArcher.GetHashCode());
    Console.WriteLine(unitWarrior.GetHashCode());

    units.Add(unitArcher);
    units.Add(unitWarrior);
}
abstract class UnitFlyWeight
{
    protected string Name { get; set; }
    protected int AttackPoint { get; set; }
    protected int Health { get; set; }
    public abstract void Display();
}
class Archer : UnitFlyWeight
{
    public Archer()
    {
        Name = "Archer";
        AttackPoint = 90;
        Health = 70;
    }

    public override void Display()
    {
        Console.WriteLine("Archer created");
    }
}

class Warriror : UnitFlyWeight
{
    public Warriror()
    {
        Name = "Warrior";
        AttackPoint = 30;
        Health = 150;
    }

    public override void Display()
    {
        Console.WriteLine("Warriror created");
    }
}


class FlyWeightFactory
{
    private Dictionary<string, UnitFlyWeight> _units = new();

    public UnitFlyWeight GetUnit(string key)
    {
        UnitFlyWeight unit = default;
        if (_units.ContainsKey(key))
        {
            unit = _units[key];
        }
        else
        {
            switch (key)
            {
                case "Archer":
                    unit = new Archer();
                    break;
                case "Warrior":
                    unit = new Warriror();
                    break;
            }
            _units.Add(key, unit);
        }
        return unit;
    }
}
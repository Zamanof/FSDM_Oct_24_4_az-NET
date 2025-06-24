// Intreface segregation

#region Bad Example

//abstract class Animal
//{
//    public abstract void Feed();
//    public abstract void Groom();
//}

//class Dog : Animal
//{
//    public override void Feed()
//    {
//        Console.WriteLine("Dog feed");
//    }

//    public override void Groom()
//    {
//        Console.WriteLine("Dog groom");
//    }
//}

//class Cat : Animal
//{
//    public override void Feed()
//    {
//        Console.WriteLine("Cat feed");
//    }

//    public override void Groom()
//    {
//        Console.WriteLine("Cat groom");
//    }
//}

//class Tiger : Animal
//{
//    public override void Feed()
//    {
//        Console.WriteLine("Tiger feed");
//    }

//    public override void Groom()
//    {
//        Console.WriteLine("Tiger groom if you can");
//    }
//}
#endregion


#region Good Example
abstract class Animal { }

interface IGroom
{
    public void Groom();
}
interface IFeed
{
    public void Feed();
}

interface IPet : IFeed, IGroom { }
class Dog : Animal, IPet
{
    public void Feed()
    {
        Console.WriteLine("Dog feed");
    }

    public void Groom()
    {
        Console.WriteLine("Dog groom");
    }
}

class Cat : Animal, IFeed, IGroom
{
    public void Feed()
    {
        Console.WriteLine("Cat feed");
    }

    public  void Groom()
    {
        Console.WriteLine("Cat groom");
    }
}

class Tiger : Animal, IFeed
{
    public void Feed()
    {
        Console.WriteLine("Tiger feed");
    }    
}
#endregion
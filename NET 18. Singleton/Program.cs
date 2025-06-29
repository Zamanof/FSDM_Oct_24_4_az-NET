// Singleton pattern
President president;

president = President.GetInstance("Donald", "Trump", 79);
Console.WriteLine(president);
President newPresident = President.GetInstance("Huseyn", "Sebziyev", 21);
Console.WriteLine(newPresident);

class President
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { set; get; }

    private static President _instance = null;

    private President(string name, string surname, int age)
    {
        Name = name;
        Surname = surname;
        Age = age;
    }

    static public President GetInstance(string name, string surname, int age)
    {
        if(_instance is null)
        {
            _instance = new(name, surname, age);
        }
        return _instance;
    }
    public override string ToString()
    {
        return $"{Name} {Surname} - {Age}";
    }
}
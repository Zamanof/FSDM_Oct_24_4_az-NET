// Events

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public void Exam(string task)
    {
        Console.WriteLine($"{FirstName} {LastName} solved {task}");
    }
}



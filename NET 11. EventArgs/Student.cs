// See https://aka.ms/new-console-template for more information
class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public void Exam(object sender, ExamEventArgs args)
    {
        Console.WriteLine($"{(sender as Teacher).FirstName} <=> {FirstName} {LastName} solved {args.Task}");
    }
}

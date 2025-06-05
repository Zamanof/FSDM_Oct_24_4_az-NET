// Standard interfaces

//Auditory auditory = new();

//foreach (Student student in auditory)
//{
//    Console.WriteLine(student);
//}

////auditory.Sort();
//auditory.Sort(new DateComparer());
////auditory.Sort(EmailComparer);
//// auditory.Sort((left, right) => string.Compare(left.LastName, right.LastName));
//Console.WriteLine();
//Console.ForegroundColor = ConsoleColor.DarkGreen;
//Console.WriteLine("Sorted auditory");
//Console.WriteLine();

//foreach (Student student in auditory)
//{
//    Console.WriteLine(student);
//}

Student student = new()
{
    FirstName = "Nadir",
    LastName = "Zamanov",
    Email = "zamanov@itstep.org",
    BirthDate = new DateTime(1980, 10, 7),
    StudentCard = new StudentCard() { Series="NZ", Id=123456}
};

Student student1;
// shallow copy
//student1 = student;

// deep copy
student1 = student.Clone() as Student;

Console.WriteLine(student);
Console.WriteLine();
student.FirstName = "Zaman";
student.StudentCard.Series = "AA";
Console.WriteLine(student1);
Console.WriteLine(student);  

int EmailComparer(Student left, Student right)
{
    return string.Compare(left.Email, right.Email);
}


// EventArgs, EventHandler
Console.WriteLine("Hello, World!");

List<Student> students = new()
{
    new Student{FirstName = "Ali", LastName = "Aliyev", Age = 20},
    new Student{FirstName = "Veli", LastName = "Velizade", Age = 22},
    new Student{FirstName = "Hesen", LastName = "Hesenov", Age = 21},
    new Student{FirstName = "Aysel", LastName = "Aliyeva", Age = 19},
    new Student{FirstName = "Aygun", LastName = "Velizade", Age = 23},
    new Student{FirstName = "Aysel", LastName = "Hesenova", Age = 20},
    new Student{FirstName = "Ayten", LastName = "Hesenova", Age = 20},
    new Student{FirstName = "Kamran", LastName = "Mustafayev", Age = 24},
    new Student{FirstName = "Narmin", LastName = "Ismayilova", Age = 21},
    new Student{FirstName = "Tunar", LastName = "Mammadov", Age = 22},
    new Student{FirstName = "Rovshan", LastName = "Aliyev", Age = 23},
    new Student{FirstName = "Nigar", LastName = "Velizade", Age = 20},
    new Student{FirstName = "Ilkin", LastName = "Rahimov", Age = 21},
    new Student{FirstName = "Lala", LastName = "Huseynova", Age = 22},
    new Student{FirstName = "Samir", LastName = "Mammadov", Age = 19},
    new Student{FirstName = "Sevinc", LastName = "Aliyeva", Age = 20},
    new Student{FirstName = "Murad", LastName = "Gasimov", Age = 24},
    new Student{FirstName = "Orkhan", LastName = "Isayev", Age = 23},
    new Student{FirstName = "Rena", LastName = "Aliyeva", Age = 22},
    new Student{FirstName = "Elnur", LastName = "Huseynov", Age = 25},
    new Student{FirstName = "Sahil", LastName = "Mammadli", Age = 20},
    new Student{FirstName = "Gunay", LastName = "Jafarova", Age = 21},
    new Student{FirstName = "Zaur", LastName = "Tagizade", Age = 23},
    new Student{FirstName = "Farid", LastName = "Aliyev", Age = 22},
    new Student{FirstName = "Arzu", LastName = "Mammadova", Age = 20},
    new Student{FirstName = "Fidan", LastName = "Rahimli", Age = 21},
    new Student{FirstName = "Rashad", LastName = "Ibrahimov", Age = 22},
    new Student{FirstName = "Sabina", LastName = "Hasanova", Age = 20},
    new Student{FirstName = "Ilaha", LastName = "Javadova", Age = 19},
    new Student{FirstName = "Zeynab", LastName = "Aliyeva", Age = 21}
};

Teacher teacher1 = new Teacher();
teacher1.FirstName = "Isa";
Teacher teacher2 = new Teacher();
teacher2.FirstName = "Nadir";

for (int i = 0; i < students.Count; i++)
{
    if(i% 2 == 0) teacher1.ExamEvent += students[i].Exam;
    else teacher2.ExamEvent += students[i].Exam;
     
}

ExamEventArgs eventArgs = new() { Task = "String builder" };
teacher1.Exam(eventArgs);

teacher2.Exam(new ExamEventArgs { Task = "Events" });
    



public delegate void ExamDelegate(string task);
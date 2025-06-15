// LINQ Methods
List<Group> groups = [
    new Group{Id=1, Name="FSDM_Oct_24_4_az", Faculty="Programming" },
    new Group{Id=2, Name="FBAS_Nov_25_6_ru", Faculty="Cybercecurity" },
    new Group{Id=3, Name="FSDM_Oct_24_4_en", Faculty="Design" },
    new Group{Id=4, Name="FSDM_39_4_az", Faculty="Programming" },
    new Group{Id=5, Name="FSDM_39_4_en", Faculty="Design" },
    new Group{Id=6, Name="FSDM_39_4_ru", Faculty="Cybercecurity" },
    new Group{Id=7, Name="FSDM_39_4_tr", Faculty="Programming" },
    new Group{Id=8, Name="FSDM_39_4_fr", Faculty="Design" },
    new Group{Id=9, Name="FSDM_39_4_de", Faculty="Cybercecurity" }
    ];

List<Student> students = new List<Student>
{
    new Student{FirstName="Ali", LastName="Aliyev", Age=26, GroupId=1},
    new Student{FirstName="Veli", LastName="Veliev", Age=21, GroupId=1},
    new Student{FirstName="Vali", LastName="Valiyev", Age=22, GroupId=2},
    new Student{FirstName="Nigar", LastName="Gurbanova", Age=19, GroupId=2},
    new Student{FirstName="Rauf", LastName="Ismayilov", Age=23, GroupId=3},
    new Student{FirstName="Kamal", LastName="Mammadov", Age=25, GroupId=3},
    new Student{FirstName="Ilkin", LastName="Tagiyev", Age=24, GroupId=4},
    new Student{FirstName="Lala", LastName="Hasanova", Age=26, GroupId=4},
    new Student{FirstName="Orxan", LastName="Aliyev", Age=27, GroupId=5},
    new Student{FirstName="Tunar", LastName="Karimov", Age=28, GroupId=5},
    new Student{FirstName="Zaur", LastName="Zamanov", Age=29, GroupId=6},
    new Student{FirstName="Afet", LastName="Salmanli", Age=30, GroupId=6},
    new Student{FirstName="Kenan", LastName="Musayev", Age=31, GroupId=7},
    new Student{FirstName="Sanan", LastName="Quliyev", Age=32, GroupId=7},
    new Student{FirstName="Rena", LastName="Suleymanli", Age=26, GroupId=8},
    new Student{FirstName="Murad", LastName="Ehmedov", Age=34, GroupId=8},
    new Student{FirstName="Sabina", LastName="Aliyeva", Age=35, GroupId=9},
    new Student{FirstName="Fidan", LastName="Memmedli", Age=26, GroupId=9},
    new Student{FirstName="Ilqar", LastName="Camalov", Age=37, GroupId=1},
    new Student{FirstName="Zehra", LastName="Ceferli", Age=38, GroupId=2},
    new Student{FirstName="Nicat", LastName="Ehmedzade", Age=26, GroupId=3},
    new Student{FirstName="Emil", LastName="Rehimov", Age=40, GroupId=4},
    new Student{FirstName="Ayan", LastName="Meherremli", Age=41, GroupId=5},
    new Student{FirstName="Ayxan", LastName="Agayev", Age=42, GroupId=6},
    new Student{FirstName="Ulvi", LastName="Gasimov", Age=43, GroupId=7},
    new Student{FirstName="Rovsen", LastName="Eliyev", Age=44, GroupId=8},
    new Student{FirstName="Leman", LastName="Kerimli", Age=45, GroupId=9},
    new Student{FirstName="Elvin", LastName="Babayev", Age=46, GroupId=1},
    new Student{FirstName="Turkan", LastName="Sadigli", Age=47, GroupId=2},
    new Student{FirstName="Zahid", LastName="Gadirov", Age=48, GroupId=3}
};

#region First, FirstOrDefault
//var stud = students.First();
//Console.WriteLine(stud);

//var stud1 = students.First(s=> s.GroupId == 8);
//Console.WriteLine(stud1);

//var stud2 = students.First(s => s.GroupId == 18);
//Console.WriteLine(stud2);

//var stud3 = students.FirstOrDefault(s => s.GroupId == 18);
//if (stud3 is not null) Console.WriteLine(stud3);
//else Console.WriteLine("Student not found");

#endregion

#region Single, SingleOrDefault
//var stud = students.Single(s => s.FirstName == "Rena");
//Console.WriteLine(stud);

//var stud1 = students.Single(s => s.GroupId == 1);
//Console.WriteLine(stud1);

//var stud2 = students.SingleOrDefault(s => s.GroupId == 2);
//if (stud2 is not null) Console.WriteLine(stud2);
//else Console.WriteLine("Student not found");

#endregion

#region Contains
//var student = new Student
//{
//    FirstName = "Nadir",
//    LastName = "Zamanov",
//    Age = 45,
//    GroupId = 3
//};
//Console.WriteLine(students.Contains(student));
//students.Add(student);
//Console.WriteLine(students.Contains(student));
#endregion

#region Where
//var result = students.Where(s => s.Age > 40).ToList();
///*
// var result = from s in students
//              where s.Age > 40
//              select s;

// */
//result.ForEach(Console.WriteLine);
#endregion

#region Min, Max, Average, Sum
//var minResult = students.Min(x => x.Age);
//Console.WriteLine(minResult);

//var maxResult = students.Max(x => x.Age);
//Console.WriteLine(maxResult);


//var summ = students.Sum(x => x.Age);
//Console.WriteLine(summ);
//Console.WriteLine(summ/ (double)students.Count);

//Console.WriteLine(students.Average(x=> x.Age));

#endregion


#region OrderBy, OrderByDescending, ThenBy, ThenByDescending

//var result = students.OrderBy(s => s.Age).ToList();
//result.ForEach(Console.WriteLine);

//var resultDesc = students.OrderByDescending(s => s.Age).ToList();
//resultDesc.ForEach(Console.WriteLine);

//var result2 = students.OrderByDescending(s => s.Age)
//                      .ThenBy(s => s.LastName)
//                      .ToList();
//result2.ForEach(Console.WriteLine);

#endregion
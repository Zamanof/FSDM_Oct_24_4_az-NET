// LINQ join
Console.WriteLine("Hello, World!");

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
    new Student{FirstName="Ali", LastName="Aliyev", Age=20, GroupId=1},
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
    new Student{FirstName="Rena", LastName="Suleymanli", Age=33, GroupId=8},
    new Student{FirstName="Murad", LastName="Ehmedov", Age=34, GroupId=8},
    new Student{FirstName="Sabina", LastName="Aliyeva", Age=35, GroupId=9},
    new Student{FirstName="Fidan", LastName="Memmedli", Age=36, GroupId=9},
    new Student{FirstName="Ilqar", LastName="Camalov", Age=37, GroupId=1},
    new Student{FirstName="Zehra", LastName="Ceferli", Age=38, GroupId=2},
    new Student{FirstName="Nicat", LastName="Ehmedzade", Age=39, GroupId=3},
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

var result = from g in groups
             join s in students on g.Id equals s.GroupId
             orderby s.FirstName
             select new
             {
                 FirstName = s.FirstName,
                 LastName = s.LastName,
                 Age = s.Age,
                 GroupName = g.Name,
                 Faculty = g.Faculty
             };
foreach(var stud in result)
{
    Console.WriteLine($"{stud.FirstName} {stud.LastName} {stud.Age} - {stud.GroupName} {stud.Faculty}");
}

var byGroup = from r in result
              group r by r.GroupName;

Console.WriteLine();

foreach (var gr in byGroup)
{
    Console.WriteLine(gr.Key);
    foreach (var stud in gr)
    {
        Console.WriteLine($"    {stud.FirstName} {stud.LastName} {stud.Age} - {stud.GroupName} {stud.Faculty}");

    }
}
// Standard interfaces

using System.Collections;

class Auditory: IEnumerable
{
    Student[] students = [
        new Student { FirstName = "Salam", LastName = "Salamzade", Email = "salamzade@salam.org", BirthDate = new DateTime(1991, 3, 23), StudentCard = new StudentCard { Id = 32645, Series = "AA" } },
    new Student { FirstName = "Aydin", LastName = "Aliyev", Email = "aydin.aliyev@example.com", BirthDate = new DateTime(1992, 5, 12), StudentCard = new StudentCard { Id = 32646, Series = "AB" } },
    new Student { FirstName = "Nigar", LastName = "Mammadova", Email = "nigar.mammadova@example.com", BirthDate = new DateTime(1990, 10, 8), StudentCard = new StudentCard { Id = 32647, Series = "AC" } },
    new Student { FirstName = "Emin", LastName = "Huseynov", Email = "emin.huseynov@example.com", BirthDate = new DateTime(1993, 7, 19), StudentCard = new StudentCard { Id = 32648, Series = "AD" } },
    new Student { FirstName = "Leyla", LastName = "Ibrahimova", Email = "leyla.ibrahimova@example.com", BirthDate = new DateTime(1991, 2, 28), StudentCard = new StudentCard { Id = 32649, Series = "AE" } },
    new Student { FirstName = "Rauf", LastName = "Kerimov", Email = "rauf.kerimov@example.com", BirthDate = new DateTime(1989, 12, 10), StudentCard = new StudentCard { Id = 32650, Series = "AF" } },
    new Student { FirstName = "Zahra", LastName = "Guliyeva", Email = "zahra.guliyeva@example.com", BirthDate = new DateTime(1994, 11, 3), StudentCard = new StudentCard { Id = 32651, Series = "AG" } },
    new Student { FirstName = "Kamran", LastName = "Ismayilov", Email = "kamran.ismayilov@example.com", BirthDate = new DateTime(1995, 4, 14), StudentCard = new StudentCard { Id = 32652, Series = "AH" } },
    new Student { FirstName = "Lala", LastName = "Rahimova", Email = "lala.rahimova@example.com", BirthDate = new DateTime(1992, 6, 25), StudentCard = new StudentCard { Id = 32653, Series = "AI" } },
    new Student { FirstName = "Javid", LastName = "Nasibov", Email = "javid.nasibov@example.com", BirthDate = new DateTime(1993, 1, 5), StudentCard = new StudentCard { Id = 32654, Series = "AJ" } },
    new Student { FirstName = "Sevda", LastName = "Qurbanova", Email = "sevda.qurbanova@example.com", BirthDate = new DateTime(1990, 9, 9), StudentCard = new StudentCard { Id = 32655, Series = "AK" } },
    new Student { FirstName = "Orxan", LastName = "Talibov", Email = "orxan.talibov@example.com", BirthDate = new DateTime(1988, 8, 21), StudentCard = new StudentCard { Id = 32656, Series = "AL" } },
    new Student { FirstName = "Gunay", LastName = "Tagiyeva", Email = "gunay.tagiyeva@example.com", BirthDate = new DateTime(1991, 3, 30), StudentCard = new StudentCard { Id = 32657, Series = "AM" } },
    new Student { FirstName = "Murad", LastName = "Aliyev", Email = "murad.aliyev@example.com", BirthDate = new DateTime(1996, 2, 18), StudentCard = new StudentCard { Id = 32658, Series = "AN" } },
    new Student { FirstName = "Ilham", LastName = "Gurbanov", Email = "ilham.gurbanov@example.com", BirthDate = new DateTime(1994, 7, 7), StudentCard = new StudentCard { Id = 32659, Series = "AO" } },
    new Student { FirstName = "Sona", LastName = "Mammadli", Email = "sona.mammadli@example.com", BirthDate = new DateTime(1990, 1, 17), StudentCard = new StudentCard { Id = 32660, Series = "AP" } },
    new Student { FirstName = "Tural", LastName = "Rustamov", Email = "tural.rustamov@example.com", BirthDate = new DateTime(1992, 9, 27), StudentCard = new StudentCard { Id = 32661, Series = "AQ" } },
    new Student { FirstName = "Nigar", LastName = "Gasimova", Email = "nigar.gasimova@example.com", BirthDate = new DateTime(1993, 10, 16), StudentCard = new StudentCard { Id = 32662, Series = "AR" } },
    new Student { FirstName = "Elchin", LastName = "Mustafayev", Email = "elchin.mustafayev@example.com", BirthDate = new DateTime(1989, 5, 6), StudentCard = new StudentCard { Id = 32663, Series = "AS" } },
    new Student { FirstName = "Zeynab", LastName = "Hajiyeva", Email = "zeynab.hajiyeva@example.com", BirthDate = new DateTime(1995, 11, 29), StudentCard = new StudentCard { Id = 32664, Series = "AT" } },
];

    public IEnumerator GetEnumerator()
    {
        return students.GetEnumerator();
    }

    public void Sort()
    {
        Array.Sort(students);
    }

    public void Sort(IComparer comparer)
    {
        Array.Sort(students);
    }

    public void Sort(Comparison<Student> comparer)
    {
        Array.Sort(students, comparer);
    }
}

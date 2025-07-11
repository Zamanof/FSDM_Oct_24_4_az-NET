﻿
Postgree postgree = new();
Application application = new(new JsonSerialization());
application.CRUD();

#region Bad example
//class MySQL
//{
//    public void Create() => Console.WriteLine("Create with MySQL");
//    public void Read() => Console.WriteLine("Read with MySQL");
//    public void Update() => Console.WriteLine("Update with MySQL");
//    public void Delete() => Console.WriteLine("Delete with MySQL");
//}
//class MSSQL
//{
//    public void Create() => Console.WriteLine("Create with MSSQL");
//    public void Read() => Console.WriteLine("Read with MSSQL");
//    public void Update() => Console.WriteLine("Update with MSSQL");
//    public void Delete() => Console.WriteLine("Delete with MSSQL");
//}
//class Postgree
//{
//    public void Create() => Console.WriteLine("Create with Postgree");
//    public void Read() => Console.WriteLine("Read with Postgree");
//    public void Update() => Console.WriteLine("Update with Postgree");
//    public void Delete() => Console.WriteLine("Delete with Postgree");
//}
//class Application
//{
//    private Postgree _db;

//    public Application(Postgree db)
//    {
//        _db = db;
//    }

//    public void CRUD()
//    {
//        _db.Create();
//        _db.Update();
//        _db.Read();
//        _db.Delete();
//    }
//}
#endregion

#region Good example
interface IDb
{
    void Create();
    void Read();
    void Update();
    void Delete();
}
class MySQL:IDb
{
    public void Create() => Console.WriteLine("Create with MySQL");
    public void Read() => Console.WriteLine("Read with MySQL");
    public void Update() => Console.WriteLine("Update with MySQL");
    public void Delete() => Console.WriteLine("Delete with MySQL");
}
class MSSQL:IDb
{
    public void Create() => Console.WriteLine("Create with MSSQL");
    public void Read() => Console.WriteLine("Read with MSSQL");
    public void Update() => Console.WriteLine("Update with MSSQL");
    public void Delete() => Console.WriteLine("Delete with MSSQL");
}
class Postgree: IDb
{
    public void Create() => Console.WriteLine("Create with Postgree");
    public void Read() => Console.WriteLine("Read with Postgree");
    public void Update() => Console.WriteLine("Update with Postgree");
    public void Delete() => Console.WriteLine("Delete with Postgree");
}

class JsonSerialization : IDb
{
    public void Create() => Console.WriteLine("Create with JsonSerialization");
    public void Read() => Console.WriteLine("Read with JsonSerialization");
    public void Update() => Console.WriteLine("Update with JsonSerialization");
    public void Delete() => Console.WriteLine("Delete with JsonSerialization");
}
class Application
{
    private IDb _db;

    public Application(IDb db)
    {
        _db = db;
    }

    public void CRUD()
    {
        _db.Create();
        _db.Update();
        _db.Read();
        _db.Delete();
    }
}
#endregion

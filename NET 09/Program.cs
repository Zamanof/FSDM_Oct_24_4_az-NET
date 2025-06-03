// Indexer
// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/
// public return_type this[params]{get; set;}

//Garage garage = new Garage(5);
//garage[0] = new Car { Model = "Toyota", Price = 152 };
//garage[1] = new Car { Model = "BMW", Price = 0.236 };
//garage[2] = new Car { Model = "Mercedes", Price = 256987 };
//garage[3] = new Car { Model = "Porsche", Price = 9853156 };
//garage[4] = new Car { Model = "Nissan", Price = 898998 };
//Console.WriteLine(garage[1]);
//Console.WriteLine(garage["BMW"]);

MultiArray multiArray = new(3, 3);
Random random = new();

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        multiArray[i, j] = random.Next(10, 99);
    }
}

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"{multiArray[i, j]} ");
    }
    Console.WriteLine();
}

class Car
{
    public string Model { get; set; }
    public double Price { get; set; }

    public override string ToString()
    {
        return $"{Model} - {Price} AZN";
    }
}

class Garage
{
    Car[] cars;

    public Garage(int count)
    {
        cars = new Car[count];
    }
    public int count
    {
        get => cars.Length;
    }

    // indexer
    public Car this[int index]
    {
        get
        {
            if (index >= 0 && index < cars.Length)
            {
                return cars[index];
            }
            throw new IndexOutOfRangeException();
        }

        set
        {
            if (index >= 0 && index < cars.Length)
            {
                cars[index] = value;
            }
            else  throw new IndexOutOfRangeException();

        }
    }

    public Car this[string model] 
    {
        get
        {
            if (Enum.IsDefined(typeof(models), model))
            {
                return cars[(int) Enum.Parse(typeof(models), model)];
            }
            throw new IndexOutOfRangeException();
        }

        set
        {
            if (Enum.IsDefined(typeof(models), model))
            {
                cars[(int)Enum.Parse(typeof(models), model)] = value;
            }
            else throw new IndexOutOfRangeException();

        }
    }

}

class MultiArray
{
    int[,] array;
    public int Rows { get; set; }
    public int Columns { get; set; }

    public MultiArray(int rows, int columns)
    {
        Rows = rows;
        Columns = columns;
        array = new int[rows, columns];
    }
    // indexer
    public int this[int row, int column]
    {
        get => array[row, column];
        set => array[row, column] = value;
    }
}

enum models { Toyota, BMW, Mercedes, Porsche, Nissan, Hyundai, Tesla }
// Liskov substitution

Rectangle rectangle = new(width: 25, height: 15);
Console.WriteLine(Calculate.Area(rectangle));
rectangle.Width = 10;
Console.WriteLine(Calculate.Area(rectangle));

Console.WriteLine();

Rectangle square = new Square(side: 15);
Console.WriteLine(Calculate.Area(square));
square.Width = 10;
Console.WriteLine(Calculate.Area(square));


#region Bad Example
//class Rectangle
//{
//    public double Width {  get; set; }
//    public double Height { get; set; }

//    public Rectangle(double width, double height)
//    {
//        Width = width;
//        Height = height;
//    }
//}

//class Square : Rectangle
//{
//    public Square(double side) : base(side, side)
//    {}
//}

//class Calculate
//{
//    public static double Area(Rectangle rectangle) 
//                        => rectangle.Width * rectangle.Height;   
//}

#endregion

#region Good example
class Rectangle
{
    public virtual double Width { get; set; }
    public virtual double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }
}

class Square : Rectangle
{
    public override double Width
    {
        get => base.Width;
        set
        {
            base.Width = value;
            base.Height = value;
        }
    }
    public override double Height 
    {
        get => base.Height;
        set
        {
            base.Width = value;
            base.Height = value;
        }
    }
    public Square(double side) : base(side, side)
    { }
}

class Calculate
{
    public static double Area(Rectangle rectangle)
                        => rectangle.Width * rectangle.Height;
}
#endregion

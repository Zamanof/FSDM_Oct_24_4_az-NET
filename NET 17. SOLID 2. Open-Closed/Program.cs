// Open/Closed principles

#region Bad example
//object[] shapes = [
//    new Rectangle(){Height = 15, Width = 20},
//    new Rectangle(){Height = 877, Width = 30},
//    new Circle(){Radius = 69.26},
//    new Triangle(){Base = 98, Height=25.6}

//    ];

//CalculateArea areas = new();
//Console.WriteLine(areas.Areas(shapes));
//class Rectangle
//{
//    public double Width {  get; set; }
//    public double Height { get; set; }
//}

//class Circle
//{
//    public double Radius { get; set; }
//}

//class Triangle
//{
//    public double Height { get; set; }
//    public double Base { get; set; }
//}

//class CalculateArea
//{
//    public double Areas(object[] shapes)
//    {
//        double areas = 0;
//        foreach (object shape in shapes)
//        {
//            if (shape is Rectangle rectangle)
//            {
//                areas += rectangle.Width * rectangle.Height;
//            }
//            else if (shape is Circle circle)
//            {
//                areas += Math.Pow(circle.Radius, 2) * Math.PI;
//            }
//            else if (shape is Triangle triangle)
//            {
//                areas += 0.5 * triangle.Base * triangle.Height;
//            }
//        }
//        return areas;
//    }
//}
#endregion


#region Good example
//Shape[] shapes = [
//    new Rectangle(){Height = 15, Width = 20},
//    new Rectangle(){Height = 877, Width = 30},
//    new Circle(){Radius = 69.26},
//    new Triangle(){Base = 98, Height=25.6},
//    new Romb(){Side =0.5, Height = 0.1}
//    ];

//CalculateAreas Areas = new CalculateAreas();
//Console.WriteLine(Areas.Areas(shapes));

//abstract class Shape
//{
//    public abstract double Area();
//}
//class Rectangle : Shape
//{
//    public double Width { get; set; }
//    public double Height { get; set; }
//    public override double Area() => Height * Width;
//}

//class Circle : Shape
//{
//    public double Radius { get; set; }
//    public override double Area() => Math.Pow(Radius, 2) * Math.PI;
//}

//class Triangle : Shape
//{
//    public double Height { get; set; }
//    public double Base { get; set; }
//    public override double Area() => Height * Base * 0.5;
//}

//class Romb: Shape
//{
//    public double Side {  get; set; }
//    public double Height { get; set; }

//    public override double Area()=> Side * Height;
//}

//class NeIseBirFiqur: Shape
//{
//    public double Zumba {  get; set; }
//    public int Filsa {  get; set; }
//    public double Sibusana {  get; set; }

//    public override double Area() 
//        => Math.Sqrt(Math.Sin(Sibusana)) * 0.5 / Zumba + Math.Tan(Filsa);
//}

//class CalculateAreas
//{
//    public double Areas(Shape[] shapes) => shapes.Sum(x => x.Area());
//}
#endregion

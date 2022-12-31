using GraphicsLibrary;

internal class Program
{
    private static void Main(string[] args)
    {

       SortedList<Int32, Shapes> shapesList =new SortedList<Int32, Shapes>();
        Point p1, p2, p3;
        int choice,count =0;

        do
        {
            Console.WriteLine("Enter choice to select Shape.\n1.Circle\n2.Triangle\n3.Rectangle\n4.Display all shapes\n5.Exit");
            choice = Convert.ToInt16(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the coordinate for Center of the circle and Point on the circle ");
                    Console.WriteLine("Coordinate X and Y for Center of Circle");
                    p1 = new Point(Convert.ToInt16(Console.ReadLine()), Convert.ToInt16(Console.ReadLine()));
                    Console.WriteLine("Coordinate X and Y for Point on the Circle");
                    p2 = new Point(Convert.ToInt16(Console.ReadLine()), Convert.ToInt16(Console.ReadLine()));
                    Shapes circle = new Circle(p1, p2);
                    count++;
                    shapesList.Add(count, circle);
                    Console.WriteLine(circle);
                    break;

                case 2:
                    Console.WriteLine("Enter three coordinate for Triangle");
                    Console.WriteLine("Coordinate X and Y for 1st Vertex on the Triangle");
                    p1 = new Point(Convert.ToInt16(Console.ReadLine()), Convert.ToInt16(Console.ReadLine()));
                    Console.WriteLine("Coordinate X and Y for 2nd Vertex on the Triangle");
                    p2 = new Point(Convert.ToInt16(Console.ReadLine()), Convert.ToInt16(Console.ReadLine()));
                    Console.WriteLine("Coordinate X and Y for 3rd Vertex on the Triangle");
                    p3 = new Point(Convert.ToInt16(Console.ReadLine()), Convert.ToInt16(Console.ReadLine()));
                    Shapes triangle = new Triangle(p1, p2, p3);
                    count++;
                    shapesList.Add(count, triangle);
                    Console.WriteLine(triangle);
                    break;

                case 3:
                    Console.WriteLine("Enter three coordinate for Rectangle");
                    Console.WriteLine("Coordinate X and Y for 1st vertex on the Rectangle");
                    p1 = new Point(Convert.ToInt16(Console.ReadLine()), Convert.ToInt16(Console.ReadLine()));
                    Console.WriteLine("Coordinate X and Y for 2nd vertex on the Rectangle");
                    p2 = new Point(Convert.ToInt16(Console.ReadLine()), Convert.ToInt16(Console.ReadLine()));
                    Console.WriteLine("Coordinate X and Y for 3rd vertex on the Rectangle");
                    p3 = new Point(Convert.ToInt16(Console.ReadLine()), Convert.ToInt16(Console.ReadLine()));
                    Shapes rectangle = new Rectangle(p1, p2, p3);
                    count++;
                    shapesList.Add(count, rectangle);
                    Console.WriteLine(rectangle);
                    break;

                case 4:
                 Console.WriteLine("Display all shapes");
                 foreach(KeyValuePair<Int32, Shapes> s in shapesList){
                        Console.WriteLine(s.Key + " " + s.Value);
                    }
                    break;

                case 5:
                    Console.WriteLine("Thankyou");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        } while (choice != 4);
    }
}
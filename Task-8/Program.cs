using System;
using System.Runtime.Intrinsics.Arm;
using Task_8.Interfaces;
using static Task_8.ShapePart2;

namespace Task_8
{
    internal class Program
    {
        #region Method in part 2 problem 1
        //public static void PrintTenShapes(IShapeSeries series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine(series.CurrentShapeArea);
        //        series.GetNextArea();
        //    }
        //}
        #endregion

        #region Method in part 2 problem 4
        public static void SelectionSort(double[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - 1 - i; j++)
                {
                    if (numbers[j].CompareTo(numbers[j + 1]) == 1)
                    {
                        Swap(ref numbers[j], ref numbers[j + 1]);
                    }
                }
            }
            Array.Reverse(numbers);
        }
        public static void Swap(ref double a, ref double b)
        {
            double temperary = a;
            a = b;
            b = temperary;
        }
        #endregion

        static void Main(string[] args)
        {
            #region Problem-1

            #region Car class
            //IVehicle car = new Car();
            //car.StartEngine();
            //car.StopEngine();
            #endregion

            #region Bike class
            //IVehicle bike = new Bike();
            //bike.StartEngine();
            //bike.StopEngine();
            #endregion

            #endregion

            #region Question-1
            // so we can change the method implementation for each class and that reduces redundance and improves readability and performance
            // This is a principle of solid design to use the same thing with difference in function according to each class.
            #endregion

            #region Problem-2
            //#region Class section
            //    #region Rectangle
            //        Shape rectangle = new rectangle(3,4);
            //        Console.WriteLine($"The area is {rectangle.GetArea()}");
            //        rectangle.Display();
            //        Console.WriteLine();
            //    #endregion
            //    #region Circle
            //        Shape circle = new circle(10);
            //        Console.WriteLine($"The area is {circle.GetArea()}");
            //        circle.Display();
            //        Console.WriteLine();
            //    #endregion
            //#endregion

            //#region Interface Section
            //    #region Rectangle
            //        IShape Rectangle = new Rectangle(5, 6);
            //        Console.WriteLine($"The area is {Rectangle.GetArea()}");
            //        Rectangle.Display();
            //        Console.WriteLine();
            //    #endregion
            //    #region Circle
            //        IShape Circle = new Circle(20);
            //        Console.WriteLine($"The area is {Circle.GetArea()}");
            //        Circle.Display();
            //    #endregion
            //#endregion
            #endregion

            #region Question-2
            // The abstract class is better in following cases:
            // 1- if all the inherited classes share the same methods.
            // 2- in case I want to provide a default implementation for any method.
            // 3- in case of entering values and using constructor to process these data.

            // The interface is better in following case:
            // when i want to build a code contract that its body is implemented different in each class
            #endregion

            #region Problem-3
            //Product[] Prod = new Product[]
            //{
            //new Product(4, "TV", 987),
            //new Product(2, "book", 864),
            //new Product(3, "mobile", 688),
            //new Product(1, "Watch",  254),
            //};

            //Array.Sort(Prod);

            //foreach (Product product in Prod)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region Question-3
            // it helps to change the behaviour of any method to anything the developer wants and this logic can be used across solution normally
            // and this behaviour can be changed easily.
            #endregion

            #region Problem-4
            //Student S1 = new Student(1,"Karim",99);
            //Student S2 = S1; // Shallow Copy (points to same place in heap)
            //Student S3 = new Student(S1); //Deep Copy (points to difference place with same data in heap)
            //S1.disp();
            //S2.disp();
            //S3.disp();
            //S1.Id = 55;
            //S1.Name = "Omar";
            //S1.Grade = 88;
            //S1.disp();
            //S2.disp();
            //S3.disp();
            #endregion

            #region Question-4
            // it's used to duplicate the data present in an object by creating a totally new object with same data in it which is equal to deep copy.
            #endregion

            #region Problem-5
            //IWalk walk = new robot();
            //walk.walk();
            //IWalkable walkable = new robot();
            //walkable.walk();
            #endregion

            #region Question-5
            // It helps to differentiate between methods when there are different interfaces having same methods' name but different functionality.
            #endregion

            #region Problem-6
            //Account acc1 = new Account(3, "Ali", 7992);
            //Console.WriteLine(acc1.ACCOUNTID);
            //Console.WriteLine(acc1.ACCOUNTHOLDER);
            //Console.WriteLine(acc1.BALANCE);
            //acc1.ACCOUNTID = 55;
            //Account acc2 = acc1;
            //Console.WriteLine(acc2.ACCOUNTID);
            //Console.WriteLine(acc2.ACCOUNTHOLDER);
            //Console.WriteLine(acc2.BALANCE);
            #endregion

            #region Question-6
            // The main difference is where they are stored in memory as we know that struct is a value type and class is a reference type.
            // The change isn't saved in the same reference but if we made a change in any value. 
            #endregion

            #region Question-7
            // it's a conception in OOP that states to hide all complex details and show only the focus on the essentials properties to user.
            // this is used to show more of what the object does rather than how the object does.

            // The relation is obvious, encapsulation hides the inner details in like a blackbox and makes the user deal only with input or output of
            // method. But abstraction is hiding complex and implementation details. 
            #endregion

            #region Problem-8
            //Book b1 = new Book();
            //Console.WriteLine(b1.Author); //null
            //Console.WriteLine(b1.Title);  //null
            //Book b2 = new Book("Oliver Twist");
            //Console.WriteLine(b2.Author); //null
            //Console.WriteLine(b2.Title);  //Oliver Twist
            //Book b3 = new Book("Harry Potter", "J.K.Rowling");
            //Console.WriteLine(b3.Author); //Harry Potter
            //Console.WriteLine(b3.Title);  // J.K.Rowling
            #endregion

            #region Question-8
            // it provides different constructors using same name to initialize different values of attributes present inside the class based on
            // the parameters defined in the object definition.
            #endregion

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 
            //part 2

            #region Problem-1
            //IShapeSeries square = new SquareSeries();
            //PrintTenShapes(square);
            //IShapeSeries circle = new CircleSeries();
            //PrintTenShapes(circle);
            #endregion

            #region Problem-2
            //ShapePart2[] Shapes = new ShapePart2[]
            //{
            //new Square2(9),        //81
            //new Circle2(2),        //12.
            //new Rectangle2(3,4),   //12
            //new Square2(2),        //4
            //new Circle2(8),        //201.
            //new Rectangle2(11,12)  //132
            //};
            //Array.Sort(Shapes);
            //foreach (var shape in Shapes)
            //{
            //    Console.WriteLine(shape.Area);
            //}
            #endregion

            #region Problem-3
            //GeometricShape Triangle = new Triangle3(6,8);
            //Console.WriteLine($"The perimeter of triangle is {Triangle.Perimeter}");
            //Console.WriteLine($"The area of triangle is {Triangle.CalculateArea()}");

            //GeometricShape Rectangle = new Rectangle3(8,10);
            //Console.WriteLine($"The premiter of rectangle is {Rectangle.Perimeter}");
            //Console.WriteLine($"The area of rectangle is {Rectangle.CalculateArea()}");
            #endregion

            #region Problem-4
            //double[] areas = new double[Shapes.Length];
            //for (int i = 0;i < areas.Length;i++)
            //{
            //    areas[i] = Shapes[i].Area;
            //}
            //SelectionSort(areas);
            //foreach (var area in areas)
            //{
            //    Console.WriteLine(area);
            //}
            #endregion
        }
    }
}


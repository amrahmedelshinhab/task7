namespace task7
{



   /* define a class car with properties id, brand, and price.
    using system;

    class car
    {
        public int id { get; set; }
        public string brand { get; set; }
        public double price { get; set; }


        public car()
        {
            id = 6;
            brand = "byd";
            price = 5452000;
        }

        public car(int id)
        {
            id = id;
            brand = "bmw";
            price = 6000;
        }

        public car(int id, string brand)
        {
            id = id;
            brand = brand;
            price = 0.0;
        }


        public car(int id, string brand, double price)
        {
            id = id;
            brand = brand;
            price = price;
        }

        public override string tostring()
        {
            return $"car(id: {id}, brand: {brand}, price: {price})";
        }
    }

    class program
    {
        static void main()
        {

            car car1 = new car();
            console.writeline(car1);

            car car2 = new car(101);
            console.writeline(car2);

            car car3 = new car(102, "toyota");
            console.writeline(car3);

            car car4 = new car(103, "bmw", 50000);
            console.writeline(car4);
        }
    }*/


    /*o Write a class Calculator with overloaded Sum() methods to:

    using System;

    class Calculator
    {

        public int Sum(int a, int b)
        {
            return a + b;
        }


        public int Sum(int a, int b, int c)
        {
            return a + b + c;
        }


        public double Sum(double a, double b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main()
        {
            Calculator calc = new Calculator();


            Console.WriteLine("Sum of 2 integers: " + calc.Sum(3, 5));
            Console.WriteLine("Sum of 3 integers: " + calc.Sum(1, 2, 3));
            Console.WriteLine("Sum of 2 doubles: " + calc.Sum(2.5, 3.5));
        }
    }*/



    /*  o Create a base class Parent with properties X and Y, and a constructor to initialize them.


    using System;

    class Parent
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Parent(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"Parent(X: {X}, Y: {Y})";
        }
    }

    class Child : Parent
    {
        public int Z { get; set; }

        public Child(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }

        public override string ToString()
        {
            return $"Child(X: {X}, Y: {Y}, Z: {Z})";
        }
    }

    class Program
    {
        static void Main()
        {

            Child child = new Child(3, 4, 5);
            Console.WriteLine(child);
        }
    }*/



    /*o Override the ToString() method in Parent to return (X, Y) and in Child to return 
    (X, Y, Z). 


    using System;

    class Parent
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Parent(int x, int y)
        {
            X = x;
            Y = y;
        }


        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    class Child : Parent
    {
        public int Z { get; set; }

        public Child(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }

        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }

    class Program
    {
        static void Main()
        {

            Parent parent = new Parent(5, 10);
            Console.WriteLine("Parent object: " + parent);

            // إنشاء كائن من الصف Child
            Child child = new Child(5, 10, 15);
            Console.WriteLine("Child object: " + child);

            Parent polymorphicParent = child;
            Console.WriteLine("Polymorphic Parent object: " + polymorphicParent);
        }
    }

    */


    /*  o Define an interface IShape with:
    using System;


    interface IShape
    {
        double Area { get; } 
        void Draw(); 
    }

    class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Area
        {
            get { return Width * Height; }
        }


        public void Draw()
        {
            Console.WriteLine($"Drawing a rectangle with Width: {Width} and Height: {Height}");
        }
    }

    class Program
    {
        static void Main()
        {

            IShape rectangle = new Rectangle(5, 10);

            rectangle.Draw();


            Console.WriteLine($"Area of Rectangle: {rectangle.Area}");
        }
    }*/

    /*o Modify the IShape interface to include a default implementation of a method

    using System;


    interface IShape
    {
        double Area { get; }  
        void Draw();  


        public void PrintDetails()
        {
            Console.WriteLine("Shape Details:");
            Draw();
            Console.WriteLine($"Area: {Area}");
        }
    }

    class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area
        {
            get { return Math.PI * Radius * Radius; }
        }


        public void Draw()
        {
            Console.WriteLine($"Drawing a circle with Radius: {Radius}");
        }
    }

    class Program
    {
        static void Main()
        {

            IShape circle = new Circle(5);

            circle.PrintDetails();
        }
    }*/


    /*o Define an interface IMovable with a method Move().

    using System;

    interface IMovable
    {
        void Move();  
    }


    class Car : IMovable
    {
        public string Model { get; set; }

        public Car(string model)
        {
            Model = model;
        }


        public void Move()
        {
            Console.WriteLine($"{Model} is moving!");
        }
    }

    class Program
    {
        static void Main()
        {
            IMovable myCar = new Car("Toyota");


            myCar.Move();
        }
    }*/


    /*roblem: 
    o Create two interfaces, IReadable and IWritable, each with a method (Read() and 
    Write()). 

    using System;


    interface IReadable
    {
        void Read(); 


    interface IWritable
    {
        void Write();  

    class File : IReadable, IWritable
    {
        public string Content { get; set; }

        public File(string content)
        {
            Content = content;
        }


        public void Read()
        {
            Console.WriteLine($"Reading content: {Content}");
        }


        public void Write()
        {
            Console.WriteLine($"Writing content: {Content}");
        }
    }

    class Program
    {
        static void Main()
        {
            File myFile = new File("Hello, World!");


            myFile.Read();


            myFile.Write();
        }
    }*/



    /*o Create a base class Shape with: 


    using System;

    abstract class Shape
    {
      
        public virtual void Draw()
        {
            Console.WriteLine("Drawing Shape");
        }

       
        public abstract double CalculateArea();
    }

 
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        
        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }

        
        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main()
        {
           
            Rectangle rectangle = new Rectangle(5, 10);

            
            rectangle.Draw();

       
            Console.WriteLine($"Area of Rectangle: {rectangle.CalculateArea()}");
        }
    }*/



}

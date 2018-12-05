using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void ChangeTheString(string weather) { weather = "sunny"; }

        public static void ChangeTheArray(string[] rainyDays) { rainyDays[1] = "Sunday"; }

        public static void ChangeTheClassInstance(Forecast forecast) { forecast.Temperature = 35; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Int32 a;
            Double d;
            Decimal dec;

            String str1;
            // Long is not a Reference Type! Long lng1;
            Boolean b;

            String[] dogs = new string[] { "Peanut", "Fifi", "Bigi", "Fido", "Clarence" };

            int[] intArray = new int[5];
            intArray[0] = 3;

            // Array size cannot be specified in a variable declaration(try initializing with a 'new' expression)
            //int[5] intArray2 = new int[];

            Pet pet = new Cat();
            Shape shape = new Ball();
            Console.WriteLine(string.Format("My {0} is playing with a {1}.", pet.GetName() , shape.GetName()));

            string weather = "rainy";
            ChangeTheString(weather);
            Console.WriteLine("The weather is " + weather);
            string[] rainyDays = new[] { "Monday", "Friday" };

            ChangeTheArray(rainyDays);

            Console.WriteLine("The rainy days were on " + rainyDays[0] + " and " + rainyDays[1]);

            Forecast forecast = new Forecast { Pressure = 700, Temperature = 20 }; ChangeTheClassInstance(forecast);

            Console.WriteLine("The temperature is " + forecast.Temperature + "°C");


            var housel = new House(4, 2010);
            var house2 = new House(2, 2017);

            var person = new Person { Name="Ajit"};
            person.SaySomething();

            Console.ReadLine();
        }
    }

    public class Shape
    {
        public string GetName() { return "shape"; }
    }

    public class Ball : Shape
    {
        public new string GetName() { return "ball"; }
    }

    public class Pet
    {
        public virtual string GetName() { return "pet"; }
    }

    public class Cat : Pet
        {
            public override string GetName() { return "cat"; }
        }

    public class Forecast
    {
        public int Temperature { get; set; }
        public int Pressure { get; set; }
    }

    public class Building
    {
        public Building(int yearBuilt)
        {
            Console.WriteLine($"The building was built in {yearBuilt}");

        }
    }

    public class House : Building
    {
        // Note the sub class of House from Building 
        // $ - string interpolation (C# Reference)    https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
        // The base keyword is used to access members of the base class from within a derived class: Call a method on the base class that has 
        // been overridden by another method.Specify which base-class constructor should be called when creating instances of the derived class.
        public House( int numberOfBedrooms, int yearBuilt) : base(yearBuilt)
        {
            Console.WriteLine($"The house has {numberOfBedrooms}  number of bedrooms");
        }

        static House()
        {
            Console.WriteLine("That's a house...");
        }
    }

    class Person
    {
        public string Name;
        public void SaySomething()
        {
            Console.WriteLine($"Hello, I am a Person. My name is {Name}")
                
                ;
        }
    }
}

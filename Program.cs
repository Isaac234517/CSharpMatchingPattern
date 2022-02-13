using System;

namespace PatternMatching
{
    class Program
    {

        class Person{
            public string PersonGreeting => "Hello";
        }

        class Dog {
            public string DogGreeting => "Wow";
        }

        class Cat {
            public string CatGreeting => "Mei";
        }


        class Point {

            public int X;
            public int Y;
            public Point(int x,int y)=> (X,Y) = (x,y);

            public void Deconstruct(out int x, out int y) => (x, y) = (X,Y);
        }

        static void Main(string[] args)
        {

            // Type checking Example

            int? testVariable = 19;
            string testString = "Hello";
            if(testVariable is null)
                Console.WriteLine($"test variable is null");
            else
                Console.WriteLine("test variable is not null");

            if(testString is not null && testString is string newStr){
                Console.WriteLine($"New Test String is {newStr}");
            }


            Person p = new Person();
            Dog d = new Dog();
            PrintMessage(p);
            PrintMessage(d);

            string cod = "X";

            string result = SwitchExpression(cod);
            Console.WriteLine(result);
            cod = "Y";
            result = SwitchExpression(cod);
            Console.WriteLine(result);

            Console.WriteLine(HighLowDetermine(200));

            Point point = new Point(1,-1);
            Console.WriteLine(Quardant(point));
            Console.ReadLine();
        }


        static void PrintMessage(object a){
            switch(a){
                case Person p:
                    Console.WriteLine(p.PersonGreeting);
                    break;
                
                case Dog d:
                    Console.WriteLine(d.DogGreeting);
                    break;

                case Cat c:
                    Console.WriteLine(c.CatGreeting);
                    break;
                default:
                    break;
            }
        }

        static string SwitchExpression(string cod) => cod switch {
            "X" => "X value",
            "Y" => "Y value",
            _ => "Default value"
        };

        static string HighLowDetermine(int num) => num switch {
            >100 => "High value",
            < 20 => "Low value",
            _ => "Normal value"
        };

        static string Quardant(Point p) => p switch {
            (> 0, > 0) => "First Quardant",
            (<0, > 0) => "Second Quardant",
            (<0, <0) => "Third Quardant",
            _=> "Fourth Quardant"
        };
    }
}

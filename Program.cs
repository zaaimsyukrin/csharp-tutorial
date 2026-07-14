using System.Collections.Generic;
using LivingThings;
namespace Csharp
{
    interface IExampleA
    {
        void F1();
        int F2();
    }

    public abstract class ExampleB
    {
        string Name{get; set;}
        public ExampleB() : this("<blank>")
        {
            System.Console.WriteLine("B constructor 0 param");
        }
        public ExampleB(string x)
        {
            System.Console.WriteLine("B constructor 1 param");
            Name = x;
        } 
        abstract public void MustImplement();
        public void PrintAtt()
        {
            System.Console.WriteLine(Name);
        }
    }

    public class A : ExampleB, IExampleA
    {
        public A() : base()
        {
            System.Console.WriteLine("child constructor");
        }

        public override void MustImplement()
        {
            System.Console.WriteLine("Some implementation.");
        }

        public void F1()
        {
            System.Console.WriteLine("This is F1 from interface");
        }

        public int F2()
        {
            System.Console.WriteLine("This is F2 from interface");
            return 0;
        }
    }

    public class Dog : Animal
    {
        public Dog()
        {
            Name = "";
        }

        public Dog(string Name)
        {
            this.Name = Name;
        }
        public override void MakeSound()
        {
            System.Console.WriteLine("Woof!");
        }
    }

    public class Cat : Animal
    {
        public Cat()
        {
            Name = "";
        }

        public Cat(string _name)
        {
            Name = _name;
        }
        public override void MakeSound()
        {
            System.Console.WriteLine("Meow!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals =
            [
                new Dog("Rex"),
                new Cat("Whiskers"),
                new ("Generic")
            ];
            foreach (Animal a in animals)
            {
                a.PrintInfo();
                a.MakeSound();
            }
            System.Console.WriteLine(Animal.Count + " animals created.\n");
            A classA = new();
            // classA.F1();
            // int x = classA.F2();
            // classA.MustImplement();
            // classA.PrintAtt();
        }
    }
}

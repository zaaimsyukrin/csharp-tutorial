using System.Runtime.InteropServices.Marshalling;

namespace LivingThings
{
    public class Animal
    {
        public string Name{get; protected set;} // a property: getter can be accessed publicly, but not setter
        public static int Count // this will be shared across all objects
        {
            get; private set;
        }

        public Animal()
        {
            Name = "";
            Count++;
        }
        public Animal(string _name)
        {
            Name = _name;
            Count++;
        }
        public virtual void MakeSound()
        {
            System.Console.WriteLine("Generic sound");
        }
        public void PrintInfo()
        {
            System.Console.WriteLine(Name);
        }
        public void ChangeInfo(string Name)
        {
            this.Name = Name;
        }
    }
}
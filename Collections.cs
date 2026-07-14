using System;
using System.Collections.Generic;
using Csharp;
using LivingThings;
namespace CollectionsDemo{
    class CollectionsDemo
    {
        public static void Main(string[] args)
        {
            // -- Array : fixed size sequence of elements
            // can contain primitive data and also objects
            
            // shorthand (no need new Animal[]{})
            // can use []
            Animal[] animals = [new Dog("Scotch"), new("Butter"), new("Renji"), new Cat("Garfield")];
            
            // Shorthand doesn't work in this case (need new Animal[]{})
            Animal[] animals2;
            animals2 = new Animal[]{new Dog("Scotch"), new Cat("Garfield")};

            Array.Sort(animals);
            foreach(Animal a in animals)
            {
                a.PrintInfo();
            }

            // -- Jagged array : array of arrays where each element can have different size
            int[][] jaggedArr = [[1], [2,4], [3], [4,4,2]];

            // -- Sorting an array (needs comparator for non-primitive)
            

            // -- List
            List<string> lstring = ["Apple", "Orange"];
            lstring.Add("Mangosteen");
            foreach (string s in lstring)
            {
                System.Console.WriteLine(s);
            }
        }
    }

    
}
//Name: Spencer Karpati
//Filename: World.cs
//Date: 1/19/2023
//Description: This program helps with learning C# and the concept of abstract and concrete classes.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using BaseClass;

class World
{
    List<Animal> animalList = new List<Animal>();
    static public void Main(String[] args)
    {
        Cat cat = new Cat();
        Cassowary cassowary = new Cassowary();
        Austin_Powers Powers = new Austin_Powers();

        cat.printInfo();
        cat.makeNoise();
        cat.ageUp();

        Console.WriteLine();

        cassowary.printInfo();
        cassowary.makeNoise();
        cassowary.ageUp();

        Console.WriteLine();

        Powers.printInfo();
        Powers.makeNoise();
        Powers.ageUp();

        Console.Read();
    }
}
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

class World
{
    List<Animal> animalList = new List<Animal>();
    static public void Main(String[] args)
    {
        Cat cat = new Cat("Cat", "Meow", 3, 9);
        Cassowary cassowary = new Cassowary("Cassowary", "*Horrifying Rumbling Noises*", 27, 98);
        Austin_Powers powers = new Austin_Powers("Austin Powers", "YEAHH BAYBEE YEAHH", 64, 172);

        Console.WriteLine();

        cat.printInfo();
        cat.makeNoise();
        cat.ageUp();

        Console.WriteLine();

        cassowary.printInfo();
        cassowary.makeNoise();
        cassowary.ageUp();

        Console.WriteLine();

        powers.printInfo();
        powers.makeNoise();
        powers.ageUp();

        Console.Read();
    }
}
//Name: Spencer Karpati
//Filename: Cassowary.cs
//Date: 1/19/2023
//Description: This is the Cassowary Subclass.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

public class Cassowary : Animal
{
    public Cassowary(string name, string noise, int age, int weight) : base(name, noise, age, weight)
    {
        Console.WriteLine("Cassowary inherits Animal's parameterized constructor");
    }

    public override void printInfo()
    {
        base.printInfo();
        Console.WriteLine("Better Name: Devil Bird");
    }

    public override void makeNoise()
    {
        base.makeNoise();
        Console.WriteLine("*Dinosaur-Like Sounds*");
    }

    public override void ageUp()
    {
        Console.WriteLine("The Cassowary has gotten older.");
        Console.Write("Age: ");
        base.ageUp();
    }
}
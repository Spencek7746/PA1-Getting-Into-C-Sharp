//Name: Spencer Karpati
//Filename: Cat.cs
//Date: 1/19/2023
//Description: This is the Cat Subclass.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

public class Cat : Animal
{
    public Cat(string name, string noise, int age, int weight) : base(name, noise, age, weight)
    {
        Console.WriteLine("Cat inherits Animal's parameterized constructor");
    }

    public override void printInfo()
    {
        base.printInfo();
        Console.WriteLine("Likes: Catnip, Acting like an absolute buffoon when you are trying to sleep");
    }

    public override void makeNoise()
    {
        base.makeNoise();
        Console.WriteLine("Purrrrrrr");
    }

    public override void ageUp()
    {
        Console.WriteLine("The cat has gotten older.");
        Console.Write("Age: ");
        base.ageUp();
    }
}
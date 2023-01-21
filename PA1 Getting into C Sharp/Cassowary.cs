//Name: Spencer Karpati
//Filename: Cassowary.cs
//Date: 1/19/2023
//Description: This is the Cassowary Subclass.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using BaseClass;

public class Cassowary : Animal
{
    public override void printInfo()
    { 
        Console.WriteLine("Better Name: Devil Bird");
    }

    public override void makeNoise()
    {
        Console.WriteLine("*Dinosaur-Like Sounds*");
    }

    public override void ageUp()
    {
        Console.WriteLine("The Cassowary has gotten older.");
    }
}
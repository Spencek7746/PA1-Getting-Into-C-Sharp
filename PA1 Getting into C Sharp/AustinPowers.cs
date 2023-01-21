//Name: Spencer Karpati
//Filename: AustinPowers.cs
//Date: 1/19/2023
//Description: This is the Austin Powers Subclass.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

public class Austin_Powers : Animal
{
    public Austin_Powers(string name, string noise, int age, int weight) : base(name, noise, age, weight)
    {
        Console.WriteLine("Powers inherits Animal's parameterized constructor");
    }

    public override void printInfo()
    {
        base.printInfo();
        Console.WriteLine("Alias: International Man of Mystery");
        Console.WriteLine("Vehicle: ShagMobile");
    }
    public override void makeNoise()
    {
        base.makeNoise();
        Console.WriteLine("Shagadelic");
    }

    public override void ageUp()
    {
        Console.WriteLine("I still have my mojo baybee");
        Console.Write("Age: ");
        base.ageUp();
    }
}
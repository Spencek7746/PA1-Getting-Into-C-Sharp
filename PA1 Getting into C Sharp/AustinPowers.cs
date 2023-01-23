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

public class Austin_Powers : Animal //The Austin_Powers class will inherit Animal's methods and variables.
{
    public Austin_Powers(string name, string noise, int age, int weight) : base(name, noise, age, weight) //The Animal parameterized constructor has been inherited. This will help with creating a powers object in main.
    {
        Console.WriteLine("Powers inherits Animal's parameterized constructor");
    }

    public void printPowers(string choice)
    {
        Console.WriteLine("Please enter a number to continue:");
        Console.WriteLine("1: Show info");
        Console.WriteLine("2: Make noise");
        Console.WriteLine("3: Age up");

        switch (choice)
        {
            case "1":
                printInfo(); //Calling inherited methods.
                Console.WriteLine();
                break;
            case "2":
                makeNoise();
                Console.WriteLine();
                break;
            case "3":
                ageUp();
                Console.WriteLine();
                break;
            default:
                Console.WriteLine("Please enter a valid number from the choices shown.");
                Console.WriteLine();
                break;
        }
    }

    //Each method from Animal will be overridden by the Austin_Powers class to add more upon the inherited implementation.
    public override void printInfo()
    {
        base.printInfo(); //Calling base implementaion.
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
        Console.WriteLine("Powers has gotten older.");
        Console.WriteLine("I still have my mojo baybee");
        Console.Write("Age: ");
        base.ageUp();
    }
}
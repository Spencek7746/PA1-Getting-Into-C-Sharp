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

public class Cat : Animal //The Cat class will inherit Animal's methods and variables.
{
    public Cat(string name, string noise, int age, int weight) : base(name, noise, age, weight) //The Animal parameterized constructor has been inherited. This will help with creating a cat object in main.
    {
        Console.WriteLine("Cat inherits Animal's parameterized constructor");
    }

    public void printCat(string choice) //function to print cat releated info
    {
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

    //Each method from Animal will be overridden by the cat class to add more upon the inherited implementation.
    public override void printInfo()
    {
        base.printInfo(); //Calling base implementaion.
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
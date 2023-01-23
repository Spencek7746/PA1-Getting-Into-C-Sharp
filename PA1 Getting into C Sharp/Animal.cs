//Name: Spencer Karpati
//Filename: Animal.cs
//Date: 1/23/2023
//Description: This is the abstract Animal Superclass.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

abstract public class Animal //This is the Animal abstract class. it will serve as a skeleton for its derived classes.
{
    private string Name = "Animal"; //Variables for the name, noise, age, and weight of each animal that will be used in each method inherited.
    private string Noise = "Default";
    private int Age = 0;
    private int Weight = 0;

    public Animal(string name, string noise, int age, int weight) //Animal parameterized constructor which will help creating objects in main.
    {
        Name = name;
        Noise = noise;
        Age = age;
        Weight = weight;
    }

    public virtual void printInfo() //Void function for printing the basic info of an animal. This will be overwritten by the derived classes to add more info. Returns nothing as it's void.
    {
        Console.WriteLine("Name: " + Name);
        Console.Write("Age: " + Age);
        Console.WriteLine(" years.");
        Console.Write("Weight: " + Weight);
        Console.WriteLine(" pounds.");
    }

     public virtual void makeNoise() //Void function to print the noise variable of each animal. This will be overwritten by the derived classes to add more info. Returns nothing as it's void.
     {
         Console.WriteLine(Noise);
     }

     public virtual void ageUp() //Void function to print the age up of each animal. This will be overwritten by the derived classes to add more info. Returns Nothing as it's void.
     {
         Console.WriteLine(Age + 5);
     }
}


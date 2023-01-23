//Name: Spencer Karpati
//Filename: Cat.cs
//Date: 1/23/2023
//Description: This is the Menu Subclass.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

public class Menu
{
    List<Animal> animals = new List<Animal>(); //Creation of a list consisting of Animal objects.

    public void printSubMenu(){
        Console.WriteLine("Please enter a number to continue:");
        Console.WriteLine("1: Show info");
        Console.WriteLine("2: Make noise");
        Console.WriteLine("3: Age up");
    }

    public void printList() //Function to print the list of animals.
    {
        Console.WriteLine("List of added animals:");
        foreach (var animal in animals) //foreach method acquired from https://www.dotnetperls.com/list
        {
            Console.WriteLine(animal.GetType());
        }
    }

    public void getInfo() //Function to get the name, noise, age, and weight of a custom animal the user wants to implement.
    {
        Console.WriteLine("Please enter the name of the animal you want to add:");
        string animalName = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Please enter the noise of the animal:");
        string animalNoise = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Please enter the age:");
        int animalAge = Int32.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Please enter the weight:");
        int animalWeight = Int32.Parse(Console.ReadLine());
        Console.WriteLine();

        animals.Add(new Cat(animalName, animalNoise, animalAge, animalWeight)); //Using user input to create a new animal object.
    }

    public void printMenu() //Function to print menu interface.
    {
        animals.Add(new Cat("Cat", "Meow", 3, 9));
        animals.Add(new Cassowary("Cassowary", "*Horrifying Rumbling Noises*", 27, 98));
        animals.Add(new Austin_Powers("Austin Powers", "YEAHH BAYBEE YEAHH", 64, 172));

        Console.WriteLine("Welcome to Spencer's Animal Emporium. Please enter a number to continue:"); //Creation of user menu.
        Console.WriteLine("1: Add an animal!");
        Console.WriteLine("2: Print list of animals");
        Console.WriteLine("3: Interact with an animal");
        Console.WriteLine("4: Exit program");

        string userChoice = Console.ReadLine(); //Reading user's input for switch menu.
        Console.WriteLine(); //Beginning of sentinel while loop

        while (userChoice != "5") //While user doesn't choose option 5, keep running.
        {
            switch (userChoice)
            {
                case "1": //If user chooses 1, the user will be prompted with 4 questions and their input will be stored to make a new animal object.
                    getInfo();
                    break;

                case "2":
                   printList();
                    break;

                case "3":
                    Console.WriteLine("IN PROGRESS");
                    break;

                case "4":
                    Console.WriteLine("Exiting...");
                    System.Environment.Exit(0); //If 4 is chosen, exit the program.
                    break;

                default: //Condition for if user does not choose a valid option.
                    Console.WriteLine("Please enter a valid number from the choices shown.");
                    break;
            }
            Console.ReadLine(); //Ending of sentinel loop.
        }
    }
}
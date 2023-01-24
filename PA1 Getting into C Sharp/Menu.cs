//Name: Spencer Karpati
//Filename: Menu.cs
//Date: 1/23/2023
//Description: This is the Menu class.

using System;
using System.Collections.Generic;
using System.Diagnostics;
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

    public void refreshMenu()
    {
        Console.WriteLine("Press any key to continue..."); //If the user presses any key after choice, clear console and refresh menu
        ConsoleKeyInfo userKey;
        userKey = Console.ReadKey();
        if (userKey != null)
        {
            Console.Clear(); //Clear console idea gotten from Stack Exchange
            printMenu();
        }
    }

    public void printList() //Function to print the list of animals.
    {
        if (animals.Count == 0)
        {
            Console.WriteLine("Empty! You need to add some animals!");
        }

        else
        {
            foreach (var animal in animals) //foreach method acquired from https://www.dotnetperls.com/list
            {
                Console.WriteLine("List of added animals:");
                Console.WriteLine(animal.ToString());
            }
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
        Console.WriteLine("Welcome to Spencer's Animal Emporium. Please enter a number to continue:"); //Creation of user menu.
        Console.WriteLine("1: Add an animal!");
        Console.WriteLine("2: Print list of animals");
        Console.WriteLine("3: Interact with an animal");
        Console.WriteLine("4: Exit program");

        string userChoice = Console.ReadLine(); //Reading user's input for switch menu.
        Console.WriteLine(); //Beginning of sentinel while loop

        while (userChoice != "4") //While user doesn't choose option 4, keep running.
        {
            switch (userChoice)
            {
                case "1": //If user chooses 1, the user will be prompted with 4 questions and their input will be stored to make a new animal object.
                    getInfo();
                    refreshMenu();
                    break;

                case "2":
                    printList();
                    refreshMenu();
                    break;

                case "3":
                    Console.WriteLine("IN PROGRESS");
                    refreshMenu();
                    break;

                case "4":
                    System.Environment.Exit(0); //If 4 is chosen, exit the program.
                    break;

                default: //Condition for if user does not choose a valid option.
                    Console.WriteLine("Please enter a valid number from the choices shown.");
                    refreshMenu();
                    break;
            }
            Console.ReadLine(); //Ending of sentinel loop.
        }
    }
}
//Name: Spencer Karpati
//Filename: World.cs
//Date: 1/19/2023
//Description: This program helps with learning C# and the concept of abstract and concrete classes.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

class World
{
    List<Animal> animals = new List<Animal>();

    static public void Main(String[] args)
    {
        Cat cat = new Cat("Cat", "Meow", 3, 9);
        Cassowary cassowary = new Cassowary("Cassowary", "*Horrifying Rumbling Noises*", 27, 98);
        Austin_Powers powers = new Austin_Powers("Austin Powers", "YEAHH BAYBEE YEAHH", 64, 172);

        Console.WriteLine();

        Console.WriteLine("Welcome to Spencer's Animal Emporium. Please enter a number to continue:");
        Console.WriteLine("1: Cat");
        Console.WriteLine("2: Cassowary");
        Console.WriteLine("3: Classified...");
        Console.WriteLine("4: Add an animal!");
        Console.WriteLine("5: Exit program");
        string userChoice = Console.ReadLine();

        Console.WriteLine();

        while (userChoice != "5")
        {
            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("Please enter a number to continue:");
                    Console.WriteLine("1: Show info");
                    Console.WriteLine("2: Make noise");
                    Console.WriteLine("3: Age up");
                    string userChoice1 = Console.ReadLine();

                    Console.WriteLine();

                    switch (userChoice1)
                    {
                        case "1":
                            cat.printInfo();
                            Console.WriteLine();
                            break;
                        case "2":
                            cat.makeNoise();
                            Console.WriteLine();   
                            break;
                        case "3":
                            cat.ageUp();
                            Console.WriteLine();
                            break;
                        default:
                            Console.WriteLine("Please enter a valid number from the choices shown.");
                            Console.WriteLine();
                            break;
                    }
                    break;

                case "2":
                    Console.WriteLine("Please enter a number to continue:");
                    Console.WriteLine("1: Show info");
                    Console.WriteLine("2: Make noise");
                    Console.WriteLine("3: Age up");
                    string userChoice2 = Console.ReadLine();

                    Console.WriteLine();

                    switch (userChoice2)
                    {
                        case "1":
                            cassowary.printInfo();
                            Console.WriteLine();
                            break;
                        case "2":
                            cassowary.makeNoise();
                            Console.WriteLine();
                            break;
                        case "3":
                            cassowary.ageUp();
                            Console.WriteLine();
                            break;
                        default:
                            Console.WriteLine("Please enter a valid number from the choices shown.");
                            Console.WriteLine();
                            break;
                    }
                    break;

                case "3":
                    Console.WriteLine("Please enter a number to continue:");
                    Console.WriteLine("1: Show info");
                    Console.WriteLine("2: Make noise");
                    Console.WriteLine("3: Age up");
                    string userChoice3 = Console.ReadLine();

                    Console.WriteLine();

                    switch (userChoice3)
                    {
                        case "1":
                            powers.printInfo();
                            Console.WriteLine();
                            break;
                        case "2":
                            powers.makeNoise();
                            Console.WriteLine();
                            break;
                        case "3":
                            powers.ageUp();
                            Console.WriteLine();
                            break;
                        default:
                            Console.WriteLine("Please enter a valid number from the choices shown.");
                            Console.WriteLine();
                            break;
                    }
                    break;

                case "4":
                    Console.WriteLine("Please enter the name of the animal you want to add:");
                    string animalName = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("Please enter the noise of the animal:");
                    string animalNoise = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("Please enter the age:");
                    int animalAge = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine();

                    Console.WriteLine("Please enter the weight:");
                    int animalWeight = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine();

                    animals.Add(new Animal(animalName, animalNoise, animalAge, animalWeight));
                    foreach(Animal a in animals)
                    {
                        Console.WriteLine(a.ToString());
                    }
                    break;

                case "5":
                    Console.WriteLine("Exiting...");
                    System.Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Please enter a valid number from the choices shown.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
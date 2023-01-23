//Name: Spencer Karpati
//Filename: World.cs
//Date: 1/23/2023
//Description: This program helps with learning C# and the concept of abstract and concrete classes.

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

class World
{
    static public void Main(String[] args) // Main driver
    {
        World world = new World();
        Menu menu = new Menu();

        menu.printMenu();

        Console.WriteLine();
    }
}
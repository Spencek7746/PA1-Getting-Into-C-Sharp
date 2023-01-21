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
using BaseClass;

public class Cat : Animal
{
    public override void printInfo()
    {
        Console.WriteLine("Likes: Catnip, Acting like an absolute buffoon when you are trying to sleep");
    }

    public override void makeNoise()
    {
        Console.WriteLine("Purrrrrrr");
    }

    public override void ageUp()
    {
        Console.WriteLine("The cat has gotten older.");
    }
}
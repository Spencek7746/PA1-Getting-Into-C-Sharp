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

public class Cat : Animal
{
    public override void printInfo()
    {
        name = "Aya";
        age = 4;
        weight = 9;
    }

    public override void makeNoise()
    {
        noise = "meow";
    }

    public override int ageUp()
    {
        throw new NotImplementedException();
    }
}
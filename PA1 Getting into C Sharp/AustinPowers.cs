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
using BaseClass;

public class Austin_Powers : Animal
{
    public override void printInfo()
    {
        Console.WriteLine("Alias: International Man of Mystery");
        Console.WriteLine("Vehicle: ShagMobile");
    }
    public override void makeNoise()
    {
        Console.WriteLine("Shagadelic");
    }

    public override void ageUp()
    {
        Console.WriteLine("I still have my mojo baybee");
    }
}
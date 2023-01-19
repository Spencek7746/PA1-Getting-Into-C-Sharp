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

public class Austin_Powers : Animal
{
    public override void printInfo()
    {
        name = "Austin Powers";
        age = 42;
        weight = 156;
    }

    public override void makeNoise()
    {
        noise = "YEAHHH BAYBEE YEAHHH";
    }

    public override int ageUp()
    {
        throw new NotImplementedException();
    }
}
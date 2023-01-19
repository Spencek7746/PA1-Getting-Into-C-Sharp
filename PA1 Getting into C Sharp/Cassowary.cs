//Name: Spencer Karpati
//Filename: Cassowary.cs
//Date: 1/19/2023
//Description: This is the Cassowary Subclass.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

public class Cassowary : Animal
{
    public override void printInfo()
    {
        name = "Devil Bird";
        age = 24;
        weight = 97;
    }

    public override void makeNoise()
    {
        noise = "*Horrifying Growling/Rumbling Sounds*";
    }

    public override int ageUp()
    {
        throw new NotImplementedException();
    }
}
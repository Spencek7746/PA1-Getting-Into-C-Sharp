PA1: Getting into C# README

This program helps with understanding inheritence in C#.

INSTALLATION, COMPILATION, AND USE: 
Unpack the files to any directory of your choice (unless you are using an IDE). You can compile on an IDE of your choice but running on a Linux or Windows terminal 
might be simpler.

Visual Studio(Preferred IDE) -> Extract the the contents into c:/Users/*user*/source/repos. Open Visual Studio and on the top left, click *open file*.
Find the path into repos and click on the extracted folder and click *open*. It should show the file contents on the Solution Explorer tab located on the
left. To compile and run the code, There will be a green play arrow located below the *Tools* and *Extensions*. Click the down arrow to see build options.
Pick *PA1 Getting into C Sharp.csproj* and click the green arrow. If everything was done correctly, the program shuld run.

Linux(Preferred) or Windows Terminal: -> Extract the folder to any directory of your choice. Open a Linux(ctrl+alt+t) or Windows(winkey+r, cmd) command prompt.
Use command ```cd``` to change into the folder directory. You can compile the project as follows:

```csc Animal.cs Cat.cs Cassowary.cs AustinPowers.cs Menu .cs World.cs```

You should now have a .exe file. Use command ```ls``` to view the executable name. To run it, simple type *executablename.exe* to run the file.

You should see a menu, just read the instructions and simply type a number for the submenu or option you want to access. For option 1, you will be instructed 
to provide a name, noise, age, and weight. This is neccessary to create your animal and document it.

DESIGN CHOICES:
The Animal class is abstract so it can be used as a preset for all of the classes that inherit it's methods and variables. This makes it a lot easier to implement 
the derived classes since the methods they inherit are implemented(mostly, still needs to be overwritten) already. This also gives all classes within the program
a neat uniform implementation between all of them. The methods of the Animal class are declared ```virtual``` so that they can have a declared body. This way, I can 
already add the most basic implemention to these methods and override them in the derived classes to add even more while still having the base implmentation. I also 
added a Animal parameterized constructor to set public parameters to my private Animal variables. This helps with creating any other derived class object in main as 
well as making a custom derived class object for the user. The menu interface has been completely implemented as its own ```Menu``` class. I did this because I wanted
main to be as clean as possible as well as to be able to use functions to print different menu sets. I have used switches for my menu as I believe they are very simple
and straight forward for the user and are easy to understand when reading the code.


Spencer Karpati - University of Tennessee at Martin - CSCI352
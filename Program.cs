using System;

Console.Write("How many motors are carrying the packages? ");
int motors = int.Parse(Console.ReadLine());

Console.Write("How many kg of packages do we expect? ");
double weight = double.Parse(Console.ReadLine());

Console.WriteLine(weight / motors <= 5.6 ? 
    "Yes! The conveyor belt can carry the packages." : 
    "No. The conveyor belt cannot carry the packages.");

using System;

class SparePartsInventoryAssistant
{
    static void Main()
    {
        Console.WriteLine("Hej. Welcome to the spare parts inventory!");
        Console.Write("Which part do you need? ");
        string input = Console.ReadLine();

        if (input == "hydraulic pump")
        {
            Console.WriteLine("I've got hydraulic pump here for you 😊");
        }
        else if (input == "PLC module")
        {
            Console.WriteLine("I've got PLC module here for you 😊");
        }
        else if (input == "servo motor")
        {
            Console.WriteLine("I've got servo motor here for you 😊");
        }
        else if (input == "Do you actually have any parts?" ||
                input == "Is there anything in stock at all?")
        {
            Console.WriteLine("We have 3 part(s)!");
            Console.WriteLine("hydraulic pump");
            Console.WriteLine("PLC module");
            Console.WriteLine("servo motor");
        }
        else
        {
            Console.WriteLine($"I am afraid we don't have any {input} in the inventory 😔");
        }
    }
}

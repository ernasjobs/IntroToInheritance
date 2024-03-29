﻿using System;

namespace IntroToInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
           Car car1=new Car("BMW","7-Series",false);
           MotorCycle motorBike1=new MotorCycle("Zongshen","Dakota",false);
           car1.getStats();
           car1.GetExtra();
           motorBike1.getStats();
           motorBike1.getExtra();
           Console.WriteLine();
           Console.WriteLine();
           Console.WriteLine();
            // Create an instance of WorkItem by using the constructor in the 
            // base class that takes three arguments.
            WorkItem item = new WorkItem("Fix Bugs",
                                        "Fix all bugs in my code branch",
                                        new TimeSpan(3, 4, 0, 0));

            // Create an instance of ChangeRequest by using the constructor in
            // the derived class that takes four arguments.
            ChangeRequest change = new ChangeRequest("Change Base Class Design",
                                                    "Add members to the class",
                                                    new TimeSpan(4, 0, 0),
                                                    1);

            // Use the ToString method defined in WorkItem.
            Console.WriteLine(item.ToString());

            // Use the inherited Update method to change the title of the 
            // ChangeRequest object.
            change.Update("Change the Design of the Base Class",
                new TimeSpan(4, 0, 0));

            // ChangeRequest inherits WorkItem's override of ToString.
            Console.WriteLine(change.ToString());

            // Keep the console open in debug mode.
            Console.WriteLine("Press any key to exit.");
           Console.ReadKey(true);
        }
    }
}

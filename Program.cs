using System;

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

           Console.ReadKey(true);
        }
    }
}

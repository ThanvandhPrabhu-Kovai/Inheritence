using System;

namespace Inheritance
{

    class Vehicle
    {
        public void start(string vehicleType)
        {
            Console.Write("\n\n{0} started...", vehicleType);
        }

        public void shiftGear(int gearNo)
        {
            if (gearNo > 0 && gearNo <= 6)
            {
                Console.Write("\n\nShifted to gear - {0}", gearNo);
            }
            else
            {
                Console.Write("\n\nInvalid gear");
            }
        }

        public virtual void go(int speed)
        {
            Console.Write("\n\nMoving...at {0} kmph", speed);
        }

    }

    class Bike : Vehicle
    {
        public Bike()
        {
            start("\n\nMotorbike");
        }

        public override void go(int speed)
        {
            Console.Write("\n\nBike Riding...at {0} kmph", speed);
        }

        public void stopTheBike()
        {
            Console.Write("\n\nBike Ride ended!");
        }
    }


    class Car : Vehicle
    {
        public Car()
        {
            start("Car");
        }

        public void stopTheCar()
        {
            Console.Write("\n\nCar stopped");
        }

        public override void go(int speed)
        {
            Console.Write("\n\nCar is currently Cruising at {0} kmph", speed);
        }

        private void triggerHandbreak()
        {
            Console.Write("\n\nHandbreak triggered!");
        }

        ~Car()
        {
            triggerHandbreak();
        }

    }

    class Program
    {

        static void Main(string[] args)
        {
            Bike bike = new Bike();
            bike.shiftGear(1);
            bike.go(20);
            bike.stopTheBike();

            Car car = new Car();
            car.shiftGear(2);
            car.go(35);
            car.stopTheCar();

            Console.ReadLine();
        }
    }
}

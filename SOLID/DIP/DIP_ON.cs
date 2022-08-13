using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    internal class DIP_ON
    {
        public interface IVehicle
        {
            public void SpeedUp();
            public void SlowDown();
            public void TurnRight();
            public void TurnLeft();
        }
        public class Car:IVehicle
        {
            public void SpeedUp()
            {
                Console.WriteLine("the car is accelerating");
            }
            public void SlowDown()
            {
                Console.WriteLine("the car is slowing down");
            }

            public void TurnRight()
            {
                Console.WriteLine("Car turns right");
            }
            public void TurnLeft()
            {
                Console.WriteLine("Car turns left");
            }
        }
        public class Bus : IVehicle
        {
            public void SpeedUp()
            {
                Console.WriteLine("the bus is accelerating");
            }
            public void SlowDown()
            {
                Console.WriteLine("the bus is slowing down");
            }

            public void TurnRight()
            {
                Console.WriteLine("bus turns right");
            }
            public void TurnLeft()
            {
                Console.WriteLine("bus turns left");
            }
        }
        public class Vehicle
        {
            private IVehicle vehicle;

            public Vehicle(IVehicle vehicle)
            {
                this.vehicle = vehicle;
            }

            void UseVehicle()
            {
                vehicle.SpeedUp();
                vehicle.SlowDown();
                vehicle.TurnLeft();
                vehicle.TurnRight();
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    internal class DIP_OFF
    { 
        //Sorun: Vehicle class'ında Car nesnesinden instance alındığı için başka bir zamanda Car yerine Bus kullanmam gerektiğinde Vehicle class'ındaki her şeyi yeniden düzenlemem gerekecek.
        public class Car
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
        public class Vehicle
        {
            private Car car;

            public Vehicle()
            {
                car = new Car(); 
            }

            void UseVehicle()
            {
                car.SpeedUp();
                car.SlowDown();
                car.TurnLeft();
                car.TurnRight();
            }

        }
    }
}

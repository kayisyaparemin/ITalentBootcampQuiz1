using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAI
{
    internal class Polymorphisim
    {
        public abstract class Animal
        {
            public string Name { get; set; }

            public abstract void MakeVoice();
        }

        public class Cat : Animal
        {
            public override void MakeVoice()
            {
                Console.WriteLine("Cat says meow meow");
            }
        }
        public class Dog : Animal
        {
            public override void MakeVoice()
            {
                Console.WriteLine("Dog says houf houf");
            }
        }
    }
}

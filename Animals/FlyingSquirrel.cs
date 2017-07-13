using System;

namespace Zoolandia.Animals
{
    public class FlyingSquirrel : Animal, IAmbulatory, IFlying, ISense
    {
        public double airSpeed { get; set; }

        public double groundSpeed { get; set; }

        public void fly()
        {
            Console.WriteLine($"{this.name} jumps out of a tree and glides at {this.airSpeed} m/s.");
        }

        public override void move()
        {
            Console.WriteLine("I am an Animal too, and I move by flying!");
        }

        public void walk()
        {
            Console.WriteLine($"{this.name} bounds along the ground at {this.groundSpeed} m/s.");
        }
        public void see()
        {
            Console.WriteLine($"The {this.name} uses it's fingers to sense it's suroundings.");
        }
        public string hear()
        {
           return "Flying squirrels cannot hear anything, they sense through vibrations in the air.";
        }
        public string smell()
        {
            return "Flying squirrels do not like the smell of cucumbers.";
        }
        public virtual void taste()
        {
            Console.WriteLine("Flying squirrels taste good");
        }
    }
}
using System;

namespace Zoolandia.Animals
{
    public class Mantis : Animal, IAmbulatory
    {
        public double groundSpeed
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void walk()
        {
            throw new NotImplementedException();
        }





         public override void move()
        {
            Console.WriteLine("I am an Animal too, and I move by walking!");
        }
    }
}

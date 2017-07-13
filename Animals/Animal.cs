using System;

namespace Zoolandia.Animals
{
    public class Animal : IAnimal
    {
        private string _name = "";
        private string _food = null;
        public Species species {get; set;}

        public string name
    {
      get
      {
        return _name;
      }
      set
      {
        if (value != "")
        {
            _name = value;
        }
        
      }
    }

    public string food
    {
      get
      {
        return _food;
      }
      set
      {
        if (value != "")
        {
          _food = value;
        }
      }
    }

    public void eat()
    {
        if (_food == null)
        {
            Console.WriteLine("No food provided yet");
        }
    }

    public virtual void eat(string food)
    {
        _food = food;
        Console.WriteLine("Currently eating {0}", food);
    }

    public virtual void sleep()
    {
        throw new NotImplementedException();
    }

    public virtual void move()
    {
        Console.WriteLine("I am an Animal! I move :)");
    }

    public virtual void reproduce()
    {
        throw new NotImplementedException();
    }

    }
}
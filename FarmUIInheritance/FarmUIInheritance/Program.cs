using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmUIInheritance
{
    public class Animal
    {
        public string Name { get; set; }
        public int LimbCount { get; set; }
        public string Colour { get; set; }

        public Animal(): this("anon", 4, "muddy")
        {

        }

        public Animal(string name, int limbCount, string colour)
        {
            Name = name;
            LimbCount = limbCount;
            Colour = colour;
        }

        public string Eat(string food)
        {
            return string.Format("I'm a {0} animal called {1} using some of my {2} limbs to eat {3}", Colour, Name, LimbCount, food);
        }

        public string Move(string direction)
        {
            return Move("North", 1);
        }

        public string Move(string direction, int distance)
        {
            return string.Format("I'm a {0} animal using some of my {2} limbs to move {3} for {4} meters", Colour, Name, LimbCount, distance);
        }
        static void Main(string[] args)
        {
        }
    }
}

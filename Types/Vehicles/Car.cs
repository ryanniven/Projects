using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
        public class Car
    {
        private string make;
        private string colour;

        //constructors have no return type
        public Car():this("Mercedes", "C Class", "Black", 0)
        {
          
        }
        public Car(string make, string model, string colour, int speed)
        {
            this.Make = make;
            this.Model = model;
            this.colour = colour;
            this.speed = speed;
        }

        public void Accelerate(int pressureOnPedal)
        {
            speed += pressureOnPedal;
        }

        private int speed;

        //java approach
        //public int GetSpeed()
        //{
        //    return speed;
        //}

        //public void SetSpeed(int value)
        //{
        //    if(value < 0 | value > 70)
        //    {
        //        throw new Exception("illegal Speed!");
        //    }
        //    speed = value;
        //}

            //C# approach
        public int Speed
        {
            get { return speed; }
            set
            {
                if (value < 0 | value > 70)
                {
                    throw new Exception("illegal speed!");
                }
                        speed = value;
            }

        }
        //publicly accessible getters with private setters 

        public string Model{get;  private set;}

        public string Make{ get; private set; }

        //getter with a setter based on a calulated value
        public int SpeedInkph
        {
            get
            {
                return (int)(speed * 1.609);
            }
        }
    }
}

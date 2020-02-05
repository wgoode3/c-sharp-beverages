using System;

namespace Beverages
{
    public abstract class Drink
    {
        public string color { get; set; }
        public double volume { get; set; }
        public int temperature { get; set; }
        public bool isCarbonated { get; set; }

        /// <summary>
        /// Drinks are often newtonian liquids!
        /// </summary>
        public Drink (string color, double volume, int temperature, bool isCarbonated)
        {
            this.color = color;
            this.volume = volume;
            this.temperature = temperature;
            this.isCarbonated = isCarbonated;
        }

        public virtual void Consume ()
        {
            Console.WriteLine ("DEFAULT DRINKING NOISES");
        }
    }
}
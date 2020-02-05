using System;

namespace Beverages
{
    public class Coffee : Drink {
        public bool isCaffeinated {get;set;}
        public string beans {get;set;}
        /// <summary>
        /// Coffee shall not be carbonated (nitro is ok)
        /// </summary>
        public Coffee (string color, double volume, int temperature, bool isCaffeinated, string beans) : base (color, volume, temperature, false) { 
            this.isCaffeinated = isCaffeinated;
            this.beans = beans;
        }

        public override void Consume ()
        {
            if (temperature < 50)
            {
                Console.WriteLine ("Glug glug...");
            }
            else
            {
                Console.WriteLine ("Sip sip...");
            }
        }
    }
}
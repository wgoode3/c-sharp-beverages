using System;

namespace Beverages
{
    public class Water : Drink
    {
        /// <summary>
        /// Water is necessary for life, as we know it!
        /// Water is always clear.
        /// </summary>
        public Water (double volume, int temperature, bool isCarbonated) : base ("clear", volume, temperature, isCarbonated) { }

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
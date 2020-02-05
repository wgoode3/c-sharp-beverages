using System;

namespace Beverages
{
    public class Wine : Drink, IAlcoholic
    {
        public int year { get; set; }
        public string variety { get; set; }
        public string region { get; set; }
        public double abv { get; set; }

        public Wine (string color, double volume, int temperature, bool isCarbonated, int year, string variety, string region, double abv) : base (color, volume, temperature, isCarbonated)
        {
            this.year = year;
            this.variety = variety;
            this.region = region;
            this.abv = abv;
        }

        public override void Consume ()
        {
            Console.WriteLine ("Sip sip...");
        }
    }
}
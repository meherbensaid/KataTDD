using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental
{
    public class RegularMovie:Movie
    {
        public RegularMovie(string title):base(title)
        {
            
        }

        public override double Amount(int daysRented)
        {
            var amount = (Double) 0;
            amount += 2;
            if (daysRented > 2)
                amount += (daysRented - 2) * 1.5;
            return amount;
        }
    }
}

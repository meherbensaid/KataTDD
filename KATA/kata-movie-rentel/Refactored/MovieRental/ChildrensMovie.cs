using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental
{
    public class ChildrensMovie:Movie
    {
        public ChildrensMovie(string title) : base(title)
        {
        }

        public override double Amount(int daysRented)
        {
            var amount = (Double) 0;
            amount += 1.5;
            if (daysRented > 3)
                amount += (daysRented - 3) * 1.5;
            return amount;
        }
    }
}

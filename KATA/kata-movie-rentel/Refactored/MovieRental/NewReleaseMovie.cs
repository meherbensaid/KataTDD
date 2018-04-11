using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental
{
    public class NewReleaseMovie:Movie
    {
        public NewReleaseMovie(string title) : base(title)
        {
        }

        public override double Amount(int daysRented)
        {
            var amount = (Double) 0;
            amount += daysRented * 3;
            return amount;
        }
    }
}

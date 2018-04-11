namespace MovieRental
{
    using System;
    using System.Collections.Generic;

    public class Customer
    {
        public string Name { get; set; }
        public List<Rental> Rentals = new List<Rental>();

        public Customer(string name)
        {
            this.Name = name;
        }

        public void AddRental(Rental rental)
        {
            Rentals.Add(rental);
        }

        public string Statement()
        {
            var result = "Rental Record for " + this.Name + "\n";
            var totalAmount = (Double)0;
            var frequentRenterPoints = 0;
          
            foreach (var each in Rentals)
            {
                totalAmount += each.Amount();

                frequentRenterPoints+=each.GetFrequentRenterPoints();
                result += "\t" + each.Movie.Title + "\t" +
                          each.Amount()+ "\n";
              
            }

            result += "Amount owed is " + totalAmount.ToString() + "\n";
            result += "You earned " + frequentRenterPoints.ToString() +
                    " frequent renter points";

            return result;
        }

     
    }
}

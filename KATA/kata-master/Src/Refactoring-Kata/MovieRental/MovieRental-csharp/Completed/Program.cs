﻿using System;

namespace MovieRental_csharp.Completed
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie("Transformer", Movie.REGULAR);
		
		    Rental rental = new Rental(movie, 3);
		
		    Customer customer = new Customer("Saobane");
		    customer.AddRental(rental);
            customer.AddRental(new Rental(new Movie("NEMO", Movie.NEW_RELEASE), 5));


            String statement = customer.Statement();
            System.Console.WriteLine(statement);
            Console.ReadLine();
        }
    }
}

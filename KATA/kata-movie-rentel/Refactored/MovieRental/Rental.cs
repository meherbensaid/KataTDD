using System;

namespace MovieRental
{
    public class Rental
    {
        public Movie Movie { get; set; }
        public int DaysRented { get; set; }

        public Rental(Movie movie, int daysRented)
        {
            Movie = movie;
            DaysRented = daysRented;
        }

        public int GetFrequentRenterPoints()
        {
            if ((this.Movie is NewReleaseMovie) && (this.DaysRented > 1)) return 2;
            return 1;
        }

        //public  double Amount()
        //{
        //    var result = (Double)0;
        //    switch (Movie.PriceCode)
        //    {
        //        case Movie.REGULAR:
        //            result = RegularMovieAmount(this, result);
        //            break;
        //        case Movie.NEW_RELEASE:
        //            result = ReleaseFilmAmount(this, result);
        //            break;
        //        case Movie.CHILDRENS:
        //            result = ChildensFilmAmount(this, result);
        //            break;
        //    }

        //    return result;
        //}

        //private  double ChildensFilmAmount(Rental each, double thisAmount)
        //{
        //    thisAmount += 1.5;
        //    if (each.DaysRented > 3)
        //        thisAmount += (each.DaysRented - 3) * 1.5;
        //    return thisAmount;
        //}

        //private  double ReleaseFilmAmount(Rental each, double thisAmount)
        //{
        //    thisAmount += each.DaysRented * 3;
        //    return thisAmount;
        //}

        //private double RegularMovieAmount(Rental each, double thisAmount)
        //{
        //    thisAmount += 2;
        //    if (each.DaysRented > 2)
        //        thisAmount += (each.DaysRented - 2) * 1.5;
        //    return thisAmount;

        //}



    }
}

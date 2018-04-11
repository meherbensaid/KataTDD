namespace MovieRental
{
    public abstract class Movie {
	   
	
        public string Title { get; set; }
      
	
	    protected Movie(string title){
		    this.Title = title;
	    }

         public abstract double Amount(int DaysRented);

    }
}

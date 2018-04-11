namespace MovieRental
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestStatement()
        {
            Movie movie = new RegularMovie("Transformer");

            Rental rental = new Rental(movie, 3);

            Customer customer = new Customer("jpartogi");
            customer.AddRental(rental);

            String statement = customer.Statement();
            StringAssert.Contains(statement, "Transformer");
        }

        [TestMethod]
        public void Should_Return_Statement_For_New_Release_Film_Rentel()
        {
            var movie=new NewReleaseMovie("PirateDesCaraibe");

            var rental=new Rental(movie,3);

            var customer=new Customer("Maher");
            customer.AddRental(rental);

            //var expected = "Rental Record for Maher\n" +
            //               "\tPirateDesCaraibe\t9\n"+
            //               "Amount owed is 9\n" +
            //               "You earned 2 frequent renter points";

            var expected = "Rental Record for Maher\n\tPirateDesCaraibe\t9\nAmount owed is 9\nYou earned 2 frequent renter points";

            var actualStaement = customer.Statement();

            Assert.AreEqual(expected, actualStaement);
        }

        [TestMethod]
        public void Should_Return_Statement_For_REGULAR_Film_Rentel()
        {
            var movie = new RegularMovie("PirateDesCaraibe");

            var rental = new Rental(movie, 3);

            var customer = new Customer("Maher");
            customer.AddRental(rental);

            //var expected = "Rental Record for Maher\n" +
            //               "\tPirateDesCaraibe\t9\n"+
            //               "Amount owed is 9\n" +
            //               "You earned 2 frequent renter points";

            var expected = "Rental Record for Maher\n\tPirateDesCaraibe\t3,5\nAmount owed is 3,5\nYou earned 1 frequent renter points";

            var actualStaement = customer.Statement();

            Assert.AreEqual(expected, actualStaement);
        }
    }
}

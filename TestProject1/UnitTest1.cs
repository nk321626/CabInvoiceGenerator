using NUnit.Framework;
using CabInvoiceGenerator;

namespace NUnitTestProject1
{
    public class Tests
    {
        InvoiceGenerator invoiceGenerator = null;

        [Test]
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {
            //Creating Instance of Invoice Generator  For Normal Ride
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = 10.0;
            int time = 3;

            //Calculating Fare
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 103;

            //Asserting Values
            Assert.AreEqual(expected, fare);
        }
    }
}
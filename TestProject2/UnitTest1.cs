using CabInvoiceGenerator;

namespace TestProject2
{
    public class Tests
    {
        InvoiceGenerator invoiceGenerator = null;

        [Test]
        //checking calculate fare function for multiple ride invoice summary (Step 2)
        public void GivenMultipleRidesShouldReturnInvoiceSummary()
        {
            //Creating Instance of Invoice Generator  For Normal Ride
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };

            //Generating Summary for Rides
            InvoiceSummary invoiceSummary = invoiceGenerator.CalculateFare(rides);
            InvoiceSummary expectedSummary = new InvoiceSummary(2, 30.0);

            //Asserting Values
            Assert.AreEqual(expectedSummary, invoiceSummary);

        }
    }
}
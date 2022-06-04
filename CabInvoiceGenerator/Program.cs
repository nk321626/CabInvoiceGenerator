// See https://aka.ms/new-console-template for more information

using CabInvoiceGenerator;

Console.WriteLine("Welcome to Cab Invoice Generator"); //Welcome message.
InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);//Write the Type of Ride.
double fare = invoiceGenerator.CalculateFare(10.0, 3);//Write Distance, Time.
Console.WriteLine($"Fare : {fare}");
Console.ReadLine();
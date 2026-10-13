
/*
*Name: Howard Lee Cummings III
*Course: CSCI 1250, Section 001
*Assignment: Lab 04, The Group Trip
*Date: October 13, 2026
*Description: Rebuilds the trip calculator with methods and arrays so it reports on a whole group instead of one person
*/



//questions//

Console.Write("Round trip miles: ");
int roundTripMiles = Convert.ToInt32(Console.ReadLine());


Console.Write("Miles per gallon: ");
double milesPerGallon = Convert.ToDouble(Console.ReadLine());


Console.Write("Price per gallon: ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("How many pizzas: ");
int totalPizzas = Convert.ToInt32(Console.ReadLine());

Console.Write("Price per pizza: ");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());

//Part 1 print//

double fuelCost = FuelCost(roundTripMiles, milesPerGallon, pricePerGallon);

double pizzaCost = totalPizzas * pricePerPizza;

double tripTotal = fuelCost + pizzaCost;

Console.WriteLine();
Console.WriteLine("=== Part 1: The Trip ===");
Console.WriteLine("Fuel Cost: " + fuelCost.ToString("C"));
Console.WriteLine("Pizza cost: " + pizzaCost.ToString("C"));
Console.WriteLine("Trip total: " + tripTotal.ToString("C"));

//Arrays//
string[] names = { "Ada", "Grace", "Alan", "Katherine" };
double[] hoursWorked = { 22, 15, 30, 18 };
double[] hourlyRates = { 13.50, 16.00, 11.20, 14.80};


//Part 2//

const int SlicesPerPizza = 8;
const double TaxRate = 0.18;
int peopleGoing = names.Length;
double slicesEach = totalPizzas * SlicesPerPizza / (double)names.Length;
double costPerPerson = tripTotal / peopleGoing;



Console.WriteLine();
Console.WriteLine("=== Part 2: The Group ===");
Console.WriteLine("People Going " + names.Length);
Console.WriteLine("Slices each " + slicesEach.ToString("F1"));
Console.WriteLine("Cost per person " + costPerPerson.ToString("C"));



//part 3


Console.WriteLine();
Console.WriteLine("=== Part 3: Who Works How Long ===");

double totalHours = 0;
double totalTakeHome = 0;
double longest = 0;

for (int i = 0; i < names.Length; i++)
{
    double takeHomePay = TakeHomePay(hoursWorked[i], hourlyRates[i], TaxRate);
    double takeHomePerHour = takeHomePay / hoursWorked[i];
    double hoursNeeded = HoursToCover(costPerPerson, takeHomePerHour);

    Console.WriteLine(names[i] + ": takes home " + takeHomePay.ToString("C") + " for " + hoursWorked[i].ToString("F0") + " hours " + takeHomePerHour.ToString("C") + " per hour, must work " + hoursNeeded.ToString("F2") + " hours");


    totalHours += hoursWorked[i];
    totalTakeHome += takeHomePay;
    longest = Math.Max(longest, hoursNeeded);


}

Console.WriteLine();
Console.WriteLine("Total hours worked: " + totalHours.ToString("F0"));
Console.WriteLine("Total take home pay: " + totalTakeHome.ToString("C"));
Console.WriteLine("Longest anyone must work: " + longest.ToString("F2"));









//methods//


//FuelCost finds out the total cost of gas for the trip//

static double FuelCost(double miles, double milesPerGallon, double pricePerGallon)
{
    double gallons = miles / milesPerGallon;
    return gallons * pricePerGallon;

}

//TakeHomePay finds out how much someone earns after taxes//

static double TakeHomePay(double hours, double hourlyRate, double taxRate)
{
    double grossPay = hours * hourlyRate;
    double taxWithheld = grossPay * TaxRate;
    return grossPay - taxWithheld;
}

//HourstoCover finds out how many hours someone has to work to pay for their part of the trip

static double HoursToCover(double amountOwed, double takeHomePerHour)
{
    return amountOwed / takeHomePerHour;
}


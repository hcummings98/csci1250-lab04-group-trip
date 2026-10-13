
/*
*Name: Howard Lee Cummings III
*Course: CSCI 1250, Section 001
*Assingment: Lab 04, Group Trip
*Date: OCtober 13, 2026
*Description: Calculates the fuel, food, and work hours behind one road trip
*/



//questions//

Console.WriteLine("== Part 1: Road Trip ==");
Console.WriteLine("How many Round Trip Miles?");
int roundTripMiles = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("How Many Miles Per Gallons");
double milesPerGallon = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("What is the Price Per Gallon?");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("How many pizzas?");
int totalPizzas = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Price per pizza?");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());

//Part 1 print//

double fuelCost = FuelCost(roundTripMiles, milesPerGallon, pricePerGallon);

double pizzaCost = totalPizzas * pricePerPizza;

double tripTotal = fuelCost + pizzaCost;

Console.WriteLine("=== Part 1: The Trip ===");
Console.WriteLine("Fuel Cost:" + fuelCost.ToString("C"));
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

int totalSlices = totalPizzas * 8;
int slicesPerPerson = totalSlices / peopleGoing;


Console.WriteLine("=== Part 2: The Group ===");
Console.WriteLine("People Going " + names.Length);
Console.WriteLine("Slices each " + slicesEach.ToString("F1"));
Console.WriteLine("Cost per person " + costPerPerson.ToString("C"));



//part 3



Console.WriteLine("== Part 3: Paycheck ==");








//methods//

static double FuelCost(double miles, double milesPerGallon, double pricePerGallon)
{
    double gallons = miles / milesPerGallon;
    return gallons * pricePerGallon;

}

static double TakeHomePay(double hours, double hourlyRate, double taxRate)
{
    double grossPay = hours * hourlyRate;
    double taxWithheld = grossPay * taxRate;
    return grossPay - taxWithheld;
}

static double HoursToCover(double amountOwed, double takeHomePerHour)
{
    return amountOwed / takeHomePerHour;
}


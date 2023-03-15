using Business;
using Business.Structures;

Currency usd = new Currency("USD", '$');


Product product = new Product("Table", 13.50f, usd);

var tableWarehouse = new Warehouse("Table", "cm", 2, DateTime.Now, 13.50f, usd);
var closetWarehouse = new Warehouse("Closet", "m", 5, DateTime.Now, 70.25f, usd);
var warehouseList = new List<Warehouse>() { tableWarehouse, closetWarehouse };

Reporting reporting = new Reporting(warehouseList);

var inventoryReport = reporting.GetInventory();
var profitReport = reporting.GetProfits();
var submissionReport = reporting.GetSubmissions();


Console.WriteLine("\nInventory Report: ");
foreach (var item in inventoryReport)
{
    Console.WriteLine($"{item.Name}, {item.Quantity} pieces, {item.Unit}");
}

Console.WriteLine("\nProfit Report: ");
foreach (var item in profitReport)
{
    Console.WriteLine($"{item.Name}, {item.Quantity} pieces, Price: {item.Price}, Amount: {item.ProfitAmount}");
}

Console.WriteLine("\nAdmission Submission: ");
foreach (var item in submissionReport)
{
    Console.WriteLine($"{item.Name}, {item.Quantity} pieces, {item.Unit}, Date: {item.Date.ToShortDateString()}");
}

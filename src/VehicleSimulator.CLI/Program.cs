/* ******************** 
* TRIP LOG DEMO
********************* */
Console.WriteLine("--------------------------------");
Console.WriteLine("--- BEGIN TRIP LOG DEMO ---");
Console.WriteLine("--------------------------------");

TripLog tripLog = new TripLog(2);
tripLog.Record(new Position(0, 0));
tripLog.Record(new Position(1, 1));

// Print the trip log entries
Console.WriteLine(tripLog.GetPrintedEntries());
Console.WriteLine();

/* ******************** 
* VEHICLE DRIVE DEMO
********************* */
Console.WriteLine("--------------------------------");
Console.WriteLine("--- BEGIN VEHICLE DRIVE DEMO ---");
Console.WriteLine("--------------------------------");

// Create the vehicle at point (0, 0) with a fuel consumption of 0.1 units per unit distance
// Log precision has been left to the default value of 2 decimal places.
var vehicle = new Vehicle(
    initialPosition: new Position(0, 0),
    maxFuelLevel: 100,
    initialFuelLevel: 100,
    fuelConsumptionPerUnitDistance: 0.1
);
Console.WriteLine(vehicle.GetPrintedStatus());
Console.WriteLine();

// Turn on and drive in one direction for given distance
vehicle.Drive(100, 100);
Console.WriteLine(vehicle.GetPrintedStatus());
Console.WriteLine();

// Drive in another direction for given distance (simulates a turn)
vehicle.Drive(200, 0);
Console.WriteLine(vehicle.GetPrintedStatus());
Console.WriteLine();

// Drive in another direction for given distance (simulates a turn)
// Will run out of fuel
vehicle.Drive(0, 900);
Console.WriteLine(vehicle.GetPrintedStatus());
Console.WriteLine();

// Add some fuel
// Drive in another direction for given distance
vehicle.Refuel(100);
vehicle.Drive(100, 0);
Console.WriteLine(vehicle.GetPrintedStatus());
Console.WriteLine();

// Print the trip stats
Console.WriteLine($"Total Distance: {vehicle.Log.TotalDistance}");
Console.WriteLine();

Console.WriteLine($"Trip Log Entries:");
Console.WriteLine(vehicle.Log.GetPrintedEntries());
Console.WriteLine();

using ConsoleApp27.Implementations;

PassengerCar originalCar = new(
            "Toyota",
            "Camry",
            2022,
            5);

PassengerCar clonedCar =
    (PassengerCar)originalCar.MyClone();

clonedCar.Model = "Corolla";

Console.WriteLine("=== Original object ===");
Console.WriteLine(originalCar);

Console.WriteLine();

Console.WriteLine("=== Cloned object ===");
Console.WriteLine(clonedCar);
Console.WriteLine();

Truck originalTruck = new(
    "Volvo",
    "FH16",
2020,
    25);
Truck clonedTruck =
    (Truck)originalTruck.Clone();

clonedTruck.LoadCapacity = 30;

Console.WriteLine("=== Original truck ===");
Console.WriteLine(originalTruck);

Console.WriteLine();

Console.WriteLine("=== Cloned truck ===");
Console.WriteLine(clonedTruck);

Console.ReadLine();
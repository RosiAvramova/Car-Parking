
using exam_19._05;
Owner ivan = new Owner(123, "Ivan", "Sofia");
Owner petar = new Owner(412, "Petar", "Varna");


Car toyota = new Car("54875", "corola", "Toyota", "Yellow", "4", ivan);

Car BMV = new Car("123456", "bmw1", "bmw2", "white", "2" , petar);

Car Dacia = new Car("456321", "duster", "dacia", "brown", "4", ivan);




ParkingLot NDKparking = new ParkingLot(454, "Sofia", 10);
NDKparking.ListOfCars.Add(toyota);
NDKparking.ListOfCars.Add(BMV);
NDKparking.ListOfCars.Add(Dacia);
foreach (Car item in NDKparking.ListOfCars)
{
    Console.WriteLine(item.VIN);
}



// See https://aka.ms/new-console-template for more information
using Cars;

Console.WriteLine("Hello, World!");

Audi audi=new Audi();
Mercedes mercedes=new Mercedes();
Toyoto toyoto=new Toyoto();
Togg togg=new Togg();

audi.Brand = "Audi";
audi.Model = "A6 Avant e-tron";

mercedes.Brand = "Mercedes";
mercedes.Model = "Mercedes-Benz GLC";

togg.Brand = "TOGG";
togg.Model = "T10X";

toyoto.Brand= "Toyoto";
toyoto.Model = "Corolla";

audi.brandOfCar();
audi.modelOfCar();
Console.WriteLine();

mercedes.brandOfCar();
mercedes.modelOfCar();
Console.WriteLine();

toyoto.brandOfCar();
toyoto.modelOfCar();
Console.WriteLine();

togg.brandOfCar();
togg.modelOfCar();
Console.WriteLine();
using CarClassLibrary;

Car c = new Car();
Console.WriteLine("Car c is a {0} {1} that costs ${2} ", c.Make, c.Model, c.Price);

Car d = new Car("Ford", "Mustang", 50000);
Console.WriteLine("Car d is a {0} {1} that costs ${2} ", d.Make, d.Model, d.Price);

Console.ReadLine();
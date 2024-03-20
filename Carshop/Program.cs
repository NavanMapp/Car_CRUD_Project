using CarClassLibrary;

Console.WriteLine("Welcome to the car store. First you must create some car inventory. " +
    "Then you may add some cars to the store cart. Finally you may checkout which will give" +
    "you the total value of the cars you selected.");


Car c = new Car();
Console.WriteLine();

Car d = new Car("Ford", "Mustang", 50000);
Console.WriteLine("Car d is a {0} {1} that costs ${2} ", d.Make, d.Model, d.Price);



decimal total = s.Checkout();

int action = chooseAction();

while(action != 0)
{
    action = chooseAction();
}

static int chooseAction()
{
    Car car = new Car();
    Store s = new Store();

    int choice = 0;

    Console.WriteLine("Choose a Number to action request:\n (0) QUIT \n(1) ADD A NEW CAR into inventory \n" +
        "(2) ADD CAR TO CART \n(3) CHECKOUT");
    String input = Console.ReadLine();
    
    if (int.TryParse(input, out choice))
    {
        switch (choice)
        {
            case 1 : Console.WriteLine("You chose to add a new car into the Inventory.\nAdd Car Make: ");
                string carMake = car.Make;
                carMake = Console.ReadLine();
                Console.WriteLine("Add the Car Model:  ");
                string carModel = car.Model;
                carModel = Console.ReadLine();
                Console.WriteLine("Add the Price of the car");
                decimal carPrice = car.Price;
                carPrice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Car {0} {1} is a added into inventory and cost price is ${2} ", car.Make, car.Model, car.Price);
                break;
            case 2:
                s.CarList.Add(car);
                Console.WriteLine("");
                break;
            case 3:
                //Console.WriteLine($"Store value of the car is {total}");
                break;
        }
    
    }
    

    return choice;
}












Console.ReadLine();
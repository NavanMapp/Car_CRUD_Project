using CarClassLibrary;

Console.WriteLine("Welcome to the car store. First you must create some car inventory. " +
    "Then you may add some cars to the store cart. Finally you may checkout which will give" +
    "you the total value of the cars you selected.");


Car c = new Car();
Console.WriteLine();

Car d = new Car("Ford", "Mustang", 50000);
Console.WriteLine("Car d is a {0} {1} that costs ${2} ", d.Make, d.Model, d.Price);

Store s = new Store();
s.CarList.Add(c);
s.CarList.Add(d);

decimal total = s.Checkout();

int action = chooseAction();

while(action != 0)
{
    action = chooseAction();
}

static int chooseAction()
{
    Car car = new Car();
    int choice = 0;
    Console.WriteLine("Choose an action:\n (0) QUIT \n(1) ADD A NEW CAR into inventory \n" +
        "(2) ADD CAR TO CART \n(3) CHECKOUT");
    choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1 : Console.WriteLine("You chose to add a new car into the Inventory.\nAdd Car Make: ");
            break;
        case 2:
            Console.WriteLine("Car {0} {1} is a added into inventory and cost price is ${2} ", car.Make, car.Model, car.Price);
            break;
        case 3:
            Console.WriteLine($"Store value of the car is {total}");
            break;
    }
    

    return choice;
}












Console.ReadLine();
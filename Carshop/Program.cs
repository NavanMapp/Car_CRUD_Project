using CarClassLibrary;

Console.WriteLine("Welcome to the car store. First you must create some car inventory. " +
    "Then you may add some cars to the store cart. Finally you may checkout which will give" +
    "you the total value of the cars you selected.");

Store s = new Store();

int action = chooseAction();

while(action != 0)
{
    action = chooseAction();
}

static int chooseAction()
{
    Car car = new Car();
    Store s = new Store();
    decimal total = s.Checkout();

    int choice = 0;

    Console.WriteLine("Choose a Number to action request:\n (0) QUIT \n(1) ADD A NEW CAR into inventory \n" +
        "(2) ADD CAR TO CART \n(3) CHECKOUT");
    String input = Console.ReadLine();
    
    if (int.TryParse(input, out choice))
    {
        switch (choice)
        {
            case 1 :
                try
                {
                    Console.WriteLine("You chose to add a new car into the Inventory.\nAdd Car Make: ");
                    car.Make = Console.ReadLine();

                    Console.WriteLine("Add the Car Model:  ");
                    car.Model = Console.ReadLine();

                    Console.WriteLine("Add the Price of the car");
                    car.Price = Convert.ToInt32(Console.ReadLine());

                    s.CarList.Add(car);
                    Console.WriteLine(car.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                break;
            case 2:
                try
                {
                    foreach (Car c in s.CarList)
                    {
                        Console.WriteLine($"Cars stored in the store are: {c}");
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Car cannot be stored in the store");
                }
                
                break;
            case 3:
                Console.WriteLine($"Store value of the car is {total}");
                break;
        }
    }
    return choice;
}












Console.ReadLine();
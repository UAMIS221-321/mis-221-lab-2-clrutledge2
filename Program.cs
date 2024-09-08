
    int numberOfSandwiches = 0;
    string numberOfSandwich;
    int numberOfToppings = 0;
    string numberOfTopping;
    double tip = 0 ;
    string tips;
    double totalSandwichCost;
    double totalToppingCost;
    double baseCost;
    double COST_OF_SANDWICH = 4.75;
    double COST_OF_TOPPING = 0.55;
    double DISCOUNT_AMOUNT = 0.10;
    double orderCost = 0;

    // prompt user for the number of sandwiches
    Console.WriteLine("Enter the number of sandwiches you would like: ");
    numberOfSandwich = Console.ReadLine();
    numberOfSandwiches = Convert.ToInt32(numberOfSandwich);


    //prompt users for number of toppings;
    Console.WriteLine("Enter the number of toppings: ");
    numberOfTopping =Console.ReadLine();
    numberOfToppings = Convert.ToInt32(numberOfTopping);

    // prompt user for the tip
    Console.WriteLine("Enter the tip amount: ");
    tips = Console.ReadLine();
    tip = double.Parse(tips);

    totalSandwichCost = COST_OF_SANDWICH * numberOfSandwiches;
    totalToppingCost = COST_OF_TOPPING * numberOfToppings;
    baseCost = totalSandwichCost + totalToppingCost;

    orderCost = tip + baseCost * (1- DISCOUNT_AMOUNT);

    //Display orderCost
    Console.WriteLine("Your order cost is $"+ orderCost.ToString("F2"));



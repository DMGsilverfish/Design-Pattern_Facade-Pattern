using System;

// Step 1: Subsystem classes
class Kitchen
{
    public void PrepareMeal(string dish)
    {
        Console.WriteLine($"👨‍🍳 The kitchen is preparing the {dish}...");
    }
}

class Waiter
{
    public void TakeOrder(string dish)
    {
        Console.WriteLine($"🧾 The waiter takes the order for {dish}.");
    }

    public void ServeOrder(string dish)
    {
        Console.WriteLine($"🍽️ The waiter serves the {dish} to the customer.");
    }
}

class Billing
{
    public void GenerateBill(string dish)
    {
        Console.WriteLine($"💰 Bill generated for {dish}. Thank you for dining with us!");
    }
}

// Step 2: Facade class
class RestaurantFacade
{
    private readonly Kitchen _kitchen;
    private readonly Waiter _waiter;
    private readonly Billing _billing;

    public RestaurantFacade()
    {
        _kitchen = new Kitchen();
        _waiter = new Waiter();
        _billing = new Billing();
    }

    // Simplified method for the client
    public void OrderFood(string dish)
    {
        Console.WriteLine("\n=== Customer places an order ===");
        _waiter.TakeOrder(dish);
        _kitchen.PrepareMeal(dish);
        _waiter.ServeOrder(dish);
        _billing.GenerateBill(dish);
        Console.WriteLine("✅ Order complete!\n");
    }
}

// Step 3: Client code
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Facade Pattern Example ===");

        RestaurantFacade restaurant = new RestaurantFacade();

        restaurant.OrderFood("Margherita Pizza");
        restaurant.OrderFood("Pasta Alfredo");

        Console.WriteLine("🍷 The customer leaves happy!");
    }
}

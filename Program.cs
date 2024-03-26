// See https://aka.ms/new-console-template for more information
using sda_onsite_2_inventory_management.src;

internal class Program
{
    private static void Main(string[] args)
    {
        Store store = new("Supermarket");

        Item chocolate = new("Galaxy Crispy", 2);
        Item drinks = new("Milk", 5);
        Item care = new("Shampoo", 20);


        List<Item> items = store.GetItems();
        Console.WriteLine(items.Count);

        store.AddItems(chocolate);
        store.AddItems(drinks);
        store.AddItems(care);
        Console.WriteLine($"the current volume is {store.GetCurrentVolume()}");

        //Console.WriteLine("Counting" + items.Count);

        //store.RemoveItems(chocolate);

        foreach (Item item in items)
        {
            Console.WriteLine($"the name is {item.GetName()}, the quantity is {item.GetQuantity()}, it created at {item.GetCreatedAt()}");
        }
        // find item by name 
        var foundItem = store.FindItemByName("Milk");
        Console.WriteLine($"{foundItem}");

        List<Item> sorted = store.SortByNameAsc();
        foreach (var item in sorted)
        {
            Console.WriteLine(item.GetName());
        }
    }
}
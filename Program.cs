// See https://aka.ms/new-console-template for more information
using sda_onsite_2_inventory_management.src;

internal class Program
{
    private static void Main(string[] args)
    {
        Store store = new("Supermarket", 200);

        Item chocolate = new("Galaxy Crispy", 2);
        Item care = new("Shampoo", 20, new DateTime(2022, 09, 29));
        Item drinks = new("Milk", 30, new DateTime(2024, 02, 01));
        Item chocolate1 = new("After 8", 13, new DateTime(2024, 03, 15));




        List<Item> items = store.GetItems();
        Console.WriteLine(items.Count);

        store.AddItems(chocolate);
        store.AddItems(chocolate1);
        store.AddItems(drinks);
        store.AddItems(care);
        Console.WriteLine($"the current volume is {store.GetCurrentVolume()}");
        Console.WriteLine($"the max capacity is {store.GetMaxCapacity()}");


        //Console.WriteLine("Counting" + items.Count);

        store.RemoveItems(chocolate);

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

        List<Item> SortByDate = store.SortByDate(SortOrder.DESC);

        foreach (Item item in SortByDate)
        {
            Console.WriteLine($"name of the item is{item.GetName()}, it was created at {item.GetCreatedAt()}");

        }

        store.GroupByDate();
    }
}
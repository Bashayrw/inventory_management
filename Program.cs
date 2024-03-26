// See https://aka.ms/new-console-template for more information
using sda_onsite_2_inventory_management.src;

internal class Program
{
    private static void Main(string[] args)
    {
        Store store = new("Supermarket");

        Item chocolate = new("Galaxy Crispy", 2);
        Item drinks = new("Milk", 5);

        List<Item> items = store.GetItems();
        Console.WriteLine(items.Count);

        store.AddItems(chocolate);
        store.AddItems(drinks);
        store.GetCurrentVolume();
        //Console.WriteLine("Counting" + items.Count);

        //store.RemoveItems(chocolate);

        foreach (Item item in items)
        {
            Console.WriteLine($"the name is {item.GetName()}, the quantity is {item.GetQuantity()}, it created at {item.GetCreatedAt()}");

        }
        // find item by name 
        var foundItem = store.FindItemByName("Milk");
        Console.WriteLine($"{foundItem}");

    }
}











// Student student1 = new Student ("Bashayr");
// Inctructor instructor1 = new Inctructor("Thoa");
// Console.WriteLine(student1.GetFullName());
// Console.WriteLine(student1.GetId());

// Console.WriteLine(instructor1.GetFullName());


// class People
// {
//     private int _id;
//     private string _fullName;

//     public People(string fullName)
//     {
//         _id = DateTime.Now.Microsecond;
//         _fullName = fullName;
//     }

//     public int GetId()
//     {
//         return _id;
//     }

//     public string GetFullName()
//     {
//         return _fullName;
//     }
// }

// class Student : People
// {
//     private string _cohort;

//     public Student(string fullName) : base(fullName)
//     {
//     }
// }

// class Inctructor : People
// {
//     private List<string> _cohorts;

//     public Inctructor(string fullName) : base(fullName)
//     {
//     }
// }
/*
Class Item 
*/
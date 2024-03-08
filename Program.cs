
//Mohmmadabrar Malek
//#8891845
//MidTerm Exam

public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
        // TODO: Initialize the properties with the values passed to the constructor.
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        Price = newPrice;
        // TODO: Update the item's price with the new price.
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        QuantityInStock += additionalQuantity;
        // TODO: Increase the item's stock quantity by the additional quantity.
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        // TODO: Decrease the item's stock quantity by the quantity sold.
        // Make sure the stock doesn't go negative.
        QuantityInStock -= quantitySold;
        if (QuantityInStock < 0)
        {
            QuantityInStock = 0;
        }
    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        // TODO: Return true if the item is in stock (quantity > 0), otherwise false.
        if (QuantityInStock > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Print item details
    public void PrintDetails()
    {
        // TODO: Print the details of the item (name, id, price, and stock quantity).
        System.Console.WriteLine("--------------------------------");
        System.Console.WriteLine("Name : {0}\n Id : {1}\n Price : {2}\n Stock Quantity : {3}", ItemName, ItemId, Price, QuantityInStock);
        System.Console.WriteLine("--------------------------------");

    }
}
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

        // TODO: Implement logic to interact with these objects.
        // Example tasks:
        // 1. Print details of all items.
        System.Console.WriteLine("1) Details of the Both Items");
        item1.PrintDetails();
        item2.PrintDetails();
        System.Console.WriteLine("\n");



        // 2. Sell some items and then print the updated details.
        System.Console.WriteLine("2) Befoe Item 1");
        item1.PrintDetails();
        item1.SellItem(5);
        System.Console.WriteLine("2) After Selling 5 Qnt to Item 1");
        item1.PrintDetails();
        System.Console.WriteLine("\n");


        // 3. Restock an item and print the updated details.
        System.Console.WriteLine("3) Before Item 2");
        item2.PrintDetails();
        item2.RestockItem(10);
        System.Console.WriteLine("3) After Restocking 10 Qnt to Item 2");
        item2.PrintDetails();
        System.Console.WriteLine("\n");


        // 4. Check if an item is in stock and print a message accordingly.
        System.Console.WriteLine("4) Check if an item 2 is in stock ");
        if (item2.IsInStock())
        {
            System.Console.WriteLine("The Item is In Stock :)");
        }
        else
        {
            System.Console.WriteLine("Sorry.. The Items is out of Stock :(");
        }
        

       
    }
}

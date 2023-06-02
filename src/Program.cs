using System;
using src.Actions;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Printer.Print("Hello World!");

        Inventory inventory = Inventory.Instance;
        inventory.MaxCapacity = 10;
        Console.WriteLine(inventory.MaxCapacity);
        inventory.AddItem(new Item("123456789", "Apple", 10), 1);
        Console.WriteLine(inventory.Items[0].Name);
        inventory.RemoveItem("123456789");
        Console.WriteLine(inventory.Items.Count);
        inventory.AddItem(new Item("1234567809", "Apple2", 14), 1);
        inventory.ViewInventory();
        inventory.AddItem(new Item("1111", "jooo", 3), 2);
        inventory.ViewInventory();
        inventory.AddItem(new Item("123456781", "Apple3", 15), 1);
   
        inventory.IncreaseQuantity("123456789", 5);
        Console.WriteLine(inventory.Items[0].Quantity);
        inventory.DecreaseQuantity("123456781", 2);
        Console.WriteLine(inventory.Items[1].Quantity);
        inventory.ViewInventory();
        inventory.RemoveItem("123456789");
        inventory.ViewInventory();
        
       

        Item item = new Item("123456789", "Apple", 10);
        Console.WriteLine(item.Name + " " + item.Quantity + " " + item.Barcode);
        item.Name = "Orange";
        Console.WriteLine(item.Name + " " + item.Quantity + " " + item.Barcode);
        item.DecreaseQuantity(5);
        Console.WriteLine(item.Name + " " + item.Quantity + " " + item.Barcode);
        item.IncreaseQuantity(1);
        Console.WriteLine(item.Name + " " + item.Quantity);
    }
}


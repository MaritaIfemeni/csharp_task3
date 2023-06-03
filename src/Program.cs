using System;
using src.Actions;

internal class Program
{
    static void Main(string[] args)
    {
        using (Inventory inventory = Inventory.Instance) 
        {
            inventory.MaxCapacity = 10;
            inventory.AddItem(new Item("123456789", "Apple", 10), 1);
            inventory.AddItem(new Item("55555", "banana", 10), 2);
            inventory.RemoveItem("123456789");
            inventory.AddItem(new Item("1234567809", "Apple2", 14), 1);
            inventory.ViewInventory();
            inventory.AddItem(new Item("1111", "jooo", 3), 2);
            inventory.ViewInventory();
            inventory.AddItem(new Item("123456781", "Apple3", 15), 1);
            Printer.PrintInventory(inventory);
            Printer.PrintItem(inventory.Items[0]);
            inventory.IncreaseQuantity("123456789", 5);
            inventory.DecreaseQuantity("123456781", 2);
            Printer.PrintItem(inventory.Items[2]);
            inventory.ViewInventory();
            inventory.RemoveItem("123456789");
            inventory.ViewInventory();
        }
    }
}


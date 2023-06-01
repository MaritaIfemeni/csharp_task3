using System;
using src.Actions;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Printer.Print("Hello World!");

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



namespace src.Actions
{
    public class Printer
    {
        public static void PrintItem(Item item)
        {
            Console.WriteLine("Item name from PrintItem: " + item.Name + " Barcode: " + item.Barcode);
        }
        public static void PrintInventory(Inventory inventory)
        {
            Console.WriteLine("Current inventory from printer:");
            Console.WriteLine("Number of unique items: " + inventory.Items.Count);
            int totalQuantity = 0;
            foreach (Item item in inventory.Items)
            {
                totalQuantity += item.Quantity;
                Console.WriteLine("Item name from printer: " + item.Name + " Barcode: " + item.Barcode + " Quantity: " + item.Quantity);
            }
            Console.WriteLine("Total number of items: " + totalQuantity);
        }
    }
}

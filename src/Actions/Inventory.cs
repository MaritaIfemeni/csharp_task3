namespace src.Actions
{
    public class Inventory : IDisposable
    {
        private static readonly Inventory instance = new Inventory();
        private List<Item> items;
        private int maxCapacity;

        private Inventory()
        {
            items = new List<Item>();
        }
        public static Inventory Instance
        {
            get { return instance; }
        }
        public List<Item> Items
        {
            get { return items; }
        }
        public int MaxCapacity
        {
            get { return maxCapacity; }
            set { maxCapacity = value; }
        }
        public bool AddItem(Item item, int quantity)
        {
            if (items.Count < maxCapacity)
            {
                item.Quantity = quantity;
                items.Add(item);
                return true;
            }
            return false;
        }
        public bool RemoveItem(string barcode)
        {
            foreach (Item item in items)
            {
                if (item.Barcode == barcode)
                {
                    items.Remove(item);
                    return true;
                }
            }
            return false;
        }
        public void IncreaseQuantity(string barcode, int quantity)
        {
            foreach (Item item in items)
            {
                if (item.Barcode == barcode)
                {
                    item.Quantity += quantity;
                }
            }
        }
        public void DecreaseQuantity(string barcode, int quantity)
        {
            List<Item> itemsToRemove = new List<Item>();

            foreach (Item item in items)
            {
                if (item.Barcode == barcode)
                {
                    if (item.Quantity < quantity)
                    {
                        itemsToRemove.Add(item);
                    }
                    else
                    {
                        item.Quantity -= quantity;
                    }
                }
            }
            foreach (Item itemToRemove in itemsToRemove)
            {
                items.Remove(itemToRemove);
            }
        }
        public void ViewInventory()
        {
            Console.WriteLine("Current inventory consists:");
            foreach (Item item in items)
            {
                Console.WriteLine("Item name: " + item.Name + " Barcode: " + item.Barcode + " Quantity: " + item.Quantity);
            }
        }
        public void Dispose()
        {
            Console.WriteLine("Inventory is destroyed");
        }
    }
}
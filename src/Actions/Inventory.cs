namespace src.Actions
{
    public class Inventory
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
            //3. Method `AddItem` that takes two parameters (item and item quantity) and adds the item to the inventory. If the inventory reaches `maxCapacity`, the method should return false. Otherwise, it should add or replace the item in `items`.
        }

        public bool RemoveItem(string barcode)
        {
            //4. Method `RemoveItem` that takes a string parameter (item barcode) and removes the item from the inventory. If the item does not exist in the inventory, the method should return false. Otherwise, it should remove the item from items and return true.
        }

        public void IncreaseQuantity(string barcode, int quantity)
        {
            // 5. Method `IncreaseQuantity` that takes an integer parameter and a string parameter (item barcode), and increase the amount of item in the inventory.
        }

        public void DecreaseQuantity(string barcode, int quantity)
        {
            // 6. Method `DecreaseQuantity` that takes an integer parameter and a string parameter (item barcode), and decrease the amount of item in the inventory.
        }
        public void ViewInventory()
        {
            // Method called `ViewInventory` that prints the items (barcode, name, quantity) in the inventory to the console.
        }
        
        ~Inventory()
        {
            // A destructor that prints a message to the console when the inventory is destroyed.
        }
    }
}
namespace src.Actions
{
    public class Item
    {

        private static string _barcode = "";
        private string _name;
        private int _quantity;
        public string Barcode
        {
            get { return _barcode; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        public Item(string barcode, string name, int quantity)
        {
            _barcode = barcode;
            _name = name;
            _quantity = quantity;
        }

        public void IncreaseQuantity(int amount)
        {
            if (amount >= 0)
            {
                _quantity += amount;
            }
        }

        public void DecreaseQuantity(int amount)
        {
            if (amount >= 0)
            {
                _quantity -= amount;
                if (_quantity < 0)
                {
                    _quantity = 0;
                }
            }

        }
    }
}



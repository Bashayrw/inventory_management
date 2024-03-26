

namespace sda_onsite_2_inventory_management.src
{
    public class Item
    {
        // declare the properties 
        private readonly string _name;
        private int _quantity;
        private DateTime? _createdAt;

        public Item(string name, int quantity, DateTime createdDate = default)
        {
            _name = name;
            _quantity = quantity;
            _createdAt = createdDate == default ? DateTime.Now : createdDate;
        }
        // declare the get methods
        public string GetName()
        {
            return _name;
        }
        public int GetQuantity()
        {
            return _quantity;
        }
        public DateTime? GetCreatedAt()
        {
            return _createdAt;
        }
    }
}
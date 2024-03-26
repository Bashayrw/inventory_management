using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace sda_onsite_2_inventory_management.src
{
    public class Store
    {
        private List<Item> _items;
        private readonly string _name;

        // var store1 = new Store("manuel")
        public Store(string name)
        {
            _name = name;
            _items = []; // automatically give the empty array of items
        }
        public List<Item> GetItems()
        {
            return _items;
        }
        public bool AddItems(Item newItem)
        {
            Item? foundItem = _items.Find(item => item.GetName() == newItem.GetName());

            if (foundItem is null)
            {
                _items.Add(newItem);
                return true;
            }
            return false;

        }
        public bool RemoveItems(Item newItem)
        {
            _items.Remove(newItem);
            return true;
        }

        public int GetCurrentVolume()
        {
            int totalAmount = 0;
            foreach (Item item in _items)
            {
                totalAmount += item.GetQuantity();
            }
            return totalAmount;
        }

        public Item? FindItemByName(string name)
        {
            var findItem = _items.Find(item => item.GetName() == name);
            // if we find the item, not null, then return the findItem
            if (findItem != null)
            {
                return findItem;
            }
            throw new ArgumentException("cannot find the item!!!");
        }

        public List<Item> SortByNameAsc()
        {
            return _items.OrderBy(item => item.GetName()).ToList();
        }
    }
}
